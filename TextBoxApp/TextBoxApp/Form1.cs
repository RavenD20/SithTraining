using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxApp
{
    public partial class ActionBTN : Form
    {
        public ActionBTN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hello and welcome to the Matrix");
            string words = textBox1.Text;
            label1.Text = words;




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnrun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Heeeeeeeeeeeeeeeelllllllllllppppp Meeeeeeeeeeeeeeeeee");

        }
    }
}
