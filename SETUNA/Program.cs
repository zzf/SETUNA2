using System;
using System.Windows.Forms;
using com.clearunit;

namespace SETUNA
{
    // Token: 0x02000086 RID: 134
    internal static class Program
    {
        // Token: 0x0600046B RID: 1131 RVA: 0x0001CA08 File Offset: 0x0001AC08
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool flag = false;
            System.Threading.Mutex hMutex = new System.Threading.Mutex(true, Application.ProductName, out flag);
            bool b = hMutex.WaitOne(0, false);
            if(false == flag)
            {
                //已经有启动的项目了
                MessageBox.Show("Have Exist App Running");
                Console.WriteLine("Have Exist App Running !");
                Environment.Exit(1);
            }
            // 不是Win10周年更新版本及以上的，设置DPI感知
            var osVersion = Environment.OSVersion.Version;
            if (osVersion == null || osVersion.Major < 10 || osVersion.Build < 14393)
            {
                SETUNA.Main.WindowsAPI.SetProcessDPIAware();
            }

            var instance = SingletonApplication.GetInstance(Application.ProductVersion, args);
            if (instance.Register())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var mainform = new Mainform();
                instance.AddSingletonFormListener(mainform);
                mainform.CommandRun(args);
                Application.Run(mainform);
            }
        }
    }
}
