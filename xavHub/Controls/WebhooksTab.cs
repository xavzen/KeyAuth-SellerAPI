using JNogueira.Discord.Webhook.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xavHub.Controls;

namespace xavHub.Controls
{
    public partial class SendWebhookView : UserControl
    {
        string key;

        public SendWebhookView(string key)
        {
            InitializeComponent();
            this.key = key;
            radioMessage.Checked = true;
        }


        public async void DiscordMessage()
        {
            var client = new DiscordWebhookClient(WebhookTb.Text);
            var message = new DiscordMessage(messageTb.Text,
                username: BotNameTb.Text,
                avatarUrl: PicUrlTb.Text);
            await client.SendToDiscord(message);
            //DialogResult = DialogResult.OK;
        }

        public async void DiscordEmbed()
        {
            var client = new DiscordWebhookClient(WebhookTb.Text);
            var message = new DiscordMessage(
                        "",
                        username: BotNameTb.Text,
                        avatarUrl: PicUrlTb.Text,
                        tts: false,
        embeds: new[]
        {
            new DiscordMessageEmbed(
                "",
                color: 0,
                author: new DiscordMessageEmbedAuthor(embedAuthor.Text),
                url: "https://google.com",
                //description: embedTitle.Text,
                fields: new[]
                    {
                        new DiscordMessageEmbedField(embedMsgTitle.Text, embedMessage.Text)
                        //new DiscordMessageEmbedField(embedTitle.Text, embedTitle.Text)
                    },
                thumbnail: new DiscordMessageEmbedThumbnail(PicUrlTb.Text),
                image: new DiscordMessageEmbedImage(PicUrlTb.Text),
                footer: new DiscordMessageEmbedFooter(embedFooter.Text, PicUrlTb.Text)
            )
                }
            );

            // Send the message!
            await client.SendToDiscord(message);
            //DialogResult = DialogResult.OK;
        }


        private void SendWebhookView_Load(object sender, EventArgs e)
        {
            PicUrlTb.Text = "https://www.gitbook.com/cdn-cgi/image/width=40,height=40,fit=contain,dpr=1,format=auto/https%3A%2F%2F4104118852-files.gitbook.io%2F~%2Ffiles%2Fv0%2Fb%2Fgitbook-legacy-files%2Fo%2Fspaces%252F-MN3xz4dcbly791TZk7q%252Favatar-1606415153929.png%3Fgeneration%3D1606415154289472%26alt%3Dmedia";
            BotNameTb.Text = "KeyAuth Seller Panel";
        }

        //private void PicUrlTb_TextChanged(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(PicUrlTb.Text) || !PicUrlTb.Text.Contains("https://"))
        //    {
        //        //bunifuSnackbar1.Show(HomeView.MainForm, "You must set a vaild URL for your banner", BunifuSnackbar.MessageTypes.Error, 5000, "", BunifuSnackbar.Positions.MiddleCenter);
        //        ///return;
        //    }
        //    else
        //    {
        //        bunifuPictureBox1.LoadAsync(PicUrlTb.Text);
        //    }
        //}

        private void SendBtn_Click(object sender, EventArgs e)
        {
            DiscordMessage();
        }

        private void WebhookTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (radioMessage.Checked)
            {
                DiscordMessage();
            }

            if (radioEmbed.Checked)
            {
                DiscordEmbed();
            }
        }

        private void radioEmbed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEmbed.Checked)
            {
                embedTitle.Enabled = true;
                embedAuthor.Enabled = true;
                embedFooter.Enabled = true;
                embedMsgTitle.Enabled = true;
                embedMessage.Enabled = true;
            }
            else
            {
                embedTitle.Enabled = false;
                embedAuthor.Enabled = false;
                embedFooter.Enabled = false;
                embedMsgTitle.Enabled = false;
                embedMessage.Enabled = false;
            }
        }
    }
}
