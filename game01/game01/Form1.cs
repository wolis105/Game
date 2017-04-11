using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button1.Visible == false)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
            if (button2.Visible == false)
            {
                button2.Visible = true;
            }
            else
            {
                button2.Visible = false;
            }
            if (button3.Visible == false)
            {
                button3.Visible = true;
            }
            else
            {
                button3.Visible = false;
            }
            if (button4.Visible == false)
            {
                button4.Visible = true;
            }
            else
            {
                button4.Visible = false;
            }

        }
    }
}
