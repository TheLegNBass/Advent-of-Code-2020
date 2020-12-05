using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advent.Days
{
    public partial class Day5 : Form
    {
        public Day5()
        {
            InitializeComponent();
        }

        #region Controls

        private void btnValidate_Click(object sender, EventArgs e)
        {
            lblValid.Visible = true;
            lblValid.Text = GetHighest(txtPath.Text);
        }

        private void btnValidateNew_Click(object sender, EventArgs e)
        {
            lblValid.Visible = true;
            lblValid.Text = GetYours(txtPath.Text);
        }

        #endregion
        
        #region Sort Methods

        private string GetHighest(string path)
        {
            double highest = 0;
            List<double> ids = new List<double>();
            var line = string.Empty;
            List<string> passes = new List<string>();

            GetFile(path, passes);

            highest = SortAndOrder(passes, ids);
            return highest.ToString();
        }

        //Credit where it's due, I was struggling with this part, 
        //u/Carazxian on Reddit had a simple solution that I was able to tailor
        //to fit with what I'd made. 
        private string GetYours(string path)
        {
            double yours = 0;
            List<string> passes = new List<string>();
            List<double> ids = new List<double>();
            var found = new bool[128 * 8];

            GetFile(path, passes);
            //SortAndOrder(passes, ids);

            var max = 0;
            var min = found.Length;

            foreach (var pass in passes)
            {
                var id = 0;
                var s = found.Length / 2;
                for (var i = 0; i < 10; i++, s /= 2)
                {
                    if (pass[i] == 'B' || pass[i] == 'R')
                    {
                        id += s;
                    }
                }

                if (id > max) max = id;
                if (id < min) min = id;
                found[id] = true;
            }

            for (var i = min; i < max; i++)
            {
                if (found[i]) continue;
                yours = i;
            }

            return yours.ToString();
        }

        #endregion

        #region Helper Methods

        private static double SortAndOrder(List<string> passes, List<double> ids)
        {
            int max = 127;
            int min = 0;
            int L = 0;
            int R = 7;

            double highest;
            foreach (string pass in passes)
            {
                int row;
                int col;

                var chars = pass.ToCharArray();
                for (int i = 0; i < pass.Length; i++)
                {
                    if (chars[i] == 'F')
                    {
                        max -= (max - min) / 2;
                    }
                    else if (chars[i] == 'B')
                    {
                        min += (max - min) / 2;
                    }
                    else if (chars[i] == 'R')
                    {
                        L += (R - L) / 2;
                    }
                    else if (chars[i] == 'L')
                    {
                        R -= (R - L) / 2;
                    }
                }

                if (chars[6] == 'F')
                {
                    row = min;
                }
                else
                {
                    row = max;
                }

                if (chars[9] == 'L')
                {
                    col = L;
                }
                else
                {
                    col = R;
                }

                ids.Add(row * 8 + col);

                max = 127;
                min = 0;
                L = 0;
                R = 7;
            }

            ids.Sort();
            highest = ids[ids.Count - 1];
            return highest;
        }

        private void GetFile(string path, List<string> passes)
        {
            string line;
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                passes.Add(line);
            }
        }

        #endregion
    }
}
