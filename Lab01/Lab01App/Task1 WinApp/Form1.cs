using System.IO.MemoryMappedFiles;
using System.Text;

namespace Task1_WinApp
{
    public partial class Form1 : Form
    {
        bool isOpenedMappedFileOnce;
        Mutex mutex;

        public Form1()
        {
            InitializeComponent();
            isOpenedMappedFileOnce = false;
            mutex = new();
        }

        private void timer_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            OutputTextBox.Text = "";
            mutex.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                using (var file = MemoryMappedFile.OpenExisting("mappedFile"))
                {
                    using (var reader = file.CreateViewAccessor(0, 25))
                    {
                        mutex.WaitOne();
                        var bytes = new byte[25];
                        reader.ReadArray<byte>(0, bytes, 0, bytes.Length);

                        StringBuilder sb = new StringBuilder();
                        for (var i = 0; i < bytes.Length; i++)
                        {
                            sb.Append($"{bytes[i]} ");
                        }
                        OutputTextBox.Text += sb.ToString() + Environment.NewLine;
                        mutex.ReleaseMutex();
                    }
                }
            }
            catch
            {
                if (!isOpenedMappedFileOnce)
                {
                    isOpenedMappedFileOnce = true;
                    OutputTextBox.Text = "";
                    OutputTextBox.AppendText("Не отримали дані з файлу. Переконайтесь, що консольний додаток запущений" + Environment.NewLine);
                }
            }
        }
    }
}