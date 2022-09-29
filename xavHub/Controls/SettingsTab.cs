using KeyAuthSeller;
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
    public partial class SettingsTab : UserControl
    {
        public SettingsTab()
        {
            InitializeComponent();
            homeForm.sellerApi.SettingsView();
            if (homeForm.sellerApi.response.Success)
            {
                AppEnabled.Checked = homeForm.sellerApi.settings.AppEnabled;
                HwidLockEnabled.Checked = homeForm.sellerApi.settings.HwidLockEnabled;
                VersionTb.Text = homeForm.sellerApi.settings.Version;
                WebhookTb.Text = homeForm.sellerApi.settings.Webhook;
                HwidMismatchTb.Text = homeForm.sellerApi.settings.Hwidmismatchmsg;
                NoSubsMsgTb.Text = homeForm.sellerApi.settings.Nosubmsg;
                AppDisabledMsgTb.Text = homeForm.sellerApi.settings.Disabledmsg;
                UsedKeyTb.Text = homeForm.sellerApi.settings.Keytakenmsg;
                ExpiredMsgTb.Text = homeForm.sellerApi.settings.Expiredmsg;
                UsernameTakenMsgTb.Text = homeForm.sellerApi.settings.Usernametakenmsg;
                InvalidKeyMsgTb.Text = homeForm.sellerApi.settings.Licenseinvalidmsg;
                ExpiredSubMsgTb.Text = homeForm.sellerApi.settings.Noactivesubmsg;
                BlacklistedMsgTb.Text = homeForm.sellerApi.settings.Blackedmsg;
                PasswordMismatchMsgTb.Text = homeForm.sellerApi.settings.Passinvalidmsg;
                SellixWebhookTb.Text = homeForm.sellerApi.settings.Sellixsecret;
                ResellerStoreTb.Text = homeForm.sellerApi.settings.Resellerstore;
                UsernameInvalidMsgTb.Text = homeForm.sellerApi.settings.Userinvalidmsg;
            }
        }


    }
}
