using System.Drawing;
using System.Runtime;
using System.Windows.Forms;

namespace UnetiExam.GUI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.usernameOnTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.userManageBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.testBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.homeBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.resultBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.panelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.createExamBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel1.Controls.Add(this.usernameOnTitle);
            this.guna2Panel1.Controls.Add(this.logoutBtn);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 0;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(1184, 57);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(925, 20);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(17, 20);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 14;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.Click += new System.EventHandler(this.guna2PictureBox3_Click_1);
            // 
            // usernameOnTitle
            // 
            this.usernameOnTitle.BackColor = System.Drawing.Color.Transparent;
            this.usernameOnTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameOnTitle.ForeColor = System.Drawing.Color.DimGray;
            this.usernameOnTitle.Location = new System.Drawing.Point(948, 21);
            this.usernameOnTitle.Name = "usernameOnTitle";
            this.usernameOnTitle.Size = new System.Drawing.Size(37, 19);
            this.usernameOnTitle.TabIndex = 11;
            this.usernameOnTitle.Text = "name";
            this.usernameOnTitle.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.FillColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.DimGray;
            this.logoutBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.logoutBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutBtn.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageOffset = new System.Drawing.Point(-1, 0);
            this.logoutBtn.Location = new System.Drawing.Point(1080, 13);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(92, 33);
            this.logoutBtn.TabIndex = 13;
            this.logoutBtn.Text = "Sign out";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(21, 13);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 12;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(958, 22);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = null;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.guna2Separator1.Location = new System.Drawing.Point(3, 56);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1181, 1);
            this.guna2Separator1.TabIndex = 8;
            this.guna2Separator1.Click += new System.EventHandler(this.guna2Separator1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("iCiel Samsung Sharp Sans Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(62, 13);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(157, 38);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "UnetiExam";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.createExamBtn);
            this.guna2Panel3.Controls.Add(this.userManageBtn);
            this.guna2Panel3.Controls.Add(this.testBtn);
            this.guna2Panel3.Controls.Add(this.homeBtn);
            this.guna2Panel3.Controls.Add(this.resultBtn);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.guna2Panel3.ShadowDecoration.Depth = 20;
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.guna2Panel3.Size = new System.Drawing.Size(194, 704);
            this.guna2Panel3.TabIndex = 4;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // userManageBtn
            // 
            this.userManageBtn.AllowDrop = true;
            this.userManageBtn.BackColor = System.Drawing.SystemColors.Window;
            this.userManageBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(211)))), ((int)(((byte)(254)))));
            this.userManageBtn.BorderRadius = 10;
            this.userManageBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(211)))), ((int)(((byte)(254)))));
            this.userManageBtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.userManageBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userManageBtn.CustomImages.ImageOffset = new System.Drawing.Point(5, 0);
            this.userManageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.userManageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.userManageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.userManageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.userManageBtn.FillColor = System.Drawing.Color.White;
            this.userManageBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userManageBtn.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.userManageBtn.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.userManageBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.userManageBtn.Location = new System.Drawing.Point(12, 230);
            this.userManageBtn.Name = "userManageBtn";
            this.userManageBtn.Size = new System.Drawing.Size(172, 48);
            this.userManageBtn.TabIndex = 8;
            this.userManageBtn.Text = "Quản lý user";
            this.userManageBtn.TextOffset = new System.Drawing.Point(5, 0);
            this.userManageBtn.Click += new System.EventHandler(this.guna2TileButton4_Click);
            // 
            // testBtn
            // 
            this.testBtn.BackColor = System.Drawing.SystemColors.Window;
            this.testBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(211)))), ((int)(((byte)(254)))));
            this.testBtn.BorderRadius = 10;
            this.testBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(211)))), ((int)(((byte)(254)))));
            this.testBtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.testBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.testBtn.CustomImages.ImageOffset = new System.Drawing.Point(6, 0);
            this.testBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.testBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.testBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.testBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.testBtn.FillColor = System.Drawing.Color.White;
            this.testBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.testBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.testBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.testBtn.Location = new System.Drawing.Point(12, 68);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(172, 48);
            this.testBtn.TabIndex = 7;
            this.testBtn.Text = "Quản lý đề thi";
            this.testBtn.TextOffset = new System.Drawing.Point(11, 0);
            this.testBtn.Click += new System.EventHandler(this.guna2TileButton3_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.White;
            this.homeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(211)))), ((int)(((byte)(254)))));
            this.homeBtn.BorderRadius = 10;
            this.homeBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(211)))), ((int)(((byte)(254)))));
            this.homeBtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.homeBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeBtn.CustomImages.ImageOffset = new System.Drawing.Point(5, 0);
            this.homeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeBtn.FillColor = System.Drawing.Color.White;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homeBtn.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.homeBtn.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.homeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.homeBtn.Location = new System.Drawing.Point(12, 10);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(172, 48);
            this.homeBtn.TabIndex = 5;
            this.homeBtn.Text = "Trang chủ";
            this.homeBtn.Click += new System.EventHandler(this.guna2TileButton1_Click);
            this.homeBtn.MouseHover += new System.EventHandler(this.guna2TileButton1_MouseHover);
            // 
            // resultBtn
            // 
            this.resultBtn.BackColor = System.Drawing.SystemColors.Window;
            this.resultBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(211)))), ((int)(((byte)(254)))));
            this.resultBtn.BorderRadius = 10;
            this.resultBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(211)))), ((int)(((byte)(254)))));
            this.resultBtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.resultBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.resultBtn.CustomImages.ImageOffset = new System.Drawing.Point(5, 0);
            this.resultBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resultBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resultBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resultBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resultBtn.FillColor = System.Drawing.Color.White;
            this.resultBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resultBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.resultBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.resultBtn.Location = new System.Drawing.Point(12, 122);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(172, 48);
            this.resultBtn.TabIndex = 6;
            this.resultBtn.Text = "Kết quả";
            this.resultBtn.TextOffset = new System.Drawing.Point(-10, 0);
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.AutoRoundedCorners = true;
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panelContainer.BorderThickness = 2;
            this.panelContainer.Controls.Add(this.guna2Panel3);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContainer.Location = new System.Drawing.Point(0, 57);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.ShadowDecoration.Depth = 5;
            this.panelContainer.ShadowDecoration.Enabled = true;
            this.panelContainer.Size = new System.Drawing.Size(1184, 704);
            this.panelContainer.TabIndex = 5;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel4_Paint);
            // 
            // createExamBtn
            // 
            this.createExamBtn.BackColor = System.Drawing.SystemColors.Window;
            this.createExamBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(211)))), ((int)(((byte)(254)))));
            this.createExamBtn.BorderRadius = 10;
            this.createExamBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(211)))), ((int)(((byte)(254)))));
            this.createExamBtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.createExamBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.createExamBtn.CustomImages.ImageOffset = new System.Drawing.Point(5, 0);
            this.createExamBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createExamBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createExamBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createExamBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createExamBtn.FillColor = System.Drawing.Color.White;
            this.createExamBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createExamBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createExamBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.createExamBtn.ImageOffset = new System.Drawing.Point(5, 0);
            this.createExamBtn.Location = new System.Drawing.Point(12, 176);
            this.createExamBtn.Name = "createExamBtn";
            this.createExamBtn.Size = new System.Drawing.Size(172, 48);
            this.createExamBtn.TabIndex = 9;
            this.createExamBtn.Text = "Tạo bài thi";
            this.createExamBtn.Click += new System.EventHandler(this.guna2TileButton1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel panelContainer;
        private Guna.UI2.WinForms.Guna2TileButton homeBtn;
        private Guna.UI2.WinForms.Guna2TileButton testBtn;
        private Guna.UI2.WinForms.Guna2TileButton resultBtn;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TileButton userManageBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel usernameOnTitle;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2TileButton createExamBtn;
    }
}