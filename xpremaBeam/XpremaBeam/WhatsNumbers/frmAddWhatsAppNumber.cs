using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XBeamDataLayer;
using XBeamDataLayer.PhoneNumber;
using Xprema.XExtention;

namespace XpremaBeam
{
    public partial class frmAddWhatsAppNumber : RadForm
    {
        WhatsAppNumberCmd cmd = new WhatsAppNumberCmd();
        CountryCmd count = new CountryCmd();


        public frmAddWhatsAppNumber()
        {
            InitializeComponent();
            cmd.OnChangeValue += cmd_OnChangeValue;
        }

        void cmd_OnChangeValue(object sender, string process, string msg)
        {
            Operation.ShowToustOk(msg, this);
        }
        
        private void frmAddWhatsAppNumber_Load(object sender, EventArgs e)
        {
            CountryColumnComboBox1.DataSource = count.GetAll();
            CountryColumnComboBox1.ValueMember = "ID";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            cmd.AddNumber(new WhatsAppNumber()
            {
                 ContactName = contactNameTextBox.Text,
                  CurrentStatus= currentStatusTextBox.Text,
                   WhatsAppStatus= whatsAppStatusTextBox.Text,
                    PhoneNumber = phoneNumberTextBox.Text,
                 CountryID = CountryColumnComboBox1.SelectedValue.ToString().ToInt()
            });
        }
    }
}
