using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly StringBuilder stringBuilder;

        public Form1()
        {
            InitializeComponent();
            stringBuilder = new StringBuilder();
        }

        private void ResetStringBuilderWithMessage(string message)
        {
            stringBuilder.Clear();
            stringBuilder.Append(message);
        }

        private void Log(string data, bool clear = true)
        {
            if (clear)
                OutputTextBox.Clear();
            OutputTextBox.AppendText(data);
        }

        private void GetAutoServisesButton_Click(object sender, EventArgs e)
        {
            ResetStringBuilderWithMessage("Служби поточного користувача з автозавантаженням:" + Environment.NewLine);

            var services = Registry.CurrentUser
                 .OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run")
                 ?.GetValueNames()
                 .Where(s => !string.IsNullOrEmpty(s))
                 .ToList();

            services?.ForEach(s => stringBuilder.Append(s + Environment.NewLine));

            Log(stringBuilder.ToString());
        }

        private void GetAutoServisesAllUsersButton_Click(object sender, EventArgs e)
        {
            ResetStringBuilderWithMessage("Служби, всіх користувачів з автозавантаженням:" + Environment.NewLine);
            var services = Registry.LocalMachine
                 .OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run")
                 ?.GetValueNames()
                 .ToList();

            services?.ForEach(s => stringBuilder.Append(s + Environment.NewLine));
            Log(stringBuilder.ToString());
        }

        private IEnumerable<Microsoft.Win32.TaskScheduler.Task> ParseScheduledTasks()
        {
            using (TaskService ts = new TaskService())
            {
                return ts.AllTasks.Select(x => x);
            }
        }

        private void GetScheduleTasksButton_Click(object sender, EventArgs e)
        {
            ResetStringBuilderWithMessage("Завдання Планувальника задач:" + Environment.NewLine);
            ParseScheduledTasks()?.ToList().ForEach(s => stringBuilder.Append(s.Name + Environment.NewLine));
            Log(stringBuilder.ToString());
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            var toSetAutorun = NewTaskTextBox.Text;
            if (!string.IsNullOrEmpty(toSetAutorun))
            {
                using (var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    key?.SetValue(toSetAutorun, "\"" + toSetAutorun + "\"");
                }
            }
        }

        public void ExportKey(string key, string path)
        {
            string arguments = $"reg export \"{key}\" \"{path}\" /y";
            string strCmdText = "/C " + arguments;
            const string FILE_NAME = "CMD.exe";

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = FILE_NAME,
                    Arguments = strCmdText,
                    UseShellExecute = false,
                    CreateNoWindow = false
                }
            };

            try
            {
                process.Start();
                process.WaitForExit();
            }
            finally
            {
                process.Dispose();
            }
        }

        private void CopySectionButton_Click(object sender, EventArgs e)
        {
            string key = CopyTextBox.Text;
            var path = $@"{Environment.CurrentDirectory}\{key.Replace('\\', '-')}.reg";

            ExportKey(key, path);
            MessageBox.Show("Done!");

            CopyTextBox.Text = string.Empty;
        }
    }
}