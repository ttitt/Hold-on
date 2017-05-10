using System.Windows.Forms;

namespace Hold_on
{
    public partial class One : Form
    {
        public One(Form fm)
        {
            InitializeComponent();
            fm.Visible = false;
        }

        private void One_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("恭喜你找到了第二关", "第二关", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Tow tow = new Tow(this);
            tow.ShowDialog();
        }
    }
}
