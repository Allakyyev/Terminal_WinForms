using System;
using System.Windows.Forms;
using BillValidator.CashCode.Driver;
using DevExpress.Skins;
using DXApplication4.CacheCodeService;

namespace DXApplication4 {
    internal static class Program {
        public static CashCodeValidatorService CashCodeValidatorService = new CashCodeValidatorService("COM9");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(CashCodeValidatorService));
        }
    }
}
