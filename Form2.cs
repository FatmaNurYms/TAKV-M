using System.Globalization;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using System.IO;


namespace PROJECT1
{
    public partial class Form2 : Form
    {
        int month, year;
        //private const string FileName = "toplantý_bilgileri.txt";

        public Form2()
        {
            InitializeComponent();
        }
        /*public void UpdateListBox(string title, string comment, string time)
        {
            using (StreamWriter writer = new StreamWriter(FileName, true))
            {
                writer.WriteLine($"Baþlýk: {title}, Açýklama: {comment}, Zaman: {time}");
            }
            UpdateListBox();
        }
        private void UpdateListBox()
        {
            listBox1.Items.Clear();

            if (File.Exists(FileName))
            {
                string[] lines = File.ReadAllLines(FileName);
                listBox1.Items.AddRange(lines);
            }
        }*/
        private void Form_Load(object sender, EventArgs e)
        {
            displaDays();
            açýklama();
        }

        private void açýklama()
        {
            string path = "C:\\Users\\fatma nur\\OneDrive\\Belgeler\\Dosya\\ListBox.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {

                }
            }
            string[] içerik= File.ReadAllLines(path);

            foreach(string içer in içerik)
            {

                listBox1.Items.Add( içer);
            }

        }
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            string monthName = dtfi.GetMonthName(month);

            labelDATE.Text = monthName + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBLANK ucblank = new UserControlBLANK();
                DayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDAYS ucdays = new UserControlDAYS();
                ucdays.days(i);
                DayContainer.Controls.Add(ucdays);
            }
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            month--;

            if (month == 0)
            {
                month = 12;
                year--;
            }

            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            string monthName = dtfi.GetMonthName(month);

            labelDATE.Text = monthName + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBLANK ucblank = new UserControlBLANK();
                DayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDAYS ucdays = new UserControlDAYS();
                ucdays.days(i);
                DayContainer.Controls.Add(ucdays);
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            month++;

            if (month == 13)
            {
                month = 1;
                year++;
            }

            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            string monthName = dtfi.GetMonthName(month);
            labelDATE.Text = monthName + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBLANK ucblank = new UserControlBLANK();
                DayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDAYS ucdays = new UserControlDAYS();
                ucdays.days(i);
                DayContainer.Controls.Add(ucdays);
            }
        }
    }
}