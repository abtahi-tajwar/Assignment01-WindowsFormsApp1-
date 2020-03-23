using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01_WindowsFormsApp1_
{
    public partial class Show : Form
    {
        Details details;
        Form1 form;
        public Show(Details details, Form1 form)
        {
            InitializeComponent();
            
            this.details = details;
            this.form = form;
        }

        private void Show_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            profilePicture.ImageLocation = this.details.imageLocation;
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            name.Text = details.fname+" "+details.lname;
            showUsername.Text = form.username;
            showEmail.Text = form.email;
            showDob.Text = details.address;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            details.Close();
            form.Close();
            this.Dispose();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
