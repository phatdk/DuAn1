using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PL.Views
{
    public partial class testReturn : Form
    {
        public testReturn()
        {
            InitializeComponent();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "a" && textBox2.Text == "b")
            {
                MessageBox.Show("True");
            }
            else if(textBox1.Text == "a") 
            {
                MessageBox.Show("False");
            }
            else if(textBox2.Text == "b")
            {
                MessageBox.Show("Hiện ra một cái gì đấy");
            }
            
        }
    }
}
