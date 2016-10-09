using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FindExe.Presenters;

namespace FindExe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isReady;
            var mutex = new System.Threading.Mutex(true, "Find EXE", out isReady);
            if (!isReady)
            {
                //Console.WriteLine("Another instance is already running.");
                return;
            }
            GC.KeepAlive(mutex);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var clientsPresenter = new FindExePresenter(new FindExeForm());
        }
    }
}
