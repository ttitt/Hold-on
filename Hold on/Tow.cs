using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hold_on
{
    public partial class Tow : Form
    {
        public Tow(Form fm)
        {
            InitializeComponent();
            fm.Dispose();
        }

        private void Tow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private Point mouse_offset;

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                ((Control)sender).Location = ((Control)sender).Parent.PointToClient(mousePos);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("恭喜你进入第三关", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Three three = new Three(this);
            three.ShowDialog();
        }
    }
}
