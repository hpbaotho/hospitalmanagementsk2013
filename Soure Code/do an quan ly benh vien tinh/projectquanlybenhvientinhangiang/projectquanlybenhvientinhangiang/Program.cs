using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace projectquanlybenhvientinhangiang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frchinh());
            //Application.Run(new frquanlytaikhoan());
            //Application.Run(new fr_rp_hosobenhnhan());
            //Application.Run(new fr_rp_hosonhanvien());
        }
    }
}
