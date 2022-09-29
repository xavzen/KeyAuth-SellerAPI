namespace xavHub.Controls
{
    partial class VariablesTab
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
            this.vardatagrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.varId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varMsg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.removeVarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.varDd = new Guna.UI2.WinForms.Guna2ComboBox();
            this.editVarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.varMsgTb = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vardatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // vardatagrid
            // 
            this.vardatagrid.AllowUserToAddRows = false;
            this.vardatagrid.AllowUserToDeleteRows = false;
            this.vardatagrid.AllowUserToResizeColumns = false;
            this.vardatagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.vardatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.vardatagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.vardatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vardatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.vardatagrid.ColumnHeadersHeight = 20;
            this.vardatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varId,
            this.varMsg});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vardatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.vardatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.vardatagrid.Location = new System.Drawing.Point(20, 31);
            this.vardatagrid.Name = "vardatagrid";
            this.vardatagrid.ReadOnly = true;
            this.vardatagrid.RowHeadersVisible = false;
            this.vardatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.vardatagrid.Size = new System.Drawing.Size(793, 460);
            this.vardatagrid.TabIndex = 2;
            this.vardatagrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.vardatagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.vardatagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.vardatagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.vardatagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.vardatagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.vardatagrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.vardatagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.vardatagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.vardatagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.vardatagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vardatagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.vardatagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.vardatagrid.ThemeStyle.HeaderStyle.Height = 20;
            this.vardatagrid.ThemeStyle.ReadOnly = true;
            this.vardatagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.vardatagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.vardatagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vardatagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.vardatagrid.ThemeStyle.RowsStyle.Height = 22;
            this.vardatagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.vardatagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // varId
            // 
            this.varId.FillWeight = 20F;
            this.varId.HeaderText = "Variable ID";
            this.varId.Name = "varId";
            this.varId.ReadOnly = true;
            // 
            // varMsg
            // 
            this.varMsg.FillWeight = 80F;
            this.varMsg.HeaderText = "Message";
            this.varMsg.Name = "varMsg";
            this.varMsg.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(40, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 183;
            this.label2.Text = "Variable :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeVarBtn
            // 
            this.removeVarBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.removeVarBtn.BorderRadius = 5;
            this.removeVarBtn.BorderThickness = 1;
            this.removeVarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.removeVarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.removeVarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.removeVarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.removeVarBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.removeVarBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.removeVarBtn.ForeColor = System.Drawing.Color.White;
            this.removeVarBtn.Location = new System.Drawing.Point(422, 580);
            this.removeVarBtn.Name = "removeVarBtn";
            this.removeVarBtn.Size = new System.Drawing.Size(155, 26);
            this.removeVarBtn.TabIndex = 187;
            this.removeVarBtn.Text = "Remove Variable";
            this.removeVarBtn.Click += new System.EventHandler(this.removeVarBtn_Click);
            // 
            // varDd
            // 
            this.varDd.BackColor = System.Drawing.Color.Transparent;
            this.varDd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.varDd.BorderRadius = 5;
            this.varDd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.varDd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.varDd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.varDd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.varDd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.varDd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.varDd.ForeColor = System.Drawing.Color.White;
            this.varDd.ItemHeight = 20;
            this.varDd.Location = new System.Drawing.Point(43, 533);
            this.varDd.Name = "varDd";
            this.varDd.Size = new System.Drawing.Size(224, 26);
            this.varDd.TabIndex = 178;
            this.varDd.DropDown += new System.EventHandler(this.varDd_DropDown);
            this.varDd.SelectionChangeCommitted += new System.EventHandler(this.varDd_SelectionChangeCommitted);
            // 
            // editVarBtn
            // 
            this.editVarBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.editVarBtn.BorderRadius = 5;
            this.editVarBtn.BorderThickness = 1;
            this.editVarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editVarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editVarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editVarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editVarBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.editVarBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editVarBtn.ForeColor = System.Drawing.Color.White;
            this.editVarBtn.Location = new System.Drawing.Point(261, 580);
            this.editVarBtn.Name = "editVarBtn";
            this.editVarBtn.Size = new System.Drawing.Size(155, 26);
            this.editVarBtn.TabIndex = 186;
            this.editVarBtn.Text = "Edit Variable";
            this.editVarBtn.Click += new System.EventHandler(this.editVarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(270, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 184;
            this.label1.Text = "Message :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // varMsgTb
            // 
            this.varMsgTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.varMsgTb.BorderRadius = 5;
            this.varMsgTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.varMsgTb.DefaultText = "";
            this.varMsgTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.varMsgTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.varMsgTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.varMsgTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.varMsgTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.varMsgTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.varMsgTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.varMsgTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.varMsgTb.Location = new System.Drawing.Point(273, 533);
            this.varMsgTb.Name = "varMsgTb";
            this.varMsgTb.PasswordChar = '\0';
            this.varMsgTb.PlaceholderText = "Insert variable message";
            this.varMsgTb.SelectedText = "";
            this.varMsgTb.Size = new System.Drawing.Size(518, 26);
            this.varMsgTb.TabIndex = 182;
            // 
            // VariablesTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.removeVarBtn);
            this.Controls.Add(this.editVarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.varMsgTb);
            this.Controls.Add(this.varDd);
            this.Controls.Add(this.vardatagrid);
            this.Name = "VariablesTab";
            this.Size = new System.Drawing.Size(832, 649);
            this.Load += new System.EventHandler(this.VariablesTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vardatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView vardatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn varId;
        private System.Windows.Forms.DataGridViewTextBoxColumn varMsg;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button removeVarBtn;
        private Guna.UI2.WinForms.Guna2ComboBox varDd;
        private Guna.UI2.WinForms.Guna2Button editVarBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox varMsgTb;
    }
}
