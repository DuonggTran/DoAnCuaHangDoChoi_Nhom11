﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuaHangDoChoi
{
    public partial class ucDay : UserControl
    {
        string _day, date, weekday;
        public ucDay(string day)
        {
            InitializeComponent();
            _day = day;
            lblDay.Text = day;
            checkBox1.Hide();
            date = frmLich._month + "/" + _day + "/" + frmLich._year;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                int day_tmp = int.Parse(lblDay.Text);              
                int month_tmp = DateTime.Now.Month;
                int year_tmp = DateTime.Now.Year;               
                DateTime selectedDate = new DateTime(year_tmp, month_tmp, day_tmp);
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 150, 79);
                if(Program.role == "admin")
                {
                    frmChiaCa chiaCa = new frmChiaCa();
                    chiaCa.Show();
                } 
                else
                {
                    frmXemCa xemCa = new frmXemCa();
                    xemCa.Show();
                }
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White;
            }
        }

        private void sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(date);
                string weekday = day.ToString("ddd");
                if (weekday == "Sun")
                {
                    lblDay.ForeColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    lblDay.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }
            catch (Exception) { }
        }

        private void ucDay_Load(object sender, EventArgs e)
        {
            sundays();
        }
        
    }
}
