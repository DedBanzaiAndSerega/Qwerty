using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgrammForBD.UpdateForms
{
    public partial class UpdatePropertyForm : Form
    {
        public UpdatePropertyForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            TestForm frm = (TestForm)this.Owner;
            TestData test = frm.Test;
            List<Temp> tempIn = new List<Temp>();
            tempIn.Add(new Temp { Label = conditionLabel.Text, Text = inputConField.Text });
            tempIn.Add(new Temp { Label = livingLabel.Text, Text = inputLivField.Text });
            tempIn.Add(new Temp { Label = justlabel.Text, Text = inputJustField.Text });
            tempIn.Add(new Temp { Label = addressLabel.Text, Text = inputAddressField.Text });
            
            List<Temp> tempOut = new List<Temp>();
            tempOut.Add(new Temp { Label = conditionLabel.Text, Text = outConField.Text });
            tempOut.Add(new Temp { Label = livingLabel.Text, Text = outLiveField.Text });
            tempOut.Add(new Temp { Label = justlabel.Text, Text = outJustField.Text });
            tempOut.Add(new Temp { Label = addressLabel.Text, Text = outAddressField.Text });
           

          
        }
    }
}
