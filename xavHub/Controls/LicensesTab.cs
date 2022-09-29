using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KeyAuthSeller.SellerApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace xavHub
{
    public partial class LicensesTab : UserControl
    {
        public String Status;
        public LicensesTab()
        {
            InitializeComponent();
            homeForm.sellerApi.LicenseViewAll();
            if (homeForm.sellerApi.response.Success)
            {

                homeForm.sellerApi.SubViewAll();
                foreach (var Keys in homeForm.sellerApi.license.Keys)
                {
                   
                    if (Keys.Status == "Banned")
                        Status = "Banned";
                    else if (Keys.Status == "Used") 
                        Status = "Used";
                    else if (Keys.Status == "Not Used") 
                    Status = "Not Used";
                    else
                        Status = null;
                    listBox1.Items.Add(Keys.Key.ToString());

                }
                //bunifuVScrollBar1.BindTo(bunifuDataGridView1, true);
                //LoadPanel.Visible = true;
            }
            else if (homeForm.sellerApi.response.Message.Contains("No application with specified seller key found"))
            {
            }


        }
        private static string DateLicense(string str)
        {
            //string time;
            var s = (long)Double.Parse(str);
            var t = DateTime.Now.AddSeconds(s);
            var d = t.ToShortDateString();
            return d;
        }
        private static string TimeLicense(string str)
        {
            string time;
            var s = (long)Double.Parse(str);
            var t = TimeSpan.FromSeconds(s);

            if (t.Minutes == 0 && t.Hours == 0 && t.Days == 0)
                if (t.Seconds >= 2)
                    time = Convert.ToString($"{t.Seconds} Seconds");
                else
                    time = Convert.ToString($"{t.Seconds} Second");
            else if (t.Seconds == 0 && t.Hours == 0 && t.Days == 0)
                if (t.Minutes >= 2)
                    time = Convert.ToString($"{t.Minutes} Minutes");
                else
                    time = Convert.ToString($"{t.Minutes} Minute");

            else if (t.Seconds == 0 && t.Minutes == 0 && t.Days == 0)
                if (t.Hours >= 2)
                    time = Convert.ToString($"{t.Hours} Hours");
                else
                    time = Convert.ToString($"{t.Hours} Hour");
            else if (t.Seconds == 0 && t.Minutes == 0 && t.Hours == 0)
                if (t.Days >= 2)
                    time = Convert.ToString($"{t.Days} Days");
                else
                    time = Convert.ToString($"{t.Days} Day");
            else
                time = Convert.ToString($"{t.Days} Days");
            return time;

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count >= 1)
            {
                key = listBox1.SelectedItem.ToString();
                LoadInfo();
            }
        }

        string key;
        public void LoadInfo()
        {
            string subName = string.Empty;
            //BanPanel.Visible = false;
            //ReasonTb.Text = "";
            foreach (var keys in homeForm.sellerApi.license.Keys)
                if (key == keys.Key)
                {
                    KeyLb.Text = keys.Key;
                    StatusLb.Text = keys.Status;
                    foreach (var sub in homeForm.sellerApi.subs.All)
                        if (keys.Level == sub.Level)
                            subName = sub.Name;
                    SubNameLb.Text = subName;
                    SubLvlLb.Text = keys.Level;
                    if (keys.Status == "Banned")
                    {
                        //Status = Properties.Resources.Red;
                        //BanPanel.Visible = true;
                        //ReasonTb.Text = keys.Banned.ToString();
                    }
                    else if (keys.Status == "Used")
                    {
                        //Status = Properties.Resources.Blue;
                    }
                    else if (keys.Status == "Not Used")
                    {

                    }
                        //Status = Properties.Resources.Green;
                    else
                                Status = null;
                    //StatusPic.Image = Status;

                    if (keys.Note == null)
                        keys.Note = "N/A";
                    NoteLb.Text = keys.Note.ToString();

                    if (keys.Usedby == null)
                        keys.Usedby = "N/A";
                    UsedByTb.Text = keys.Usedby.ToString();
                    if (keys.Usedon == null)
                        UsedOnLb.Text = "N/A";
                    else
                    {
                        UsedOnLb.Text = UnixTimeToDateTime(long.Parse(keys.Usedon));
                    }
                    GenBy.Text = keys.Genby.ToString();
                    CreationDateLb.Text = UnixTimeToDateTime(long.Parse(keys.Gendate));
                    DurationTimeLb.Text = TimeLicense(keys.Expires);
                    DurationDateLb.Text = DateLicense(keys.Expires);
                }
        }
        public static string UnixTimeToDateTime(long unixtime)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            string shorttime = dtDateTime.ToShortDateString();
            return shorttime;
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void banLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeForm.sellerApi.LicenseBan(listBox1.SelectedItem.ToString(), "");
        }

        private void removeLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeForm.sellerApi.LicenseDelete(listBox1.SelectedItem.ToString());
        }

        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeForm.sellerApi.LicenseAddTime(0);
        }

        private void listBox1_Validated(object sender, EventArgs e)
        {

        }

        private void LicensesTab_Validated(object sender, EventArgs e)
        {   
                
        }
    }
}