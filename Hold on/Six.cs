using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hold_on
{
    public partial class Six : Form
    {
        public Six(Form fm)
        {
            InitializeComponent();
            fm.Close();
            fm.Dispose();
        }
        private bool button = false;
        private string newfile;
        private const string Write = "依次点击生活是美好的，然后按下Ctrl+T键";
        private bool one = false;
        private bool tow = false;
        private bool three = false;
        private bool four = false;
        private bool five = false;
        private bool six = false;
        private bool key = false;
        private void Six_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }
        private void Six_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in filePath)
            {
                int i = file.LastIndexOf('\\');
                newfile = file.Substring(i + 1);
                if (newfile == "生活是美好的.tt")
                {
                    File.AppendAllText(file, Write);
                    button = true;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (button)
            {
                if (tow == false && three == false && four == false && five == false && six == false)
                    one = true;
                else
                {
                    tow = false;
                    three = false;
                    four = false;
                    five = false;
                    six = false;
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (button)
            {
                if (one == true && three == false && four == false && five == false && six == false)
                    tow = true;
                else
                {
                    one = false;
                    three = false;
                    four = false;
                    five = false;
                    six = false;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (button)
            {
                if (one == true && tow == true && four == false && five == false && six == false)
                    three = true;
                else
                {
                    one = false;
                    tow = false;
                    four = false;
                    five = false;
                    six = false;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (button)
            {
                if (one == true && tow == true && three == true && five == false && six == false)
                    four = true;
                else
                {
                    one = false;
                    tow = false;
                    three = false;
                    five = false;
                    six = false;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (button)
            {
                if (one == true && tow == true && three == true && four == true && six == false)
                    five = true;
                else
                {
                    one = false;
                    tow = false;
                    three = false;
                    four = false;
                    six = false;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (button)
            {
                if (one == true && tow == true && three == true && four == true && five == true)
                {
                    six = true;
                    key = true;
                }
                else
                {
                    one = false;
                    tow = false;
                    three = false;
                    four = false;
                    five = false;
                }
            }
        }

        private void Six_KeyDown(object sender, KeyEventArgs e)
        {
            if (key)
            {
                if (e.Control && e.KeyCode == Keys.T)
                {
                    MessageBox.Show("恭喜你全部通关", "通关", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    End end = new End(this);
                    end.ShowDialog();
                }
            }
        }
    }
}
