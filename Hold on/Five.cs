using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hold_on
{
    public partial class Five : Form
    {
        public Five(Form fm)
        {
            InitializeComponent();
            fm.Close();
            fm.Dispose();
        }
        private bool one = false;
        private bool tow = false;
        private bool three = false;
        private void label2_Click(object sender, EventArgs e)
        {
            if (tow == false && three == false)
                one = true;
            else
            {
                one = false;
                tow = false;
                three = false;
            }
               
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (one == true && three == false)
                tow = true;
            else
            {
                one = false;
                tow = false;
                three = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (one == true && tow == true)
                button1.Enabled = true;
            else
            {
                one = false;
                tow = false;
                three = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("恭喜你通过", "通过", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Six six = new Six(this);
            six.ShowDialog();
        }
    }
}
