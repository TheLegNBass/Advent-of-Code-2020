using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Advent.Days
{
    public partial class Day3 : Form
    {
        public Day3()
        {
            InitializeComponent();
        }

        private void btnValidate1_Click(object sender, EventArgs e)
        {
            lblValid.Visible = true;
            lblValid.Text = GetNumberOfTrees(txtPath.Text).ToString();
        }

        private void btnValidate2_Click(object sender, EventArgs e)
        {
            lblValid.Visible = true;
            lblValid.Text = GetMultipleNumberOfTrees(txtPath.Text).ToString();
        }

        #region Counting Trees

        private int GetNumberOfTrees(string path)
        {
            int xVal = 0;
            int trees = 0;
            var line = string.Empty;
            List<string> hills = new List<string>();

            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                hills.Add(line);
            }

            foreach (string s in hills)
            {
                string str = s;

                while (str.Length < xVal + 1)
                {
                    str += s;
                }

                var pos = str[xVal];

                if (pos.Equals('#'))
                {
                    trees++;
                }

                xVal += 3;
            }

            return trees;
        }

        private double GetMultipleNumberOfTrees(string path)
        {
            long trees = 0;
            long slope1 = 0;
            long slope2 = 0;
            long slope3 = 0;
            long slope4 = 0;
            long slope5 = 0;
            int x1 = 0;
            int x2 = 0;
            int x3 = 0;
            int x4 = 0;
            int x5 = 0;
            int y5 = 0;

            var line = string.Empty;
            List<string> hills = new List<string>();

            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                hills.Add(line);
            }

            foreach (string s in hills)
            {
                string str = s;

                while (str.Length < x1 + 1)
                {
                    str += s;
                }

                var pos = str[x1];

                if (pos.Equals('#'))
                {
                    slope1++;
                }

                x1 += 1;
            }

            foreach (string s in hills)
            {
                string str = s;

                while (str.Length < x2 + 1)
                {
                    str += s;
                }

                var pos = str[x2];

                if (pos.Equals('#'))
                {
                    slope2++;
                }

                x2 += 3;
            }

            foreach (string s in hills)
            {
                string str = s;

                while (str.Length < x3 + 1)
                {
                    str += s;
                }

                var pos = str[x3];

                if (pos.Equals('#'))
                {
                    slope3++;
                }

                x3 += 5;
            }

            foreach (string s in hills)
            {
                string str = s;

                while (str.Length < x4 + 1)
                {
                    str += s;
                }

                var pos = str[x4];

                if (pos.Equals('#'))
                {
                    slope4++;
                }

                x4 += 7;
            }

            foreach (string s in hills)
            {
                string str = s;

                while (str.Length < x5 + 1)
                {
                    str += s;
                }

                if (y5 % 2 == 0)
                {
                    var pos = str[x5];

                    if (pos.Equals('#'))
                    {
                        slope5++;
                    }

                    x5++;
                    y5++;
                }
                else
                {
                    y5++;
                }
            }

            trees = slope1 * slope2 * slope3 * slope4 * slope5;

            return trees;
        }

        #endregion Counting Trees

    }
}
