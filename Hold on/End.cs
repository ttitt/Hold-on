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
    public partial class End : Form
    {
        public End(Form fm)
        {
            InitializeComponent();
            fm.Close();
            fm.Dispose();
            //Console.Read("hello world");
        }
    }
}
