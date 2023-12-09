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
    public partial class UserControlDAYS : UserControl
    {
        public UserControlDAYS()
        {
            InitializeComponent();
        }
        private void UserControlDAYS_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Close();
            this.Hide();

            Event form = new Event();
            form.Show();
        }
        public void days(int numday)
        {
            labeldays.Text = numday + "";
        }
    }
}
