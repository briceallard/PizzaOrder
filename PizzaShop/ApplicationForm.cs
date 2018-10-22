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


        /**************************************************************************
         * 
         * 
         * MOUSE CLICK EVENTS, HOVER EFFECTS, AND WINDOW MANIBPULATION BELLOW
         * 
         * 
         *************************************************************************/

        /**
         * 
         * 
         * TITLE BAR CUSTOMIZATION
         * 
         */ 
        private void Title_MouseDownEvent(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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

        private void PB_Minimize_ClickEvent(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PB_Exit_ClickEvent(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * 
         * 
         * NAVIGATION MENU CUSTOMIZATION
         * 
         */
        private void PB_Minimize_MouseEnterEvent(object sender, EventArgs e)
        {
            PB_Minimize.Image = Properties.Resources.minimize_thick_white_16x16;
        }

        private void PB_Minimize_MouseLeaveEvent(object sender, EventArgs e)
        {
            PB_Minimize.Image = Properties.Resources.minimize_thin_white_16x16;
        }

        private void PB_Settings_MouseEnterEvent(object sender, EventArgs e)
        {
            PB_Settings.Image = Properties.Resources.settings_white_thick_24x24;
        }

        private void PB_Settings_MouseLeaveEvent(object sender, EventArgs e)
        {
            PB_Settings.Image = Properties.Resources.settings_white_thin_24x24;
        }

        private void PB_About_MouseEnterEvent(object sender, EventArgs e)
        {
            PB_About.Image = Properties.Resources.info_white_thick_24x24;
        }

        private void PB_About_MouseLeaveEvent(object sender, EventArgs e)
        {
            PB_About.Image = Properties.Resources.info_white_thin_24x24;
        }
        private void BTN_Nav_Menu_MouseEnterEvent(object sender, EventArgs e)
        {
            Lightup_Panel_Menu.BackColor = Utilities.ACCENT_COLOR;
        }

        private void BTN_Nav_Menu_MouseLeaveEvent(object sender, EventArgs e)
        {
            if (TC_Navigation.SelectedIndex == 0)
                Lightup_Panel_Menu.BackColor = Utilities.ACCENT_COLOR;
            else
                Lightup_Panel_Menu.BackColor = Utilities.SECONDARY_COLOR;
        }

        private void BTN_Nav_Specialties_MouseEnterEvent(object sender, EventArgs e)
        {
            Lightup_Panel_Specialties.BackColor = Utilities.ACCENT_COLOR;
        }

        private void BTN_Nav_Specialties_MouseLeaveEvent(object sender, EventArgs e)
        {
            if (TC_Navigation.SelectedIndex == 1)
                Lightup_Panel_Specialties.BackColor = Utilities.ACCENT_COLOR;
            else
                Lightup_Panel_Specialties.BackColor = Utilities.SECONDARY_COLOR;
        }

        private void BTN_Nav_Custom_MouseEnterEvent(object sender, EventArgs e)
        {
            Lightup_Panel_Custom.BackColor = Utilities.ACCENT_COLOR;
        }

        private void BTN_Nav_Custom_MouseLeaveEvent(object sender, EventArgs e)
        {
            if (TC_Navigation.SelectedIndex == 2)
                Lightup_Panel_Custom.BackColor = Utilities.ACCENT_COLOR;
            else
                Lightup_Panel_Custom.BackColor = Utilities.SECONDARY_COLOR;
        }

        private void BTN_Nav_Order_MouseEnterEvent(object sender, EventArgs e)
        {
            Lightup_Panel_Order.BackColor = Utilities.ACCENT_COLOR;
        }

        private void BTN_Nav_Order_MouseLeaveEvent(object sender, EventArgs e)
        {
            if (TC_Navigation.SelectedIndex == 3)
                Lightup_Panel_Order.BackColor = Utilities.ACCENT_COLOR;
            else
                Lightup_Panel_Order.BackColor = Utilities.SECONDARY_COLOR;
        }

        private void BTN_Nav_Menu_Click(object sender, EventArgs e)
        {
            TC_Navigation.SelectedIndex = 0;
            Lightup_Panel_Menu.BackColor = Utilities.ACCENT_COLOR;
            Lightup_Panel_Specialties.BackColor = Utilities.SECONDARY_COLOR;
            Lightup_Panel_Custom.BackColor = Utilities.SECONDARY_COLOR;
            Lightup_Panel_Order.BackColor = Utilities.SECONDARY_COLOR;
        }

        private void BTN_Nav_Specialties_Click(object sender, EventArgs e)
        {
            TC_Navigation.SelectedIndex = 1;
            Lightup_Panel_Menu.BackColor = Utilities.SECONDARY_COLOR;
            Lightup_Panel_Specialties.BackColor = Utilities.ACCENT_COLOR;
            Lightup_Panel_Custom.BackColor = Utilities.SECONDARY_COLOR;
            Lightup_Panel_Order.BackColor = Utilities.SECONDARY_COLOR;
        }

        private void BTN_Nav_Custom_Click(object sender, EventArgs e)
        {
            TC_Navigation.SelectedIndex = 2;
            Lightup_Panel_Menu.BackColor = Utilities.SECONDARY_COLOR;
            Lightup_Panel_Specialties.BackColor = Utilities.SECONDARY_COLOR;
            Lightup_Panel_Custom.BackColor = Utilities.ACCENT_COLOR;
            Lightup_Panel_Order.BackColor = Utilities.SECONDARY_COLOR;
        }

        private void BTN_Nav_Order_Click(object sender, EventArgs e)
        {
            TC_Navigation.SelectedIndex = 3;
            Lightup_Panel_Menu.BackColor = Utilities.SECONDARY_COLOR;
            Lightup_Panel_Specialties.BackColor = Utilities.SECONDARY_COLOR;
            Lightup_Panel_Custom.BackColor = Utilities.SECONDARY_COLOR;
            Lightup_Panel_Order.BackColor = Utilities.ACCENT_COLOR;
        }
    }
}
