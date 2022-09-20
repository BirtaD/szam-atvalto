using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Számrendszerátváltó
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                radioButton2.Checked = false;
                radioButton1.Checked = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                textEdit2.Text = Convert.ToString(Convert.ToInt32(textEdit1.Text), 2);
            }
            else if (radioButton2.Checked == true) {
                textEdit2.Text = Convert.ToInt32(textEdit1.Text, 2).ToString();
            }
        }
    }
}
