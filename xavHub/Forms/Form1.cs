using KeyAuthSeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xavHub.Controls;

namespace xavHub
{
    public partial class homeForm : Form
    {
        
        public static SellerApi sellerApi = new SellerApi();
        public string sellerKey = "";
        public string key;
        Color accentColor;
        

        public homeForm()
        {
            InitializeComponent();
            setApps();            
        }

        #region App Setup
        public void setApps()
        {
            addNew1.Text = xavHub.Properties.Settings.Default.Panel1[0];
            addNew1.BorderColor = xavHub.Properties.Settings.Default.Panel1Color;
            addNew2.Text = xavHub.Properties.Settings.Default.Panel2[0];
            addNew2.BorderColor = xavHub.Properties.Settings.Default.Panel2Color;
            addNew3.Text = xavHub.Properties.Settings.Default.Panel3[0];
            addNew3.BorderColor = xavHub.Properties.Settings.Default.Panel3Color;
            addNew4.Text = xavHub.Properties.Settings.Default.Panel4[0];
            addNew4.BorderColor = xavHub.Properties.Settings.Default.Panel4Color;  
            addNew5.Text = xavHub.Properties.Settings.Default.Panel5[0];
            addNew5.BorderColor = xavHub.Properties.Settings.Default.Panel5Color;
            addNew6.Text = xavHub.Properties.Settings.Default.Panel6[0];
            addNew6.BorderColor = xavHub.Properties.Settings.Default.Panel6Color;
        }


        public void setColor()
        {
            if (purpleColorBtn.Checked)
            {
                accentColor = Color.FromArgb(128, 128, 255);
            }

            if (blueColorBtn.Checked)
            {
                accentColor = Color.FromArgb(128, 255, 255);
            }

            if (greenColorBtn.Checked)
            {
                accentColor = Color.FromArgb(128, 255, 128);
            }

            if (yellowColorBtn.Checked)
            {
                accentColor = Color.FromArgb(255, 255, 128);
            }

            if (orangeColorBtn.Checked)
            {
                accentColor = Color.FromArgb(255, 192, 128);
            }

            if (redColorBtn.Checked)
            {
                accentColor = Color.FromArgb(255, 128, 128);
            }
        }
        #endregion

        #region Main Tabs Btns
        public void licensesPageBtn_Click(object sender, EventArgs e)
        {
            if (licensesPageBtn.Checked)
            {
                var loadingPage = new LoadingPanel();

                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(loadingPage);

                var hubTab = new LicensesTab();
                mainPanel.Controls.Add(hubTab);
                mainPanel.Controls.Remove(loadingPage);
            }
        }
        private void usersPageBtn_Click(object sender, EventArgs e)
        {
            if (usersPageBtn.Checked)
            {
                var loadingPage = new LoadingPanel();

                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(loadingPage);

                var usersTab = new UsersTab();
                mainPanel.Controls.Add(usersTab);
                mainPanel.Controls.Remove(loadingPage);

            }
        }       
        private void webhooksPageBtn_Click(object sender, EventArgs e)
        {
            if (webhooksPageBtn.Checked)
            {
                var loadingPage = new LoadingPanel();

                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(loadingPage);

                var webHooksTab = new SendWebhookView(key);
                mainPanel.Controls.Add(webHooksTab);
                mainPanel.Controls.Remove(loadingPage);

            }
        }
        private void filesPageBtn_Click(object sender, EventArgs e)
        {
            if (filesPageBtn.Checked)
            {
                var loadingPage = new LoadingPanel();

                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(loadingPage);

                var filesTab = new FilesTab();
                mainPanel.Controls.Add(filesTab);
                mainPanel.Controls.Remove(loadingPage);
            }
        }
        private void variablesPageBtn_Click(object sender, EventArgs e)
        {
            if (variablesPageBtn.Checked)
            {
                var variablesPage = new VariablesTab();

                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(variablesPage);

            }
        }
        private void settingsPageBtn_Click(object sender, EventArgs e)
        {
            if (settingsPageBtn.Checked)
            {
                mainPanel.Controls.Clear();
                var loadingPage = new LoadingPanel();
                mainPanel.Controls.Add(loadingPage);

                var settingsTab = new SettingsTab();
                mainPanel.Controls.Add(settingsTab);
                mainPanel.Controls.Remove(loadingPage);
            }
        }
        #endregion

