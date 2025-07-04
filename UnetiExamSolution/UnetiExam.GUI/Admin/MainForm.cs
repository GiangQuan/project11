﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UnetiExam.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        UCHome ucHome;
        UCTestManagement ucTestManagement;
        UCUserManagement ucUserManagement;
        UCResult ucResult;   

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void asd_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            // Close this form when login form is closed
            loginForm.FormClosed += (s, args) => this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ucHome = new UCHome();
            ucHome.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucHome);

            ucTestManagement = new UCTestManagement();
            ucTestManagement.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucTestManagement);

            ucUserManagement = new UCUserManagement();
            ucUserManagement.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucUserManagement);

            ucResult = new UCResult();
            ucResult.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucResult);

            // Show UC home default
            ucHome.BringToFront();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            

            Application.Exit();
        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }
        public void SetUsername(string username)
        {
            if(username.Length > 10)
            {
                username = username.Substring(0, 10) + "..."; // Giới hạn độ dài tên người dùng
            }
            String role = "Admin"; // Giả sử đây là vai trò của người dùng, có thể lấy từ cơ sở dữ liệu hoặc logic khác
            usernameOnTitle.Text = username + $"({role})";
            
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to exit the application?",
        "Exit Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy việc đóng form
            }
            // Nếu Yes ➔ form sẽ đóng bình thường
        }
        void resetColorButton()
        {
            homeBtn.FillColor = Color.White;
            userManageBtn.FillColor = Color.White;
            testBtn.FillColor = Color.White;
            resultBtn.FillColor = Color.White;
        }
        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            
            ucHome.BringToFront();
            resetColorButton();
            homeBtn.FillColor = Color.FromArgb(239, 246, 255);
            
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            ucTestManagement.BringToFront();
            resetColorButton();
            testBtn.FillColor = Color.FromArgb(239, 246, 255);
        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            ucUserManagement.BringToFront();
            resetColorButton();
            userManageBtn.FillColor = Color.FromArgb(239, 246, 255);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TileButton1_MouseHover(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ucTestManagement1_Load(object sender, EventArgs e)
        {

        }

        private void ucUserManagement1_Load(object sender, EventArgs e)
        {

        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            

            ucResult.BringToFront();
            resetColorButton();
            resultBtn.FillColor = Color.FromArgb(239, 246, 255);
        }

        private void guna2PictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to log out?",
        "Logout Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                // Close this form when login form is closed
                loginForm.FormClosed += (s, args) => this.Close();
            }
        }
    }
}
