using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class ApplicationForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public ApplicationForm()
        {
            InitializeComponent();
        }

        // Method allowing panel to act as title bar and be dragged like normal window
        private void Title_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PB_Exit_MouseEnterEvent(object sender, EventArgs e)
        {
            PB_Exit.Image = Properties.Resources.close_white_thick_16x16;
        }

        private void PB_Exit_MouseLeaveEvent(object sender, EventArgs e)
        {
            PB_Exit.Image = Properties.Resources.close_white_thin_16x16;
        }

        private void PB_Maximize_MouseEnterEvent(object sender, EventArgs e)
        {
            PB_Maximize.Image = Properties.Resources.maximize_inactive_white_16x16;
        }

        private void PB_Maximize_MouseLeaveEvent(object sender, EventArgs e)
        {
            PB_Maximize.Image = Properties.Resources.maximize_active_white_16x16;
        }

        private void PB_Maximize_ClickEvent(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void PB_Minimize_MouseEnterEvent(object sender, EventArgs e)
        {
            PB_Minimize.Image = Properties.Resources.minimize_thick_white_16x16;
        }

        private void PB_Minimize_MouseLeaveEvent(object sender, EventArgs e)
        {
            PB_Minimize.Image = Properties.Resources.minimize_thin_white_16x16;
        }

        private void PB_Minimize_ClickEvent(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PB_Exit_ClickEvent(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
