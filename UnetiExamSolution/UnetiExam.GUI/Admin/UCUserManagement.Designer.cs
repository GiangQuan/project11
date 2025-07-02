using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace UnetiExam.GUI
{
    partial class UCUserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUserManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addUserBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.searchUserTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabelPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.userTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            this.tabelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            this.SuspendLayout();
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.Transparent;
            this.addUserBtn.BorderRadius = 8;
            this.addUserBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addUserBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addUserBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addUserBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addUserBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(132)))), ((int)(((byte)(251)))));
            this.addUserBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.Color.White;
            this.addUserBtn.Image = ((System.Drawing.Image)(resources.GetObject("addUserBtn.Image")));
            this.addUserBtn.Location = new System.Drawing.Point(779, 49);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.ShadowDecoration.Depth = 15;
            this.addUserBtn.ShadowDecoration.Enabled = true;
            this.addUserBtn.Size = new System.Drawing.Size(117, 47);
            this.addUserBtn.TabIndex = 12;
            this.addUserBtn.Text = "Thêm mới";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.searchUserTextbox);
            this.guna2Panel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(39, 129);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 15;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2Panel1.ShadowDecoration.Depth = 5;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(857, 74);
            this.guna2Panel1.TabIndex = 14;
            // 
            // searchUserTextbox
            // 
            this.searchUserTextbox.BorderRadius = 7;
            this.searchUserTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchUserTextbox.DefaultText = "";
            this.searchUserTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchUserTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchUserTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchUserTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchUserTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchUserTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchUserTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchUserTextbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchUserTextbox.IconLeft")));
            this.searchUserTextbox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.searchUserTextbox.Location = new System.Drawing.Point(16, 22);
            this.searchUserTextbox.Name = "searchUserTextbox";
            this.searchUserTextbox.PlaceholderText = "Tìm kiếm";
            this.searchUserTextbox.SelectedText = "";
            this.searchUserTextbox.Size = new System.Drawing.Size(820, 36);
            this.searchUserTextbox.TabIndex = 0;
            // 
            // tabelPanel
            // 
            this.tabelPanel.BorderRadius = 30;
            this.tabelPanel.Controls.Add(this.userTable);
            this.tabelPanel.FillColor = System.Drawing.Color.White;
            this.tabelPanel.Location = new System.Drawing.Point(39, 233);
            this.tabelPanel.Name = "tabelPanel";
            this.tabelPanel.Size = new System.Drawing.Size(857, 231);
            this.tabelPanel.TabIndex = 18;
            // 
            // userTable
            // 
            this.userTable.AllowUserToAddRows = false;
            this.userTable.AllowUserToDeleteRows = false;
            this.userTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(123)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userTable.ColumnHeadersHeight = 29;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberColumn,
            this.nameColumn,
            this.usernameColumn,
            this.roleColumn,
            this.classColumn,
            this.actionColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.userTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.userTable.Location = new System.Drawing.Point(0, 0);
            this.userTable.Name = "userTable";
            this.userTable.ReadOnly = true;
            this.userTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.userTable.RowHeadersVisible = false;
            this.userTable.RowTemplate.Height = 50;
            this.userTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.userTable.ShowEditingIcon = false;
            this.userTable.Size = new System.Drawing.Size(857, 231);
            this.userTable.TabIndex = 17;
            this.userTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.userTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.userTable.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.userTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.userTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(123)))), ((int)(((byte)(251)))));
            this.userTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userTable.ThemeStyle.HeaderStyle.Height = 29;
            this.userTable.ThemeStyle.ReadOnly = true;
            this.userTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.userTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.userTable.ThemeStyle.RowsStyle.Height = 50;
            this.userTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.userTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.userTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // numberColumn
            // 
            this.numberColumn.FillWeight = 40F;
            this.numberColumn.HeaderText = "ID";
            this.numberColumn.Name = "numberColumn";
            this.numberColumn.ReadOnly = true;
            this.numberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Tên người dùng";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // usernameColumn
            // 
            this.usernameColumn.FillWeight = 105.9644F;
            this.usernameColumn.HeaderText = "Username";
            this.usernameColumn.Name = "usernameColumn";
            this.usernameColumn.ReadOnly = true;
            // 
            // roleColumn
            // 
            this.roleColumn.FillWeight = 70F;
            this.roleColumn.HeaderText = "Vai trò";
            this.roleColumn.Name = "roleColumn";
            this.roleColumn.ReadOnly = true;
            // 
            // classColumn
            // 
            this.classColumn.FillWeight = 50F;
            this.classColumn.HeaderText = "Lớp";
            this.classColumn.Name = "classColumn";
            this.classColumn.ReadOnly = true;
            // 
            // actionColumn
            // 
            this.actionColumn.FillWeight = 40F;
            this.actionColumn.HeaderText = "Hành động";
            this.actionColumn.Name = "actionColumn";
            this.actionColumn.ReadOnly = true;
            // 
            // UCUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabelPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.addUserBtn);
            this.Name = "UCUserManagement";
            this.Size = new System.Drawing.Size(972, 688);
            this.guna2Panel1.ResumeLayout(false);
            this.tabelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button addUserBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox searchUserTextbox;
        private Guna.UI2.WinForms.Guna2Panel tabelPanel;
        private Guna2DataGridView userTable;
        private DataGridViewTextBoxColumn numberColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn usernameColumn;
        private DataGridViewTextBoxColumn roleColumn;
        private DataGridViewTextBoxColumn classColumn;
        private DataGridViewTextBoxColumn actionColumn;
    }
}
