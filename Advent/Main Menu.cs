﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advent.Days;

namespace Advent
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            lblInstructions.Text = "Click on any of the numbers \r\nto see that day's solution!"; 
        }

        #region Day Buttons

        private void btnDay1_Click(object sender, EventArgs e)
        {
            Day1 frm = new Day1();
            frm.Show();
        }

        private void btnDay2_Click(object sender, EventArgs e)
        {
            Days.Day2 frm = new Days.Day2();
            frm.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Days.Day3 frm = new Days.Day3();
            frm.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Days.Day4 frm = new Days.Day4();
            frm.Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Days.Day5 frm = new Day5();
            frm.Show();
        }

        #endregion Day Buttons

        #region Controls

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/TheLegNBass");
        }

        #endregion Controls
    }
}
