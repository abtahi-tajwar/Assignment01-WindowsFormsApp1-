using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01_WindowsFormsApp1_
{
    public partial class Details : Form
    {
        Form1 form;
        public string fname = "";
        public string lname = "";
        public string address = "";
        public string imageLocation = "";

        private string ConnectionString;
        private string sql;

        public Details(Form1 form)
        {
            InitializeComponent();
            this.form = form;

            
        }

        private void Details_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            txtFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            form.Close();
            this.Close();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            this.imageLocation = openFileDialog1.FileName;

            profilePicture.ImageLocation = this.imageLocation;
            profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void nextButton2_Click(object sender, EventArgs e)
        {
            this.fname = txtFname.Text;
            this.lname = txtLname.Text;
            this.address = txtAddress.Text;

            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\University\C#\Final\Assignment01(WindowsFormsApp1)\Assignment01(WindowsFormsApp1)\Database1.mdf;Integrated Security=True";
            sql = string.Format("INSERT INTO myData (Id, username, password, fname, lname, email, address, image) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}' ) ", 1, form.username, form.password, this.fname, this.lname, form.email, this.address, this.imageLocation);

            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(sql, conn);

            command.Connection.Open();
            int rows = command.ExecuteNonQuery();
            if(rows == 0)
            {
                MessageBox.Show("Something went wrong while saving to database");
            }

            Show show = new Show(this, form);
            show.Show();
            this.Hide();
        }
    }
}
