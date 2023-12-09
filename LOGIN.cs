using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT1
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;

            Form2 f1 = new Form2();
            f1.Show();
            this.Hide();
        }
        private void buttonJoin_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;

            Form3 f2 = new Form3();
            f2.Show();
            this.Hide();
        }
    }
}
