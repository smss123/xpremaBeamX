using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using XBeamDataLayer.PhoneNumber;
namespace XpremaBeam.WhatsNumbers
{
    public partial class frmGenerateNumber : RadForm
    {
        WhatsAppNumberCmd cmd = new WhatsAppNumberCmd();
        CountryCmd cmdx = new CountryCmd();
        public frmGenerateNumber()
        {
            InitializeComponent();
            cmd.OnChangeValue += cmd_OnChangeValue;
        }

        void cmd_OnChangeValue(object sender, string process, string msg)
        {
           // Operation.ShowToustOk(msg, this);
            this.Invoke((MethodInvoker)delegate {
                lblSave.Text = process + "\\" + msg;
            
            });
        }
        private void GenerateNumber()
        {
            long StartNumber =long.Parse(txtStartNumber.Text);
            long StopNumber = long.Parse(txtStopNumber.Text);
            long countr =  StopNumber-StartNumber;
            radProgressBar1.Maximum = int.Parse(countr.ToString());
           
            //-----------
            for (long i = StartNumber; i <= StopNumber; i++)
            {
              /* this.Invoke((MethodInvoker)delegate {
                    radProgressBar1.Text = i.ToString();
                    radProgressBar1.Value1++;
                    Countrykey = txtCountryKey.Text;
                    country = int.Parse(CountrycomboBox.SelectedValue.ToString());
                });*/
                cmd.AddNumber(new XBeamDataLayer.WhatsAppNumber() { 
                 ContactName="-",
                  CountryID = country,
                   PhoneNumber= Countrykey+i.ToString(),
                    CurrentStatus="Active",
                     WhatsAppStatus="-",
                });  
            }

        }
        Thread th = null;
        private int? country;
        private string Countrykey;
        private void frmGenerateNumber_Load(object sender, EventArgs e)
        {
            CountrycomboBox.DataSource = cmdx.GetAll();
            CountrycomboBox.DisplayMember = "CountryName";
            CountrycomboBox.ValueMember = "ID";
            th = new Thread(GenerateNumber);
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            th.Start();
        }

        private void radLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
