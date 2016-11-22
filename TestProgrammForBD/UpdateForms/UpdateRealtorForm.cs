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
    public partial class UpdateRealtorForm : Form
    {
        private string [] temp;
        public UpdateRealtorForm(string [] temp)
        {
            this.temp = temp;
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            TestForm frm = (TestForm)this.Owner;
            
            TestData test = frm.Test;
            
            sysLabel.Text = test.UpdateIntoRealtor(outNameField.Text, outSurnameField.Text, outPatrField.Text, outPhoneField.Text, outAddresField.Text,Convert.ToInt32(temp[0]));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateRealtorForm_Load(object sender, EventArgs e)
        {
            outNameField.Text = temp[1];
            outSurnameField.Text = temp[2];
            outPatrField.Text = temp[3];
            outPhoneField.Text = temp[4];
            outAddresField.Text = temp[5];
        }
    }
}
