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

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.button1.Visible==true)
            {
                this.button1.Visible = false;
            }
            else
            {
                this.button1.Visible = true;
            }
            if (this.button3.Visible == true)
            {
                this.button3.Visible = false;
            }
            else
            {
                this.button3.Visible = true;
            }
            if (this.button5.Visible == true)
            {
                this.button5.Visible = false;
            }
            else
            {
                this.button5.Visible = true;
            }
        }

        private int i = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            i++;
            bool flag = button2.Visible;
            bool flag1 = button4.Visible;
            bool flag2 = button6.Visible;
            if (i % 2 == 1)
            {
                button2.Visible = !flag;
                button4.Visible = !flag1;
                button6.Visible = !flag2;
            }
            else
            {
                button2.Visible = !flag;
                button4.Visible = !flag1;
                button6.Visible = !flag2;
            }
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