        #region Add App Function
        private void guna2Button3_Click(object sender, EventArgs e)
        {

            setColor();
            
            sellerApi.SetSellerKey(sellerKeyTb.Text);
            if (homeForm.sellerApi.response.Success)
            {
                var Settings = Properties.Settings.Default;
                setApps();

                if (addNew1.Text == "N/A")
                {
                    xavHub.Properties.Settings.Default.Panel1[0] = panelNameTB.Text;
                    xavHub.Properties.Settings.Default.Panel1[1] = sellerKeyTb.Text;
                    xavHub.Properties.Settings.Default.Panel1Color = accentColor;

                    xavHub.Properties.Settings.Default.Save();
                    addNew1.Visible = true;
                    addNew1.BorderColor = accentColor;

                    setApps();
                }
                else
                {
                    if (addNew2.Text == "N/A")
                    {
                        xavHub.Properties.Settings.Default.Panel2[0] = panelNameTB.Text;
                        xavHub.Properties.Settings.Default.Panel2[1] = sellerKeyTb.Text;
                        xavHub.Properties.Settings.Default.Panel2Color = accentColor;
                        xavHub.Properties.Settings.Default.Save();

                        addNew2.Visible = true;
                        addNew2.BorderColor = accentColor;

                        setApps();
                    }
                    else
                    {
                        if (addNew3.Text == "N/A")
                        {
                            xavHub.Properties.Settings.Default.Panel3[0] = panelNameTB.Text;
                            xavHub.Properties.Settings.Default.Panel3[1] = sellerKeyTb.Text;
                            xavHub.Properties.Settings.Default.Panel3Color = accentColor;

                            xavHub.Properties.Settings.Default.Save();
                            addNew3.Visible = true;
                            addNew3.BorderColor = accentColor;

                            setApps();
                        }
                        else
                        {
                            if (addNew4.Text == "N/A")
                            {
                                xavHub.Properties.Settings.Default.Panel4[0] = panelNameTB.Text;
                                xavHub.Properties.Settings.Default.Panel4[1] = sellerKeyTb.Text;
                                xavHub.Properties.Settings.Default.Panel4Color = accentColor;

                                xavHub.Properties.Settings.Default.Save();
                                addNew4.Visible = true;
                                addNew4.BorderColor = accentColor;

                                setApps();
                            }
                            else
                            {
                                if (addNew5.Text == "N/A")
                                {
                                    xavHub.Properties.Settings.Default.Panel5[0] = panelNameTB.Text;
                                    xavHub.Properties.Settings.Default.Panel5[1] = sellerKeyTb.Text;
                                    xavHub.Properties.Settings.Default.Panel5Color = accentColor;

                                    xavHub.Properties.Settings.Default.Save();
                                    addNew5.Visible = true;
                                    addNew5.BorderColor = accentColor;

                                    setApps();
                                }
                                else
                                {
                                    if (addNew6.Text == "N/A")
                                    {
                                        xavHub.Properties.Settings.Default.Panel6[0] = panelNameTB.Text;
                                        xavHub.Properties.Settings.Default.Panel6[1] = sellerKeyTb.Text;
                                        xavHub.Properties.Settings.Default.Panel6Color = accentColor;

                                        xavHub.Properties.Settings.Default.Save();
                                        addNew6.Visible = true;
                                        addNew6.BorderColor = accentColor;

                                        setApps();
                                    }
                                }
                            }
                        }
                    }
                }
                sellerKeyTb.Text = "";
            }
            else
            {
                MessageBox.Show("ERROR! Seller key was not valid");
                sellerKeyTb.Text = "";
            }


        }
        #endregion

        #region Remove Apps Function
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(guna2Panel8);
        }
        #endregion

        #region App Selection Btns
        private void addNew1_Click(object sender, EventArgs e)
        {
            sellerApi.InitClient();
            sellerApi.SetSellerKey(xavHub.Properties.Settings.Default.Panel1[1].ToString());
            if (homeForm.sellerApi.response.Success)
            {
                selectAppPanel.Visible = false;
                CurrentAppLbl.Text = "Selected App: " + xavHub.Properties.Settings.Default.Panel1[0].ToString();
            }
        }

