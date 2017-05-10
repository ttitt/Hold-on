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
    public partial class Three : Form
    {
        public Three(Form fm)
        {
            InitializeComponent();
            fm.Close();
            fm.Dispose();            
        }

        private void 进入第四关ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("进入第四关");
            Four four = new Four(this);
            four.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.ContextMenuStrip = contextMenuStrip1;
        }
    }
}
