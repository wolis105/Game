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

        private void button4_Click(object sender, EventArgs e)
        {
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
            if (button6.Visible == false)
            {
                button6.Visible = true;
            }
            else
            {
                button6.Visible = false;
            }
        }
    }
}
