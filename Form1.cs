using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giris_Panel
{
    public partial class GirisPanel : Form
    {
        public GirisPanel()
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

        private void GirisPanel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void GirisPanel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void GirisPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move) { 
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
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
                txtPassword.PasswordChar='*';
            }
        }

        char? none = null;
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.PasswordChar = Convert.ToChar(none);
            }
        }
    }
}
