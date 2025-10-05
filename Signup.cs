using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Giris_Panel
{

    public partial class Signup : Form
    {
        SqlConnection conn = GirisPanel.conn;
        public Signup()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.White;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.PasswordChar = '*';
            }
        }

        
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            char? none = null;
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.PasswordChar = Convert.ToChar(none);
            }
        }

     
     

        private void Signup_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Signup_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Signup_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Info (username,pass,re_pass,e_mail,phone) values ('"+Cryptology.Encryption(txtUsername.Text,2)+"', '"+ Cryptology.Encryption(txtRePassword.Text,2)+"', '"+ Cryptology.Encryption(txtRePassword.Text,2)+"', '"+ Cryptology.Encryption(txtEmail.Text,2)+"', '"+ Cryptology.Encryption(txtPhone.Text,2)+"')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
