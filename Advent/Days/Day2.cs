using System;
using System.Windows.Forms;
using System.IO;

namespace Advent.Days
{
    public partial class Day2 : Form
    {
        public Day2()
        {
            InitializeComponent();
        }

        #region Buttons

        private void btnValidate_Click(object sender, EventArgs e)
        {
            lblValid.Visible = true;
            lblValid.Text = GetPasswords(txtPath.Text, false).ToString();            
        }

        private void btnValidateNew_Click(object sender, EventArgs e)
        {
            lblValid.Visible = true;
            lblValid.Text = GetPasswords(txtPath.Text, true).ToString();
        }

        #endregion Buttons

        #region Helper Methods

        private int GetPasswords(string path, bool newWay)
        {
            int valid = 0;
            var line = string.Empty;
            char[] delimits = { '-', ' ', ':' };
            PasswordObject pass = new PasswordObject();

            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(delimits, StringSplitOptions.RemoveEmptyEntries);
                pass.min = Convert.ToInt32(words[0]);
                pass.max = Convert.ToInt32(words[1]);
                pass.req = words[2];
                pass.pass = words[3];

                if (!newWay)
                {
                    if (ValidatePassword(pass))
                    {
                        valid++;
                    }
                }
                else
                {
                    if (ValidatePasswordNewWay(pass))
                    {
                        valid++;
                    }
                }

            }

            return valid;
        }

        private bool ValidatePasswordNewWay(PasswordObject pass)
        {
            var valid = false;
            bool tooLong = true;
            bool tooShort = true;
            int newMin = pass.min - 1;
            int newMax = pass.max - 1;

            if (pass.pass.Length >= newMin)
            {
                tooShort = false;
            }

            if (pass.pass.Length >= newMax)
            {
                tooLong = false;
            }

            if (!tooShort && !tooLong)
            {
                if (pass.pass[newMin].ToString() == pass.req || pass.pass[newMax].ToString() == pass.req)
                {
                    if (pass.pass[newMin].ToString() == pass.pass[newMax].ToString())
                    {
                        return valid;
                    }
                    else
                    {
                        valid = true;
                    }
                }
            }

            return valid;
        }

        private bool ValidatePassword(PasswordObject pass)
        {
            var count = 0;
            var valid = false;

            foreach (char x in pass.pass)
            {
                if (x == Convert.ToChar(pass.req))
                {
                    count++;
                }
            }

            if (count >= pass.min && count <= pass.max)
            {
                valid = true;
            }

            return valid;
        }

        #endregion Helper Methods

        #region Helper Class

        partial class PasswordObject
        {
            public int min;
            public int max;
            public string req;
            public string pass;

            public PasswordObject()
            {
                min = 0;
                max = 0;
                req = string.Empty;
                pass = string.Empty;
            }
        }

        #endregion Helper Class

    }


}
