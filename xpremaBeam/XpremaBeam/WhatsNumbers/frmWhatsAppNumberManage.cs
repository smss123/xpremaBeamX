using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XBeamDataLayer.PhoneNumber;

namespace XpremaBeam.WhatsNumbers
{
    public partial class frmWhatsAppNumberManage : Form
 {
        WhatsAppNumberCmd cmd = new WhatsAppNumberCmd();
        public frmWhatsAppNumberManage()
        {

            InitializeComponent();
            cmd.OnChangeValue += cmd_OnChangeValue;
        }

        void cmd_OnChangeValue(object sender, string process, string msg)
        {
            Operation.ShowToustOk(msg, this);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddWhatsAppNumber frm = new frmAddWhatsAppNumber();
            frm.ShowDialog();
        }

        private void frmWhatsAppNumberManage_Load(object sender, EventArgs e)
        {
            radGridView1.DataSource = "";

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            frmGenerateNumber frm = new frmGenerateNumber();
            frm.ShowDialog();
        }
    }
}
