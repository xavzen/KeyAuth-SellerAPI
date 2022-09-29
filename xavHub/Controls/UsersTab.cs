using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xavHub.Controls
{
    public partial class UsersTab : UserControl
    {
        string currentCell;
        public UsersTab()
        {
            InitializeComponent();
      
            homeForm.sellerApi.UserViewAll();
            if (homeForm.sellerApi.response.Success)
            {
                foreach (var blacks in homeForm.sellerApi.users.Users)
                {
                    if (blacks.Banned == null)
                        blacks.Banned = "No";
                    else
                        blacks.Banned = "Yes reason: " + blacks.Banned;
                    if (blacks.Ip == null)
                        blacks.Ip = "N/A";
                    if (blacks.Hwid == null)
                        blacks.Hwid = "N/A";
                    if (blacks.Lastlogin == null)
                        blacks.Lastlogin = "N/A";
                    else
                        blacks.Lastlogin = UnixTimeToDateTime(long.Parse(blacks.Lastlogin));
                    xavDataGrid.Rows.Insert(0, blacks.Username, blacks.Banned, UnixTimeToDateTime(long.Parse(blacks.Createdate)), blacks.Lastlogin);
                }//
                xavDataGrid.Columns[0].Width = 223;
                xavDataGrid.Columns[1].Width = 372;
                xavDataGrid.Columns[2].Width = 75;
                xavDataGrid.Columns[3].Width = 75;
            }
            else if (homeForm.sellerApi.response.Message.Contains("No application with specified seller key found"))
            {
                //bunifuSnackbar1.Show(homeForm.MainForm, "Redirecting to App info.", BunifuSnackbar.MessageTypes.Information, 10000, "", BunifuSnackbar.Positions.MiddleCenter);
                //bunifuSnackbar1.Show(homeForm.MainForm, "Your seller key may have been changed please update it.", BunifuSnackbar.MessageTypes.Error, 10000, "", BunifuSnackbar.Positions.MiddleCenter);
                //AppStatsView appStatsView = new AppStatsView();
                //SelectedAppView.AppViews.Controls.Add(appStatsView);
                //SelectedAppView.AppViews.Controls.Remove(this);

            }
            //else
                //bunifuSnackbar1.Show(homeForm.MainForm, homeForm.sellerApi.response.Message, BunifuSnackbar.MessageTypes.Information, 10000, "", BunifuSnackbar.Positions.MiddleCenter);
                ;
        }
        public static string UnixTimeToDateTime(long unixtime)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            string shorttime = dtDateTime.ToShortDateString();
            return shorttime;
        }
       
        public static string Username = string.Empty;

        private void UsersTab_Load(object sender, EventArgs e)
        {

            homeForm.sellerApi.SubViewAll();
            if (homeForm.sellerApi.response.Success)
            {
                foreach (var subs in homeForm.sellerApi.subs.All)
                    SubDd.Items.Add(subs.Name);
                SubDd.Text = "User sub";
            }
            else
                SubDd.Text = "No subs found";
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            int expiry = 0;
            if (DaysDd.SelectedItem.ToString() == "Day")
                expiry = 0;
            if (DaysDd.SelectedItem.ToString() == "Week")
                expiry = 1;
            if (DaysDd.SelectedItem.ToString() == "Month")
                expiry = 2;
            if (DaysDd.SelectedItem.ToString() == "Year")
                expiry = 3;
            if (DaysDd.SelectedItem.ToString() == "Lifetime")
                expiry = 4;
            string Sub = SubDd.SelectedItem.ToString();
            Console.WriteLine(Sub);
            homeForm.sellerApi.UserCreate(usernameTb.Text, Sub, expiry, passwordTb.Text);
            if (homeForm.sellerApi.response.Success)
               status.Text = "User successfully created";
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (xavDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                currentCell = xavDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }
        private void banUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeForm.sellerApi.UserBan(currentCell, "Banned using the sellerkey api");
        }
    }
}
