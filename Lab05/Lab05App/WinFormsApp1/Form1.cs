using Lab05App.InterfaceLib;
using System.Diagnostics;
using System.Reflection;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string functionsDllPAth = $@"{Environment.CurrentDirectory}\Lab05App.Functions.dll";
        private Type functionType;
        private object functionClass;

        public Form1()
        {
            InitializeComponent();
            try
            {
                string message = Interface.TestConection();
                MessageBox.Show(message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        private void loadDLLButton_Click(object sender, EventArgs e)
        {
            var currentProcess = Process.GetCurrentProcess();
            var count = currentProcess.Modules.Cast<ProcessModule>().Count(module => module.FileName == functionsDllPAth);

            if (count != 0)
            {
                MessageBox.Show("Functions DLL not found!");
                return;
            }

            Assembly functionsDll;
            try
            {
                functionsDll = Assembly.LoadFile(functionsDllPAth);
                MessageBox.Show("DLL connected");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }

            functionType = functionsDll.GetType("Lab05App.Functions.Functions");
            functionClass = Activator.CreateInstance(functionType);
        }

        private void mathLibraryButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Pow2 in 5 = {Math.Pow(2, 5)}");
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (functionClass != null)
            {
                functionType.InvokeMember("ThreadTest", BindingFlags.InvokeMethod, Type.DefaultBinder, functionClass, new object[] { });
                MessageBox.Show("Sorted");
            }
            else
            {
                MessageBox.Show("Functions DLL not connected");
            }
        }
    }
}