using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgrammForBD
{
   
    public partial class UpdateClientForm : Form
    {
        private string[] temp;
        public UpdateClientForm(string [] temp)
        {
            this.temp = temp;
            InitializeComponent();
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
           

            TestForm frm = (TestForm)this.Owner;

            TestData test = frm.Test;

            sysLabel.Text = test.UpdateIntoClient(outNameField.Text, outSurnameField.Text, outPatrField.Text, outPhoneField.Text, outAddresField.Text, Convert.ToInt32(temp[0]));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void UpdateClientForm_Load(object sender, EventArgs e)
        {
            outNameField.Text = temp[1];
            outSurnameField.Text = temp[2];
            outPatrField.Text = temp[3];
            outPhoneField.Text = temp[4];
            outAddresField.Text = temp[5];
        }
    }
}
