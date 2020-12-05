using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Advent.Days
{
    public partial class Day4 : Form
    {
        public Day4()
        {
            InitializeComponent();
        }

        #region Controls

        private void btnValidate1_Click(object sender, EventArgs e)
        {
            lblValid.Visible = true;
            var passes = CreatePassportList(txtPath.Text);
            lblValid.Text = ValidatePasses(passes);
        }

        private void btnValidate2_Click(object sender, EventArgs e)
        {
            lblValid.Visible = true;
            var passes = CreatePassportList(txtPath.Text);
            lblValid.Text = ValidatePassesHarder(passes);
        }

        #endregion Controls

        #region Validation

        private string ValidatePasses(List<Passport> passes)
        {
            string valid = string.Empty;
            int count = 0;

            foreach (Passport pass in passes)
            {
                if (pass.BirthYear != null &&
                    pass.Expiration != null &&
                    pass.EyeColor != null &&
                    pass.HairColor != null &&
                    pass.Height != null &&
                    pass.IssueYear != null &&
                    pass.PassportID != null)
                {
                    count++;
                }
            }

            valid = count.ToString();
            return valid;
        }

        private string ValidatePassesHarder(List<Passport> passes)
        {
            string valid = string.Empty;
            int count = 0;

            foreach (Passport pass in passes)
            {
                if (pass.BirthYear != null &&
                    pass.Expiration != null &&
                    pass.EyeColor != null &&
                    pass.HairColor != null &&
                    pass.Height != null &&
                    pass.IssueYear != null &&
                    pass.PassportID != null)
                {
                    if (IsValid(pass))
                    {
                        count++;
                    }
                }
            }

            valid = count.ToString();
            return valid;
        }

        private bool IsValid(Passport pass)
        {
            bool valid = true;

            if (Convert.ToInt32(pass.BirthYear) > 2002 || Convert.ToInt32(pass.BirthYear) < 1920)
            {
                valid = false;
                return valid;
            }

            if (Convert.ToInt32(pass.IssueYear) > 2020 || Convert.ToInt32(pass.IssueYear) < 2010)
            {
                valid = false;
                return valid;
            }

            if (Convert.ToInt32(pass.Expiration) < 2020 || Convert.ToInt32(pass.Expiration) > 2030)
            {
                valid = false;
                return valid;
            }

            if (pass.Height.EndsWith("cm"))
            {
                var h = Convert.ToInt32(pass.Height.Split(Convert.ToChar("c"))[0]);
                if (h <= 150 && h >= 193)
                {
                    valid = false;
                    return valid;
                }
            }
            else if (pass.Height.EndsWith("in"))
            {
                var h = Convert.ToInt32(pass.Height.Split(Convert.ToChar("i"))[0]);
                if (h <= 59 || h >= 76)
                {
                    valid = false;
                    return valid;
                }
            }

            if (!Regex.Match(pass.HairColor, @"#[0-9a-f]{6}").Value.Equals(pass.HairColor))
            {
                valid = false;
                return false;
            }

            if (!Enum.TryParse<Color>(pass.EyeColor, out _))
            {
                valid = false;
                return false;
            }

            if (!Regex.IsMatch(pass.PassportID, @"\d{9}"))
            {
                valid = false;
                return valid;
            }

            return valid;
        }

        #endregion

        #region Helper Methods

        private List<Passport> CreatePassportList(string path)
        {
            List<string> strings = new List<string>();
            List<Passport> passports = new List<Passport>();
            char[] delimts = { '-', ' ' };

            var line = string.Empty;
            string str = string.Empty;

            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                if (line != string.Empty)
                {
                    if (str != string.Empty)
                    {
                        str += " " + line;
                    }
                    else
                    {
                        str += line;
                    }
                }
                else
                {
                    strings.Add(str);
                    str = string.Empty;
                }
            }
            strings.Add(str);

            foreach (string l in strings)
            {
                char[] d = { ':' };
                Passport pass = new Passport();
                string[] parts = l.Split(delimts);

                foreach (var t in parts)
                {
                    if (t.Contains("byr"))
                    {
                        string[] pieces = t.Split(d);
                        pass.BirthYear = pieces[1];
                    }

                    if (t.Contains("iyr"))
                    {
                        string[] pieces = t.Split(d);
                        pass.IssueYear = pieces[1];
                    }

                    if (t.Contains("eyr"))
                    {
                        string[] pieces = t.Split(d);
                        pass.Expiration = pieces[1];
                    }

                    if (t.Contains("hgt"))
                    {
                        string[] pieces = t.Split(d);
                        pass.Height = pieces[1];
                    }

                    if (t.Contains("hcl"))
                    {
                        string[] pieces = t.Split(d);
                        pass.HairColor = pieces[1];
                    }

                    if (t.Contains("ecl"))
                    {
                        string[] pieces = t.Split(d);
                        pass.EyeColor = pieces[1];
                    }

                    if (t.Contains("pid"))
                    {
                        string[] pieces = t.Split(d);
                        pass.PassportID = pieces[1];
                    }

                    if (t.Contains("cid"))
                    {
                        string[] pieces = t.Split(d);
                        pass.CountryID = pieces[1];
                    }
                }

                passports.Add(pass);
            }

            return passports;
        }


        #endregion

        #region enums

        internal enum Color
        {
            amb,
            blu,
            brn,
            gry,
            grn,
            hzl,
            oth
        }

        #endregion
    }

    #region Helper Class

    public partial class Passport
    {
        public string BirthYear { get; set; }
        public string IssueYear { get; set; }
        public string Expiration { get; set; }
        public string Height { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string PassportID { get; set; }
        public string CountryID { get; set; }

        public Passport()
        {
            BirthYear = null;
            IssueYear = null;
            Expiration = null;
            Height = null;
            HairColor = null;
            EyeColor = null;
            PassportID = null;
            CountryID = null;

        }
    }

    #endregion

}
