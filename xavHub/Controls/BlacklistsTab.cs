using Bunifu.UI.WinForms;
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

namespace xavHub.Controls
{
    public partial class BlacklistsTab : UserControl
    {
        List<Blacks> Black = new List<Blacks>();
        string Type = string.Empty;
        string Data = string.Empty;
        public class Blacks
        {
            public string Type { get; set; }
            public string Data { get; set; }
        }
        public BlacklistsTab()
        {
            InitializeComponent();
        }

        private void BlacklistsTab_Load(object sender, EventArgs e)
        {
            homeForm.sellerApi.BlackViewAll();
            if (homeForm.sellerApi.response.Success)
            {
                foreach (var blacks in homeForm.sellerApi.blacks.All)
                    Black.Add(new Blacks { Type = blacks.Type, Data = blacks.Ip + blacks.Hwid });
                vardatagrid.DataSource = Black;
                vardatagrid.Columns[0].Width = 172;
                vardatagrid.Columns[1].Width = 573;
            }
            else if (homeForm.sellerApi.response.Message.Contains("No application with specified seller key found"))
            {
                //bunifuSnackbar1.Show(HomeView.MainForm, "Redirecting to App info.", BunifuSnackbar.MessageTypes.Information, 10000, "", BunifuSnackbar.Positions.MiddleCenter);
                //bunifuSnackbar1.Show(HomeView.MainForm, "Your seller key may have been changed please update it.", BunifuSnackbar.MessageTypes.Error, 10000, "", BunifuSnackbar.Positions.MiddleCenter);


            }
        }
    }
}