        private void addNew2_Click(object sender, EventArgs e)
        {
            sellerApi.InitClient();
            sellerApi.SetSellerKey(xavHub.Properties.Settings.Default.Panel2[1].ToString());
            if (homeForm.sellerApi.response.Success)
            {
                selectAppPanel.Visible = false;
                CurrentAppLbl.Text = "Selected App: " + xavHub.Properties.Settings.Default.Panel2[0].ToString();
            }
        }

        private void addNew3_Click(object sender, EventArgs e)
        {
            sellerApi.InitClient();
            sellerApi.SetSellerKey(xavHub.Properties.Settings.Default.Panel3[1].ToString());
            if (homeForm.sellerApi.response.Success)
            {
                selectAppPanel.Visible = false;
                CurrentAppLbl.Text = "Selected App: " + xavHub.Properties.Settings.Default.Panel3[0].ToString();

            }
        }

        private void addNew4_Click(object sender, EventArgs e)
        {
            sellerApi.InitClient();
            sellerApi.SetSellerKey(xavHub.Properties.Settings.Default.Panel4[1].ToString());
            if (homeForm.sellerApi.response.Success)
            {
                selectAppPanel.Visible = false;
                CurrentAppLbl.Text = "Selected App: " + xavHub.Properties.Settings.Default.Panel4[0].ToString();

            }
        }

        private void addNew5_Click(object sender, EventArgs e)
        {
            sellerApi.InitClient();
            sellerApi.SetSellerKey(xavHub.Properties.Settings.Default.Panel5[1].ToString());
            if (homeForm.sellerApi.response.Success)
            {
                selectAppPanel.Visible = false;
                CurrentAppLbl.Text = "Selected App: " + xavHub.Properties.Settings.Default.Panel5[0].ToString();

            }
        }

        private void addNew6_Click(object sender, EventArgs e)
        {
            sellerApi.InitClient();
            sellerApi.SetSellerKey(xavHub.Properties.Settings.Default.Panel6[1].ToString());
            if (homeForm.sellerApi.response.Success)
            {
                selectAppPanel.Visible = false;
                CurrentAppLbl.Text = "Selected App: " + xavHub.Properties.Settings.Default.Panel6[0].ToString();

            }
        }

        #endregion

        #region Close App Btn
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Remove All Apps Function
        private void clearAll_Click(object sender, EventArgs e)
        {
            // Reset all apps to defaults
            xavHub.Properties.Settings.Default.Panel1[0] = "N/A";
            xavHub.Properties.Settings.Default.Panel1[1] = "N/A";
            xavHub.Properties.Settings.Default.Panel1Color = Color.Black;

            xavHub.Properties.Settings.Default.Panel2[0] = "N/A";
            xavHub.Properties.Settings.Default.Panel2[1] = "N/A";
            xavHub.Properties.Settings.Default.Panel2Color = Color.Black;

            xavHub.Properties.Settings.Default.Panel3[0] = "N/A";
            xavHub.Properties.Settings.Default.Panel3[1] = "N/A";
            xavHub.Properties.Settings.Default.Panel3Color = Color.Black;

            xavHub.Properties.Settings.Default.Panel4[0] = "N/A";
            xavHub.Properties.Settings.Default.Panel4[1] = "N/A";
            xavHub.Properties.Settings.Default.Panel4Color = Color.Black;

            xavHub.Properties.Settings.Default.Panel5[0] = "N/A";
            xavHub.Properties.Settings.Default.Panel5[1] = "N/A";
            xavHub.Properties.Settings.Default.Panel5Color = Color.Black;

            xavHub.Properties.Settings.Default.Panel6[0] = "N/A";
            xavHub.Properties.Settings.Default.Panel6[1] = "N/A";
            xavHub.Properties.Settings.Default.Panel6Color = Color.Black;

            xavHub.Properties.Settings.Default.Save();

            addNew2.Visible = false;
            addNew3.Visible = false;
            addNew4.Visible = false;
            addNew5.Visible = false;
            addNew6.Visible = false;
            selectAppPanel.Visible = true;
            setApps();
        }


    }
    #endregion
}
