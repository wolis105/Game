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

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Hide();
            if(this.button2.Visible==true)
            {
                this.button2.Hide();
            }
            else
            {
                this.button2.Show();
            }
            if (this.button5.Visible == true)
            {
                this.button5.Hide();
            }
            else
            {
                this.button5.Show();
            }
            if (this.button6.Visible == true)
            {
                this.button6.Hide();
            }
            else
            {
                this.button6.Show();
            }
        }
    }
}
