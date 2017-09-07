using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QueryCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)



        {

            if (textBox2.TextLength> 0)
            {
                SelectData(textBox2.Text);

            }
        }

            private void SelectData(string selectCommandText)
            {
                try
                {
                //Change the connecion string
                // to match with your system.
                string selectConnection =
                  @"Data Source = IRON\APOLLO;          Initial Catalog = AdventureWorks2014;         Integrated Security = True";
                    SqlDataAdapter dataAdapter =
                        new SqlDataAdapter(
                            selectCommandText, selectConnection);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

               

            }

        
    }




    }




























