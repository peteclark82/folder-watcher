using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace FolderWatcher.Core
{
    public class RunBatchFileAction : ITriggeredAction
    {
        [Description("Full file path of the Batch file to execute as a result of this action.")]
        [EditorAttribute(typeof(FileNameEditor), typeof(UITypeEditor))]        
        public string BatchFile { get; set; }

        [Description("When enabled allows multiple concurrent executions of the batch file, when disabled attempts to run whilst it is currently executing will be suppressed.")]
        public bool AllowMultipleExecutions { get; set; }

        private int _currentTaskCount;
        private LogManager _logger;

        public RunBatchFileAction()
        {
            _logger = LogManager.Create("RunBatchFileAction");
        }

        public void Execute(Action<string, string> finishedCallback)
        {
            if (AllowMultipleExecutions || _currentTaskCount == 0)
            {
                Task.Run(() =>
                {
                    var processInfo = new ProcessStartInfo("cmd.exe", "/c \"" + BatchFile +"\"");
                    processInfo.CreateNoWindow = true;
                    processInfo.UseShellExecute = false;
                    processInfo.RedirectStandardError = true;
                    processInfo.RedirectStandardOutput = true;

                    var stdOut = new StringBuilder();
                    var stdErr = new StringBuilder();

                    _logger.Info("Action fired, executing file : {0}", BatchFile);
                    Process process;
                    try
                    {
                        process = Process.Start(processInfo);
                    }
                    catch (Exception ex)
                    {
                        process = null;
                        finishedCallback(string.Format("An exception occurred : {0}\n{1}", ex.Message, ex.StackTrace), null);
                    }

                    if (process != null)
                    {
                        process.OutputDataReceived += (sender, args) =>
                        {
                            stdOut.AppendLine(args.Data);
                        };
                        process.BeginOutputReadLine();
                        process.ErrorDataReceived += (sender, args) =>
                        {
                            stdErr.AppendLine(args.Data);
                        };
                        process.BeginErrorReadLine();

                        process.WaitForExit();

                        if (process.ExitCode > 0)
                        {
                            finishedCallback(string.Format("Process Failed. Exited with code '{0}'\n{1}", process.ExitCode, stdErr), stdOut.ToString());
                        }
                        else
                        {
                            finishedCallback(null, stdOut.ToString());
                        }

                        process.Close();
                    }

                    _currentTaskCount--;
                });
                _currentTaskCount++;
            } 
            else
            {
                _logger.Debug("Action suppressed, it is already executing and AllowMultipleExecutions is true.");    
            }
        }
    }
}