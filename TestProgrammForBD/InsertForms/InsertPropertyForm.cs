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
    public partial class InsertPropertyForm : Form
    {
        public InsertPropertyForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            TestForm frm = (TestForm)this.Owner;
            TestData test = frm.Test;
            sysLabel.Text = test.InsertIntoProperty(inputConField.Text, Convert.ToInt32(inputLiveField.Text),
               Convert.ToInt32(inputJustField.Text),inputAddrField.Text);
        }

        private void inputLiveField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
