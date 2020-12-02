using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Advent
{
    public partial class Day1 : Form
    {
        public Day1()
        {
            InitializeComponent();
        }

        private void btnCalculate2_Click(object sender, EventArgs e)
        {
            var pos = GetFile(txtPath.Text);
            var answers = DoMathFor2(txtTarget.Text, pos);

            lblValues.Text = answers[0].ToString() + ", " + answers[1].ToString();
            lblMultiplied.Text = (answers[0] * answers[1]).ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var pos = GetFile(txtPath.Text);
            var answers = DoMathFor3(txtTarget.Text, pos);

            lblValues.Text = answers[0].ToString() + ", " + answers[1].ToString() + ", " + answers[2].ToString();
            lblMultiplied.Text = (answers[0] * answers[1] * answers[2]).ToString();
        }

        private List<int> GetFile(string path)
        {
            List<int> possible = new List<int>();
            var possVal = string.Empty;

            System.IO.StreamReader file = new System.IO.StreamReader(path);

            while((possVal = file.ReadLine()) != null)
            {
                possible.Add(Convert.ToInt32(possVal));
            }

            file.Close();

            return possible;
        }

        private List<int> DoMathFor2(string target, List<int> possibles)
        {
            List<int> values = new List<int>();

            foreach (int num in possibles)
            {
                foreach (int num2 in possibles)
                {
                   if ((num + num2) == Convert.ToInt32(target))
                   {
                        if (!values.Contains(num))
                        {
                            values.Add(num);
                        }
                        if (!values.Contains(num2))
                        {
                            values.Add(num2);
                        }
                   }                   
                }
            }

            return values;
        }
        
        private List<int> DoMathFor3(string target, List<int> possibles)
        {
            List<int> values = new List<int>();

            foreach (int num in possibles)
            {
                foreach(int num2 in possibles)
                {
                    foreach (int num3 in possibles)
                    {
                        if ((num + num2 + num3) == Convert.ToInt32(target))
                        {
                            if (!values.Contains(num))
                            {
                                values.Add(num);
                            }
                            if (!values.Contains(num2))
                            {
                                values.Add(num2);
                            }
                            if (!values.Contains(num3))
                            {
                                values.Add(num3);
                            }
                        }
                    }
                }
            }
            
            return values;
        }
    }
}
