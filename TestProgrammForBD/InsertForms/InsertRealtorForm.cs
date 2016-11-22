using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgrammForBD.InsertForms
{
    public partial class InsertRealtorForm : Form
    {
        public InsertRealtorForm()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            TestForm frm = (TestForm)this.Owner;
            TestData test = frm.Test;
            sysLabel.Text = test.InsertIntoRealtor(inputNameField.Text, inputSurnameField.Text,
                inputPatrField.Text, inputPhoneField.Text, inputAdressFiels.Text);
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
