namespace xavHub.Controls
{
    partial class UsersTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersTab));
            this.xavDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.xUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelLbl = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.SubDd = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DaysDd = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.createUserBtn = new Guna.UI2.WinForms.Guna2Button();
            this.messageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.status = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.banUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.xavDataGrid)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xavDataGrid
            // 
            this.xavDataGrid.AllowUserToAddRows = false;
            this.xavDataGrid.AllowUserToDeleteRows = false;
            this.xavDataGrid.AllowUserToResizeColumns = false;
            this.xavDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.xavDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.xavDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.xavDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.xavDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.xavDataGrid.ColumnHeadersHeight = 20;
            this.xavDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xUsername,
            this.Column2,
            this.CreateDate,
            this.LastLogin});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.xavDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.xavDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.xavDataGrid.Location = new System.Drawing.Point(20, 22);
            this.xavDataGrid.Name = "xavDataGrid";
            this.xavDataGrid.ReadOnly = true;
            this.xavDataGrid.RowHeadersVisible = false;
            this.xavDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.xavDataGrid.Size = new System.Drawing.Size(793, 440);
            this.xavDataGrid.TabIndex = 0;
            this.xavDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.xavDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.xavDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.xavDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.xavDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.xavDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.xavDataGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.xavDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.xavDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.xavDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.xavDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xavDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.xavDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.xavDataGrid.ThemeStyle.HeaderStyle.Height = 20;
            this.xavDataGrid.ThemeStyle.ReadOnly = true;
            this.xavDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.xavDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.xavDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xavDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.xavDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.xavDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.xavDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.xavDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // xUsername
            // 
            this.xUsername.HeaderText = "Username";
            this.xUsername.Name = "xUsername";
            this.xUsername.ReadOnly = true;
            this.xUsername.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Banned?";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CreateDate
            // 
            this.CreateDate.HeaderText = "CreateDate";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LastLogin
            // 
            this.LastLogin.HeaderText = "Last Login";
            this.LastLogin.Name = "LastLogin";
            this.LastLogin.ReadOnly = true;
            this.LastLogin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // levelLbl
            // 
            this.levelLbl.AutoSize = true;
            this.levelLbl.BackColor = System.Drawing.Color.Transparent;
            this.levelLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.levelLbl.Location = new System.Drawing.Point(438, 510);
            this.levelLbl.Name = "levelLbl";
            this.levelLbl.Size = new System.Drawing.Size(43, 15);
            this.levelLbl.TabIndex = 180;
            this.levelLbl.Text = "Level :";
            this.levelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.BackColor = System.Drawing.Color.Transparent;
            this.daysLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.daysLabel.Location = new System.Drawing.Point(440, 542);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(41, 15);
            this.daysLabel.TabIndex = 179;
            this.daysLabel.Text = "Time :";
            this.daysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubDd
            // 
            this.SubDd.BackColor = System.Drawing.Color.Transparent;
            this.SubDd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.SubDd.BorderRadius = 5;
            this.SubDd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SubDd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubDd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.SubDd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SubDd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SubDd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubDd.ForeColor = System.Drawing.Color.White;
            this.SubDd.ItemHeight = 20;
            this.SubDd.Location = new System.Drawing.Point(487, 504);
            this.SubDd.Name = "SubDd";
            this.SubDd.Size = new System.Drawing.Size(113, 26);
            this.SubDd.TabIndex = 177;
            // 
            // DaysDd
            // 
            this.DaysDd.BackColor = System.Drawing.Color.Transparent;
            this.DaysDd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.DaysDd.BorderRadius = 5;
            this.DaysDd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DaysDd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DaysDd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.DaysDd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DaysDd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DaysDd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DaysDd.ForeColor = System.Drawing.Color.White;
            this.DaysDd.ItemHeight = 20;
            this.DaysDd.Items.AddRange(new object[] {
            "Day",
            "Week",
            "Month",
            "Year",
            "Lifetime"});
            this.DaysDd.Location = new System.Drawing.Point(487, 536);
            this.DaysDd.Name = "DaysDd";
            this.DaysDd.Size = new System.Drawing.Size(113, 26);
            this.DaysDd.TabIndex = 176;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(233, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 182;
            this.label2.Text = "Username :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTb
            // 
            this.usernameTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.usernameTb.BorderRadius = 5;
            this.usernameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTb.DefaultText = "";
            this.usernameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.usernameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTb.Location = new System.Drawing.Point(309, 504);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.PasswordChar = '\0';
            this.usernameTb.PlaceholderText = "";
            this.usernameTb.SelectedText = "";
            this.usernameTb.Size = new System.Drawing.Size(113, 26);
            this.usernameTb.TabIndex = 181;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(238, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 184;
            this.label3.Text = "Password :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTb
            // 
            this.passwordTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.passwordTb.BorderRadius = 5;
            this.passwordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTb.DefaultText = "";
            this.passwordTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.passwordTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTb.Location = new System.Drawing.Point(309, 536);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '\0';
            this.passwordTb.PlaceholderText = "";
            this.passwordTb.SelectedText = "";
            this.passwordTb.Size = new System.Drawing.Size(113, 26);
            this.passwordTb.TabIndex = 183;
            // 
            // createUserBtn
            // 
            this.createUserBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.createUserBtn.BorderRadius = 5;
            this.createUserBtn.BorderThickness = 1;
            this.createUserBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createUserBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createUserBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createUserBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createUserBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.createUserBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.createUserBtn.ForeColor = System.Drawing.Color.White;
            this.createUserBtn.Location = new System.Drawing.Point(236, 573);
            this.createUserBtn.Name = "createUserBtn";
            this.createUserBtn.Size = new System.Drawing.Size(364, 26);
            this.createUserBtn.TabIndex = 185;
            this.createUserBtn.Text = "Create User";
            this.createUserBtn.Click += new System.EventHandler(this.createUserBtn_Click);
            // 
            // messageDialog
            // 
            this.messageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messageDialog.Caption = null;
            this.messageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.messageDialog.Parent = null;
            this.messageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.messageDialog.Text = null;
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(155, 615);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(522, 14);
            this.status.TabIndex = 186;
            this.status.Text = null;
            this.status.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(33)))));
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banUserToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(120, 26);
            // 
            // banUserToolStripMenuItem
            // 
            this.banUserToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.banUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("banUserToolStripMenuItem.Image")));
            this.banUserToolStripMenuItem.Name = "banUserToolStripMenuItem";
            this.banUserToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.banUserToolStripMenuItem.Text = "Ban user";
            this.banUserToolStripMenuItem.Click += new System.EventHandler(this.banUserToolStripMenuItem_Click);
            // 
            // UsersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(33)))));
            this.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.Controls.Add(this.status);
            this.Controls.Add(this.createUserBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xavDataGrid);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DaysDd);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.levelLbl);
            this.Controls.Add(this.SubDd);
            this.Name = "UsersTab";
            this.Size = new System.Drawing.Size(832, 649);
            this.Load += new System.EventHandler(this.UsersTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xavDataGrid)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView xavDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastLogin;
        private System.Windows.Forms.Label levelLbl;
        private System.Windows.Forms.Label daysLabel;
        private Guna.UI2.WinForms.Guna2ComboBox SubDd;
        private Guna.UI2.WinForms.Guna2ComboBox DaysDd;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox usernameTb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox passwordTb;
        private Guna.UI2.WinForms.Guna2Button createUserBtn;
        private Guna.UI2.WinForms.Guna2MessageDialog messageDialog;
        private Guna.UI2.WinForms.Guna2HtmlLabel status;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem banUserToolStripMenuItem;
    }
}
