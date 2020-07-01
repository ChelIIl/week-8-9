using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_8_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            depos.Text = "";
            cur.Text = "рубли";
            time.Text = "1 год";
            date.Value = DateTime.Today;
            percent.Text = "";
            capit.Text = "";
            result.Text = "";
            label5.Hide();
            capit.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            depos.Text = "";
            cur.Text = "рубли";
            time.Text = "1 год";
            date.Value = DateTime.Today;
            percent.Text = "";
            capit.Text = "";
            result.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(depos.Text);
            double proc = Convert.ToDouble(percent.Text);
            DateTime date1 = date.Value;
            DateTime date2 = date.Value;
            int days;
            double res = 0;

            if (time.Text == "1 год")
                date2 = date2.AddYears(1);

            else if (time.Text == "2 года")
                date2 = date2.AddYears(2);

            else
                date2 = date2.AddYears(3);

            TimeSpan resday = date2 - date1;
            days = Convert.ToInt32(resday.Days);

            if (capitaliz.Checked == true)
            {
                if (capit.Text == "раз в месяц")
                {
                    for (; date1 != date2;)
                    {
                        res += ((sum + res) * proc * month_days(date1) / 365) / 100;
                        date1 = date1.AddMonths(1);
                    }
                    res += sum;
                }

                else if (capit.Text == "раз в квартал")
                {                    
                    for (;date1 != date2;)
                    {
                        days = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            days += month_days(date1);
                            date1 = date1.AddMonths(1);
                        }
                        res += ((sum + res) * proc * days / 365) / 100;
                    }
                    res += sum;
                }

                else if (capit.Text == "раз в полгода")
                {
                    for (;date1 != date2;)
                    {
                        days = 0;
                        for (int i = 0; i < 6; i++)
                        {
                            days += month_days(date1);
                            date1 = date1.AddMonths(1);
                        }
                        res += ((sum + res) * proc * days / 365) / 100;
                    }
                    res += sum;
                }

                else if (capit.Text == "раз в год")
                {
                    for (; date1 != date2;)
                    {
                        days = 0;
                        for (int i = 0; i < 12; i++)
                        {
                            days += month_days(date1);
                            date1 = date1.AddMonths(1);
                        }
                        res += ((sum + res) * proc * days / 365) / 100;
                    }
                    res += sum;
                }

                else
                    res = sum + ((sum * proc) / 100);
            }

            else
            {
                res = (sum * proc * days / 365) / 100;
                res += sum;
            }

            result.Text = res.ToString();
        }

        private void capitaliz_CheckedChanged(object sender, EventArgs e)
        {
            label5.Show();
            capit.Show();
        }

        private void indus_CheckedChanged(object sender, EventArgs e)
        {
            label5.Hide();
            capit.Hide();
        }

        private int month_days (DateTime date)
        {
            int day;
            int m = date.Month;

            day = 28 + (m + m / 8) % 2 + 2 % m + 2 * 1 / m;

            return day;
        }
    }
}
