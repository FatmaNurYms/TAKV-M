using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PROJECT1
{
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string comment = richTextBoxComment.Text;
            string time = comboBox1.SelectedItem.ToString(); 
            string time1 = comboBox2.SelectedItem != null ? comboBox2.SelectedItem.ToString() : "";

            string path = "C:\\Users\\fatma nur\\OneDrive\\Belgeler\\Dosya\\ListBox.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(title);
                    sw.WriteLine(comment);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.WriteLine(title);
                    sw.WriteLine(comment);
                }
            }

            MessageBox.Show($"Toplantı Bilgileri:\nBaşlık: {title}\nAçıklama: {comment}\nZaman: {time}.{time1}\nToplantı Bilgileri");
            Form2 f1 = new Form2();
            f1.Show();
            
            this.Hide();
        }
    }
}
