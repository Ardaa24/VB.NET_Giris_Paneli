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
    public partial class guard : Form
    {
        public guard()
        {
            InitializeComponent();
        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guard_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void guard_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void guard_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void guard_Load(object sender, EventArgs e)
        {

        }

        private void SMS()
        {
            //api eklenecek
        }
    }
}
