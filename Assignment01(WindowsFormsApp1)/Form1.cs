using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//   if exist "$(TargetPath).locked" del "$(TargetPath).locked"
//   if not exist "$(TargetPath).locked" move "$(TargetPath)" "$(TargetPath).locked"



namespace Assignment01_WindowsFormsApp1_
{
    public partial class Form1 : Form
    {
        public string username = "";
        public string password = "";
        public string email = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.username = txtUsername.Text;
            this.password = txtPassword.Text;
            this.email = txtEmail.Text;

            Details details = new Details(this);
            details.Show();
            this.Hide();
        }
    }
}
