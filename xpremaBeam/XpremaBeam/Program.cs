using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XBeamDataLayer;
using XpremaBeam.WhatsNumbers;
namespace XpremaBeam
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
            DatabaseBase.OnConnectionChange += DatabaseBase_OnConnectionChange;
            DatabaseBase.StartConnection();
            Application.Run(new frmWhatsAppNumberManage());
        }

        static void DatabaseBase_OnConnectionChange(object sender, string status)
        {
            MessageBox.Show(status);
        }
    }
}
