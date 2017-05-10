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
    public partial class Four : Form
    {
        public Four(Form fm)
        {
            InitializeComponent();
            fm.Close();
            fm.Dispose();
        }

        private void Four_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                MessageBox.Show("恭喜你通过","过关",MessageBoxButtons.OK,MessageBoxIcon.Asterisk); 
                Five five = new Five(this);
                five.ShowDialog();
            }
        }
    }
}