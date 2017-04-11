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
    }
}
