using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProgrammForBD.UpdateForms;
using TestProgrammForBD.InsertForms;

namespace TestProgrammForBD
{
    public partial class TestForm : Form
    {
        TestForm testik;
        // SqlConnection conn;
        TestData test;
        public TestData Test
        {
            get { return test; }
            set { test = value; }
        }
        public int a;
        public TestForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            testik = this;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dFDataSet.Client". При необходимости она может быть перемещена или удалена.
           // this.clientTableAdapter.Fill(this.dFDataSet.Client);

        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void conButton_Click(object sender, EventArgs e)
        {
            
            test = new TestData();
            try 
            {
                sysLabel.Text = test.Connect();
            }
            catch( SqlException se)
            {
                sysLabel.Text = se.Message;
            }
            //string connStr = @"Data Source=(local)\SQLEXPRESS;
            //                Initial Catalog=DF;
            //                Integrated Security=True";
            //conn = new SqlConnection(connStr);
            //try
            //{
            //    //пробуем подключится
            //    conn.Open();
            //}
            //catch (SqlException se)
            //{
            //    sysLabel.ForeColor = Color.Red;
            //    sysLabel.Text = "Ошибка подключения:" + se.Message;
            //    // Console.WriteLine("Ошибка подключения:{0}", se.Message);
            //    return;
            //}
            //sysLabel.ForeColor = Color.Green;
            //sysLabel.Text = "успешно";
            //dataGridView1.Columns.Add("1", "2");
            //dataGridView1.Columns.Add("2", "3");

        }

        private void upButton_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = test.Show(chooseBox.SelectedItem as string);
           dataGrid.DataSource = table;
            
            
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            
            int ID =  (int)dataGrid[0, dataGrid.CurrentRow.Index].Value;
            sysLabel.Text = test.Delete(ID);
            DataTable table = new DataTable();
            table = test.Show(chooseBox.SelectedItem as string);
            dataGrid.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("сохранить изменения?", "Внимание",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataTable table = new DataTable();
                table = (DataTable)dataGrid.DataSource;
                test.Reset(table, chooseBox.SelectedItem as string);
            }
                    
           
        }
       
        private void updateButton_Click(object sender, EventArgs e)
        {
            
            switch(chooseBox.SelectedItem.ToString())
            {
                case "Realtor":
                    string [] tempR = new string [dataGrid.ColumnCount];
                    for (int i = 0; i < dataGrid.ColumnCount; i++)
                    {
                        tempR[i] = (dataGrid[i, dataGrid.CurrentRow.Index].Value.ToString());
                    }
                    UpdateRealtorForm upRealtorForm = new UpdateRealtorForm(tempR);
                    upRealtorForm.Owner = this;
                    upRealtorForm.Show();
                    break;
                case "Client":
                    string[] tempC = new string[dataGrid.ColumnCount];
                    for (int i = 0; i < dataGrid.ColumnCount; i++)
                    {
                        tempC[i] = (dataGrid[i, dataGrid.CurrentRow.Index].Value.ToString());
                    }
                    UpdateClientForm upClientForm = new UpdateClientForm(tempC);
                    upClientForm.Owner = this;
                    upClientForm.Show();
                    break;
                case "TheProperty":
                    UpdatePropertyForm upPropertyForm = new UpdatePropertyForm();
                    upPropertyForm.Owner = this;
                    upPropertyForm.Show();
                    break;
            }
                
            
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            switch (chooseBox.SelectedItem.ToString())
            {
                case "Realtor":
                    InsertRealtorForm inRealtFOrm = new InsertRealtorForm();
                    inRealtFOrm.Owner = this;
                    inRealtFOrm.Show();
                    break;
                case "Client":
                    InsertClientForm inClientForm = new InsertClientForm();
                    inClientForm.Owner = this;
                    inClientForm.Show();
                    break;
                case "TheProperty":
                    InsertPropertyForm inPropForm = new InsertPropertyForm();
                    inPropForm.Owner = this;
                    inPropForm.Show();
                    break;
            }
        }

        private void QuartButton_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = test.ShowProperties();
        }
    }
}
