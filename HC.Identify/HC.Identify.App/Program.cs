using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HC.Identify.App
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            //System.Windows.Forms.Application.Run(new Main());
            System.Windows.Forms.Application.Run(new Login());
            //System.Windows.Forms.Application.Run(new Workbench());
            //System.Windows.Forms.Application.Run(new VisionProSetting());
            //System.Windows.Forms.Application.Run(new WorkbenchNew());

        }
    }
}
