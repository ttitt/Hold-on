using System;
using System.Windows.Forms;

namespace Hold_on
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            One one = new One(this);
            one.ShowDialog();
        }
    }
}
