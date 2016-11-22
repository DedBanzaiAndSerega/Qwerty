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
    public partial class InsertClientForm : Form
    {
        public InsertClientForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inputNameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            TestForm frm = (TestForm)this.Owner;
            TestData test = frm.Test;
            sysLabel.Text = test.InsertIntoClient(inputNameField.Text, inputSurnameField.Text, 
                inputPatrField.Text, inputPhoneField.Text, inputAdressFiels.Text);
        }

        private void inputAdressFiels_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputPhoneField_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputPatrField_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputSurnameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void patrLabel_Click(object sender, EventArgs e)
        {

        }

        private void surnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void sysLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
