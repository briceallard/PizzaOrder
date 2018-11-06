/**
 *  Brice Allard
 *  Catterina's Pizza
 *  November 3, 2018
 * 
 *  Description: 
 *      Winforms application that allows the user to choose from preselected menu
 *      items or create their own custom pizza with toppings of their choice.
 *      Images overlayed to display the look of the pizza has been implemented.
 **/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class ApplicationForm : Form
    {
        public static List<Image> Images = new List<Image>();
        public static CustomPizza Custom = new CustomPizza();
        public static double Cstm_Price = 0.00;
        public static double Subtotal = 0.00;
        public static double Tax = 0.00;
        public static double Total = 0.00;
        public static double TaxRate = 0.08;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        // Custom font library being loaded
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        FontFamily ff;
        Font font;

        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            loadFont();

            // Initialize the custom pizza image
            Images.Add(Utilities.CRUST_PAN);
            Images.Add(Utilities.TOP_MOZZ);
            CustomImage();
        }

        // Draw new image from List of images replicating a overlay look
        private void CustomImage()
        {
            int width = 341;
            int height = 316;
            Image image = new Bitmap(width, height);

            using (var graphics = Graphics.FromImage(image))
            {
                foreach (Image i in Images)
                {
                    graphics.DrawImage(i, new Rectangle(0, 0, width, height));
                }
            }

            PB_Cstm_PizzaImg.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_Cstm_PizzaImg.Image = image;
        }

        /**
         * 
         * 
         * FONT CUSTOMIZATION
         * 
         */
        private void loadFont()
        {
            byte[] fontArray = Properties.Resources.Italiano;
            int dataLength = Properties.Resources.Italiano.Length;

            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);

            Marshal.Copy(fontArray, 0, ptrData, dataLength);

            uint cFonts = 0;

            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddMemoryFont(ptrData, dataLength);

            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Regular);
        }

        private void AllocFont(Font f, Control c, float size)
        {
            FontStyle fontStyle = FontStyle.Regular;
            c.Font = new Font(ff, size, fontStyle);
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

        /**
         * 
         * 
         * MENU TAB CUSTOMIZATION
         * 
         */
        private void BTN_Order_MouseEnter(object sender, EventArgs e)
        {
            Button btn = ((Button)sender);
            btn.FlatAppearance.BorderColor = Utilities.ACCENT_COLOR;
            btn.ForeColor = Utilities.ACCENT_COLOR;
        }

        private void BTN_Order_MouseLeave(object sender, EventArgs e)
        {
            Button btn = ((Button)sender);
            btn.FlatAppearance.BorderColor = Color.Black;
            btn.ForeColor = Color.Black;
        }

        private void PNL_UpdatePrice(object sender, EventArgs e)
        {
            string name = ((ComboBox)sender).Name;

            if (name.StartsWith("CB_Cheese_"))
            {
                double price = Utilities.getPrice(CB_Cheese_Size) +
                    Utilities.getPrice(CB_Cheese_Crust) +
                    Utilities.getPrice(CB_Cheese_Toppings);

                LBL_Cheese_Price.Text = $"${price.ToString()}";
            }
            else if (name.StartsWith("CB_Pepperoni_"))
            {
                double price = Utilities.getPrice(CB_Pepperoni_Size) +
                    Utilities.getPrice(CB_Pepperoni_Crust) +
                    Utilities.getPrice(CB_Pepperoni_Toppings);

                LBL_Pepperoni_Price.Text = $"${price.ToString()}";
            }
            else if (name.StartsWith("CB_BBQ_"))
            {
                double price = Utilities.getPrice(CB_BBQ_Size) +
                    Utilities.getPrice(CB_BBQ_Crust) +
                    Utilities.getPrice(CB_BBQ_Toppings);

                LBL_BBQ_Price.Text = $"${price.ToString()}";
            }
            else if (name.StartsWith("CB_Supreme_"))
            {
                double price = Utilities.getPrice(CB_Supreme_Size) +
                    Utilities.getPrice(CB_Supreme_Crust) +
                    Utilities.getPrice(CB_Supreme_Toppings);

                LBL_Supreme_Price.Text = $"${price.ToString()}";
            }
            else if (name.StartsWith("CB_Taco_"))
            {
                double price = Utilities.getPrice(CB_Taco_Size) +
                    Utilities.getPrice(CB_Taco_Crust) +
                    Utilities.getPrice(CB_Taco_Toppings);

                LBL_Taco_Price.Text = $"${price.ToString()}";
            }
            else if (name.StartsWith("CB_Breakfast_"))
            {
                double price = Utilities.getPrice(CB_Breakfast_Size) +
                    Utilities.getPrice(CB_Breakfast_Crust) +
                    Utilities.getPrice(CB_Breakfast_Toppings);

                LBL_Breakfast_Price.Text = $"${price.ToString()}";
            }
            else if (name.StartsWith("CB_Spinach_"))
            {
                double price = Utilities.getPrice(CB_Spinach_Size) +
                    Utilities.getPrice(CB_Spinach_Crust) +
                    Utilities.getPrice(CB_Spinach_Toppings);

                LBL_Spinach_Price.Text = $"${price.ToString()}";
            }
            else if (name.StartsWith("CB_Potato_"))
            {
                double price = Utilities.getPrice(CB_Potato_Size) +
                    Utilities.getPrice(CB_Potato_Crust) +
                    Utilities.getPrice(CB_Potato_Toppings);

                LBL_Potato_Price.Text = $"${price.ToString()}";
            }
        }

        /**
         *  
         *  Order Button Methods AND Checkout Configurations below
         * 
         **/
        private void BTN_Cheese_Order_Click(object sender, EventArgs e)
        {
            if (CB_Cheese_Size.Text == "- Size -" || CB_Cheese_Crust.Text == "- Crust -" || CB_Cheese_Toppings.Text == "- Toppings -")
            {
                MessageBox.Show("Please Select From All Options");
                return;
            }
            ListViewItem item = new ListViewItem("100");
            item.SubItems.Add("Cheese");
            item.SubItems.Add(Utilities.getName(CB_Cheese_Size));
            item.SubItems.Add(Utilities.getName(CB_Cheese_Crust));
            item.SubItems.Add(Utilities.getName(CB_Cheese_Toppings));
            item.SubItems.Add(LBL_Cheese_Price.Text);
            LV_Cart.Items.Add(item);

            Double.TryParse(Utilities.getLabelPrice(LBL_Cheese_Price), out double temp);
            Subtotal += temp;
            LBL_Order_Subtotal.Text = $"${Subtotal}";
            PB_Order_Notify.Visible = true;
            MessageBox.Show("Cheese Pizza added to Order!\n\nGo to 'Your Order' to Checkout ...");
        }

        private void BTN_Pepperoni_Order_Click(object sender, EventArgs e)
        {
            if (CB_Pepperoni_Size.Text == "- Size -" || CB_Pepperoni_Crust.Text == "- Crust -" || CB_Pepperoni_Toppings.Text == "- Toppings -")
            {
                MessageBox.Show("Please Select From All Options");
                return;
            }
            ListViewItem item = new ListViewItem("200");
            item.SubItems.Add("Pepperoni");
            item.SubItems.Add(Utilities.getName(CB_Pepperoni_Size));
            item.SubItems.Add(Utilities.getName(CB_Pepperoni_Crust));
            item.SubItems.Add(Utilities.getName(CB_Pepperoni_Toppings));
            item.SubItems.Add(LBL_Pepperoni_Price.Text);
            LV_Cart.Items.Add(item);

            Double.TryParse(Utilities.getLabelPrice(LBL_Pepperoni_Price), out double temp);
            Subtotal += temp;
            LBL_Order_Subtotal.Text = $"${Subtotal}";
            PB_Order_Notify.Visible = true;
            MessageBox.Show("Pepperoni Pizza added to Order!\n\nGo to 'Your Order' to Checkout ...");
        }

        private void BTN_BBQ_Order_Click(object sender, EventArgs e)
        {
            if (CB_BBQ_Size.Text == "- Size -" || CB_BBQ_Crust.Text == "- Crust -" || CB_BBQ_Toppings.Text == "- Toppings -")
            {
                MessageBox.Show("Please Select From All Options");
                return;
            }
            ListViewItem item = new ListViewItem("300");
            item.SubItems.Add("BBQ");
            item.SubItems.Add(Utilities.getName(CB_BBQ_Size));
            item.SubItems.Add(Utilities.getName(CB_BBQ_Crust));
            item.SubItems.Add(Utilities.getName(CB_BBQ_Toppings));
            item.SubItems.Add(LBL_BBQ_Price.Text);
            LV_Cart.Items.Add(item);

            Double.TryParse(Utilities.getLabelPrice(LBL_BBQ_Price), out double temp);
            Subtotal += temp;
            LBL_Order_Subtotal.Text = $"${Subtotal}";
            PB_Order_Notify.Visible = true;
            MessageBox.Show("BBQ Pizza added to Order!\n\nGo to 'Your Order' to Checkout ...");
        }

        private void BTN_Supreme_Order_Click(object sender, EventArgs e)
        {
            if (CB_Supreme_Size.Text == "- Size -" || CB_Supreme_Crust.Text == "- Crust -" || CB_Supreme_Toppings.Text == "- Toppings -")
            {
                MessageBox.Show("Please Select From All Options");
                return;
            }
            ListViewItem item = new ListViewItem("400");
            item.SubItems.Add("Supreme");
            item.SubItems.Add(Utilities.getName(CB_Supreme_Size));
            item.SubItems.Add(Utilities.getName(CB_Supreme_Crust));
            item.SubItems.Add(Utilities.getName(CB_Supreme_Toppings));
            item.SubItems.Add(LBL_Supreme_Price.Text);
            LV_Cart.Items.Add(item);

            Double.TryParse(Utilities.getLabelPrice(LBL_Supreme_Price), out double temp);
            Subtotal += temp;
            LBL_Order_Subtotal.Text = $"${Subtotal}";
            PB_Order_Notify.Visible = true;
            MessageBox.Show("Supreme Pizza added to Order!\n\nGo to 'Your Order' to Checkout ...");
        }

        private void BTN_Taco_Order_Click(object sender, EventArgs e)
        {
            if (CB_Taco_Size.Text == "- Size -" || CB_Taco_Crust.Text == "- Crust -" || CB_Taco_Toppings.Text == "- Toppings -")
            {
                MessageBox.Show("Please Select From All Options");
                return;
            }
            ListViewItem item = new ListViewItem("500");
            item.SubItems.Add("Taco");
            item.SubItems.Add(Utilities.getName(CB_Taco_Size));
            item.SubItems.Add(Utilities.getName(CB_Taco_Crust));
            item.SubItems.Add(Utilities.getName(CB_Taco_Toppings));
            item.SubItems.Add(LBL_Taco_Price.Text);
            LV_Cart.Items.Add(item);

            Double.TryParse(Utilities.getLabelPrice(LBL_Taco_Price), out double temp);
            Subtotal += temp;
            LBL_Order_Subtotal.Text = $"${Subtotal}";
            PB_Order_Notify.Visible = true; PB_Order_Notify.Visible = true;
            MessageBox.Show("Taco-Quesadilla Pizza added to Order!\n\nGo to 'Your Order' to Checkout ...");
        }

        private void BTN_Breakfast_Order_Click(object sender, EventArgs e)
        {
            if (CB_Breakfast_Size.Text == "- Size -" || CB_Breakfast_Crust.Text == "- Crust -" || CB_Breakfast_Toppings.Text == "- Toppings -")
            {
                MessageBox.Show("Please Select From All Options");
                return;
            }
            ListViewItem item = new ListViewItem("600");
            item.SubItems.Add("Breakfast");
            item.SubItems.Add(Utilities.getName(CB_Breakfast_Size));
            item.SubItems.Add(Utilities.getName(CB_Breakfast_Crust));
            item.SubItems.Add(Utilities.getName(CB_Breakfast_Toppings));
            item.SubItems.Add(LBL_Breakfast_Price.Text);
            LV_Cart.Items.Add(item);

            Double.TryParse(Utilities.getLabelPrice(LBL_Breakfast_Price), out double temp);
            Subtotal += temp;
            LBL_Order_Subtotal.Text = $"${Subtotal}";
            PB_Order_Notify.Visible = true;
            MessageBox.Show("Breakfast Pizza added to Order!\n\nGo to 'Your Order' to Checkout ...");
        }

        private void BTN_Spinach_Order_Click(object sender, EventArgs e)
        {
            if (CB_Spinach_Size.Text == "- Size -" || CB_Spinach_Crust.Text == "- Crust -" || CB_Spinach_Toppings.Text == "- Toppings -")
            {
                MessageBox.Show("Please Select From All Options");
                return;
            }
            ListViewItem item = new ListViewItem("700");
            item.SubItems.Add("Spinach");
            item.SubItems.Add(Utilities.getName(CB_Spinach_Size));
            item.SubItems.Add(Utilities.getName(CB_Spinach_Crust));
            item.SubItems.Add(Utilities.getName(CB_Spinach_Toppings));
            item.SubItems.Add(LBL_Spinach_Price.Text);
            LV_Cart.Items.Add(item);

            Double.TryParse(Utilities.getLabelPrice(LBL_Spinach_Price), out double temp);
            Subtotal += temp;
            LBL_Order_Subtotal.Text = $"${Subtotal}";
            PB_Order_Notify.Visible = true;
            MessageBox.Show("Spinach-Artichoke Pizza added to Order!\n\nGo to 'Your Order' to Checkout ...");
        }

        private void BTN_Potato_Order_Click(object sender, EventArgs e)
        {
            if (CB_Potato_Size.Text == "- Size -" || CB_Potato_Crust.Text == "- Crust -" || CB_Potato_Toppings.Text == "- Toppings -")
            {
                MessageBox.Show("Please Select From All Options");
                return;
            }
            ListViewItem item = new ListViewItem("800");
            item.SubItems.Add("Potato");
            item.SubItems.Add(Utilities.getName(CB_Potato_Size));
            item.SubItems.Add(Utilities.getName(CB_Potato_Crust));
            item.SubItems.Add(Utilities.getName(CB_Potato_Toppings));
            item.SubItems.Add(LBL_Potato_Price.Text);
            LV_Cart.Items.Add(item);

            Double.TryParse(Utilities.getLabelPrice(LBL_Potato_Price), out double temp);
            Subtotal += temp;
            LBL_Order_Subtotal.Text = $"${Subtotal}";
            PB_Order_Notify.Visible = true;
            MessageBox.Show("Baked-Potato Pizza added to Order!\n\nGo to 'Your Order' to Checkout ...");
        }

        private void BTN_LV_RemoveItem(object sender, EventArgs e)
        {
            double Total = 0.00;

            foreach (ListViewItem eachItem in LV_Cart.SelectedItems)
            {
                string line = eachItem.SubItems[5].Text;
                string[] split = line.Split('$');
                Double.TryParse(split[1], out double temp);
                Total += temp;
                LV_Cart.Items.Remove(eachItem);
            }

            Subtotal -= Total;
            LBL_Order_Subtotal.Text = $"${Subtotal}";
        }

        private void BTN_LV_AddMore(object sender, EventArgs e)
        {
            TC_Navigation.SelectedIndex = 0;
            Lightup_Panel_Menu.BackColor = Utilities.ACCENT_COLOR;
            Lightup_Panel_Specialties.BackColor = Utilities.SECONDARY_COLOR;
            Lightup_Panel_Custom.BackColor = Utilities.SECONDARY_COLOR;
            Lightup_Panel_Order.BackColor = Utilities.SECONDARY_COLOR;
        }

        /**
         * 
         *  Custom Order Custimization Begins here 
         * 
         **/

        private void RB_Cstm_Crust_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = ((RadioButton)sender);
            string name = rb.Name;

            if (name == "RB_Cstm_Crust_Pan")
            {
                if (rb.Checked)
                {
                    Custom.Crust = "Pan";
                    Cstm_Price += Utilities.PAN_CRUST;
                    LBL_Cstm_Price.Text = $"${Cstm_Price}";
                }
                else
                {
                    Custom.Crust = "";
                    Cstm_Price -= Utilities.PAN_CRUST;
                    LBL_Cstm_Price.Text = $"${Cstm_Price}";
                }
                Images.Remove(Utilities.CRUST_PAN);
                Images.Remove(Utilities.CRUST_HANDTOSSED);
                Images.Remove(Utilities.CRUST_THIN);
                Images.Remove(Utilities.CRUST_STUFFED);
                Images.Insert(0, Utilities.CRUST_PAN);
                CustomImage();
            }
            else if (name == "RB_Cstm_Crust_HT")
            {
                if (rb.Checked)
                {
                    Custom.Crust = "Hand Tossed";
                    Cstm_Price += Utilities.HANDTOSSED_CRUST;
                    LBL_Cstm_Price.Text = $"${Cstm_Price}";
                }
                else
                {
                    Custom.Crust = "";
                    Cstm_Price -= Utilities.HANDTOSSED_CRUST;
                    LBL_Cstm_Price.Text = $"${Cstm_Price}";
                }
                Images.Remove(Utilities.CRUST_PAN);
                Images.Remove(Utilities.CRUST_HANDTOSSED);
                Images.Remove(Utilities.CRUST_THIN);
                Images.Remove(Utilities.CRUST_STUFFED);
                Images.Insert(0, Utilities.CRUST_HANDTOSSED);
                CustomImage();
            }
            else if (name == "RB_Cstm_Crust_Thin")
            {
                if (rb.Checked)
                {
                    Custom.Crust = "Thin";
                    Cstm_Price += Utilities.THINNCRISPY_CRUST;
                    LBL_Cstm_Price.Text = $"${Cstm_Price}";
                }
                else
                {
                    Custom.Crust = "";
                    Cstm_Price -= Utilities.THINNCRISPY_CRUST;
                    LBL_Cstm_Price.Text = $"${Cstm_Price}";
                }
                Images.Remove(Utilities.CRUST_PAN);
                Images.Remove(Utilities.CRUST_HANDTOSSED);
                Images.Remove(Utilities.CRUST_THIN);
                Images.Remove(Utilities.CRUST_STUFFED);
                Images.Insert(0, Utilities.CRUST_THIN);
                CustomImage();
            }
            else if (name == "RB_Cstm_Crust_Stuffed")
            {
                if (rb.Checked)
                {
                    Custom.Crust = "Stuffed";
                    Cstm_Price += Utilities.STUFFED_CRUST;
                    LBL_Cstm_Price.Text = $"${Cstm_Price}";
                }
                else
                {
                    Custom.Crust = "";
                    Cstm_Price -= Utilities.STUFFED_CRUST;
                    LBL_Cstm_Price.Text = $"${Cstm_Price}";
                }
                Images.Remove(Utilities.CRUST_PAN);
                Images.Remove(Utilities.CRUST_HANDTOSSED);
                Images.Remove(Utilities.CRUST_THIN);
                Images.Remove(Utilities.CRUST_STUFFED);
                Images.Insert(0, Utilities.CRUST_STUFFED);
                CustomImage();
            }
        }

        private void RB_Cstm_Size_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = ((RadioButton)sender);
            string name = rb.Name;

            if (name == "RB_Cstm_Size_Small")
            {
                if (rb.Checked)
                {
                    Custom.Size = "Small";
                    Cstm_Price += Utilities.SMALL_PIZZA;
                    LBL_Cstm_Price.Text = $"${Cstm_Price}";
                }
                else
                {
                    Custom.Size = "";
                    Cstm_Price -= Utilities.SMALL_PIZZA;
                    LBL_Cstm_Price.Text = $"${Cstm_Price}";
                }
            }
            else if (name == "RB_Cstm_Size_Med")
            {
                if (rb.Checked)
                {
                    Custom.Size = "Med";
                    Cstm_Price += Utilities.MEDIUM_PIZZA;
                    LBL_Cstm_Price.Text = $"${Cstm_Price}";
                }
                else
                {
                    Custom.Size = "";
                    Cstm_Price -= Utilities.MEDIUM_PIZZA;
                    LBL_Cstm_Price.Text = $"${Cstm_Price}";
                }
            }
            else if (name == "RB_Cstm_Size_Large")
            {
                if (rb.Checked)
                {
                    Custom.Size = "Large";
                    Cstm_Price += Utilities.LARGE_PIZZA;
                    LBL_Cstm_Price.Text = $"${Cstm_Price}";
                }
                else
                {
                    Custom.Size = "";
                    Cstm_Price -= Utilities.LARGE_PIZZA;
                    LBL_Cstm_Price.Text = $"${Cstm_Price}";
                }
            }
        }

        private void CB_Cstm_Pepperoni_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = ((CheckBox)sender);
            RB_Cstm_Pepperoni_reg.Checked = true;

            if (cb.Checked)
            {
                Custom.Pepperoni = true;
                Images.Add(Utilities.TOP_PEPPERONI_L);
                Images.Add(Utilities.TOP_PEPPERONI_R);
                CustomImage();
                RB_Cstm_Pepperoni_reg.Enabled = true;
                RB_Cstm_Pepperoni_Extra.Enabled = true;
                PB_Cstm_Pepperoni_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED;
                PB_Cstm_Pepperoni_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Pepperoni_R.Image = Utilities.PIZZA_RIGHT;
                Cstm_Price += Utilities.PEPPORONI;
                LBL_Cstm_Price.Text = $"${Cstm_Price}";
            }
            else
            {
                Custom.Pepperoni = false;
                Images.Remove(Utilities.TOP_PEPPERONI_L);
                Images.Remove(Utilities.TOP_PEPPERONI_R);
                Images.Remove(Utilities.TOP_PEPPERONI_X_L);
                Images.Remove(Utilities.TOP_PEPPERONI_X_R);
                CustomImage();
                RB_Cstm_Pepperoni_reg.Enabled = false;
                RB_Cstm_Pepperoni_Extra.Enabled = false;
                PB_Cstm_Pepperoni_Whole.Image = Utilities.PIZZA_WHOLE;
                PB_Cstm_Pepperoni_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Pepperoni_R.Image = Utilities.PIZZA_RIGHT;
                Cstm_Price -= Utilities.PEPPORONI;
                LBL_Cstm_Price.Text = $"${Cstm_Price}";
            }
        }

        private void RB_Cstm_Pepperoni_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = ((RadioButton)sender);
            string name = rb.Name;

            if (name == "RB_Cstm_Pepperoni_reg")
            {
                if (rb.Checked)
                {
                    if (PB_Cstm_Pepperoni_L.Image == Utilities.PIZZA_LEFT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_PEPPERONI_L);
                        Images.Remove(Utilities.TOP_PEPPERONI_X_L);
                        Images.Remove(Utilities.TOP_PEPPERONI_R);
                        Images.Remove(Utilities.TOP_PEPPERONI_X_R);
                        Images.Add(Utilities.TOP_PEPPERONI_L);
                        CustomImage();
                    }
                    else if (PB_Cstm_Pepperoni_R.Image == Utilities.PIZZA_RIGHT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_PEPPERONI_L);
                        Images.Remove(Utilities.TOP_PEPPERONI_X_L);
                        Images.Remove(Utilities.TOP_PEPPERONI_R);
                        Images.Remove(Utilities.TOP_PEPPERONI_X_R);
                        Images.Add(Utilities.TOP_PEPPERONI_R);
                        CustomImage();
                    }
                    else
                    {
                        Images.Remove(Utilities.TOP_PEPPERONI_L);
                        Images.Remove(Utilities.TOP_PEPPERONI_X_L);
                        Images.Remove(Utilities.TOP_PEPPERONI_R);
                        Images.Remove(Utilities.TOP_PEPPERONI_X_R);
                        Images.Add(Utilities.TOP_PEPPERONI_L);
                        Images.Add(Utilities.TOP_PEPPERONI_R);
                        CustomImage();
                    }
                }
                else
                {
                    if (PB_Cstm_Pepperoni_L.Image == Utilities.PIZZA_LEFT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_PEPPERONI_L);
                        Images.Remove(Utilities.TOP_PEPPERONI_X_L);
                        Images.Remove(Utilities.TOP_PEPPERONI_R);
                        Images.Remove(Utilities.TOP_PEPPERONI_X_R);
                        Images.Add(Utilities.TOP_PEPPERONI_X_L);
                        CustomImage();
                    }
                    else if (PB_Cstm_Pepperoni_R.Image == Utilities.PIZZA_RIGHT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_PEPPERONI_L);
                        Images.Remove(Utilities.TOP_PEPPERONI_X_L);
                        Images.Remove(Utilities.TOP_PEPPERONI_R);
                        Images.Remove(Utilities.TOP_PEPPERONI_X_R);
                        Images.Add(Utilities.TOP_PEPPERONI_X_R);
                        CustomImage();
                    }
                    else
                    {
                        Images.Remove(Utilities.TOP_PEPPERONI_L);
                        Images.Remove(Utilities.TOP_PEPPERONI_X_L);
                        Images.Remove(Utilities.TOP_PEPPERONI_R);
                        Images.Remove(Utilities.TOP_PEPPERONI_X_R);
                        Images.Add(Utilities.TOP_PEPPERONI_X_L);
                        Images.Add(Utilities.TOP_PEPPERONI_X_R);
                        CustomImage();
                    }
                }
            }
        }

        private void PB_Cstm_Pepperoni_Whole_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Pepperoni.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Pepperoni_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED;
                PB_Cstm_Pepperoni_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Pepperoni_R.Image = Utilities.PIZZA_RIGHT;

                if (RB_Cstm_Pepperoni_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_PEPPERONI_L);
                    Images.Remove(Utilities.TOP_PEPPERONI_X_L);
                    Images.Remove(Utilities.TOP_PEPPERONI_R);
                    Images.Remove(Utilities.TOP_PEPPERONI_X_R);
                    Images.Add(Utilities.TOP_PEPPERONI_X_L);
                    Images.Add(Utilities.TOP_PEPPERONI_X_R);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_PEPPERONI_L);
                    Images.Remove(Utilities.TOP_PEPPERONI_X_L);
                    Images.Remove(Utilities.TOP_PEPPERONI_R);
                    Images.Remove(Utilities.TOP_PEPPERONI_X_R);
                    Images.Add(Utilities.TOP_PEPPERONI_L);
                    Images.Add(Utilities.TOP_PEPPERONI_R);
                    CustomImage();
                }
            }
        }

        private void PB_Cstm_Pepperoni_R_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Pepperoni.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Pepperoni_R.Image = Utilities.PIZZA_RIGHT_SELECTED;
                PB_Cstm_Pepperoni_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Pepperoni_Whole.Image = Utilities.PIZZA_WHOLE;

                if (RB_Cstm_Pepperoni_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_PEPPERONI_L);
                    Images.Remove(Utilities.TOP_PEPPERONI_X_L);
                    Images.Remove(Utilities.TOP_PEPPERONI_R);
                    Images.Remove(Utilities.TOP_PEPPERONI_X_R);
                    Images.Add(Utilities.TOP_PEPPERONI_X_R);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_PEPPERONI_L);
                    Images.Remove(Utilities.TOP_PEPPERONI_X_L);
                    Images.Remove(Utilities.TOP_PEPPERONI_R);
                    Images.Remove(Utilities.TOP_PEPPERONI_X_R);
                    Images.Add(Utilities.TOP_PEPPERONI_R);
                    CustomImage();
                }
            }
        }

        private void PB_Cstm_Pepperoni_L_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Pepperoni.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Pepperoni_R.Image = Utilities.PIZZA_RIGHT;
                PB_Cstm_Pepperoni_L.Image = Utilities.PIZZA_LEFT_SELECTED;
                PB_Cstm_Pepperoni_Whole.Image = Utilities.PIZZA_WHOLE;

                if (RB_Cstm_Pepperoni_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_PEPPERONI_L);
                    Images.Remove(Utilities.TOP_PEPPERONI_X_L);
                    Images.Remove(Utilities.TOP_PEPPERONI_R);
                    Images.Remove(Utilities.TOP_PEPPERONI_X_R);
                    Images.Add(Utilities.TOP_PEPPERONI_X_L);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_PEPPERONI_L);
                    Images.Remove(Utilities.TOP_PEPPERONI_X_L);
                    Images.Remove(Utilities.TOP_PEPPERONI_R);
                    Images.Remove(Utilities.TOP_PEPPERONI_X_R);
                    Images.Add(Utilities.TOP_PEPPERONI_L);
                    CustomImage();
                }
            }
        }

        private void CB_Cstm_Sausage_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = ((CheckBox)sender);
            RB_Cstm_Sausage_Reg.Checked = true;

            if (cb.Checked)
            {
                Custom.Sausage = true;
                Images.Add(Utilities.TOP_SAUSAGE_L);
                Images.Add(Utilities.TOP_SAUSAGE_R);
                CustomImage();
                RB_Cstm_Sausage_Reg.Enabled = true;
                RB_Cstm_Sausage_Extra.Enabled = true;
                PB_Cstm_Sausage_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED;
                PB_Cstm_Sausage_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Sausage_R.Image = Utilities.PIZZA_RIGHT;
                Cstm_Price += Utilities.SAUSAGE;
                LBL_Cstm_Price.Text = $"${Cstm_Price}";
            }
            else
            {
                Custom.Sausage = false; ;
                Images.Remove(Utilities.TOP_SAUSAGE_L);
                Images.Remove(Utilities.TOP_SAUSAGE_R);
                Images.Remove(Utilities.TOP_SAUSAGE_X_L);
                Images.Remove(Utilities.TOP_SAUSAGE_X_R);
                CustomImage();
                RB_Cstm_Sausage_Reg.Enabled = false;
                RB_Cstm_Sausage_Extra.Enabled = false;
                PB_Cstm_Sausage_Whole.Image = Utilities.PIZZA_WHOLE;
                PB_Cstm_Sausage_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Sausage_R.Image = Utilities.PIZZA_RIGHT;
                Cstm_Price -= Utilities.SAUSAGE;
                LBL_Cstm_Price.Text = $"${Cstm_Price}";
            }
        }

        private void RB_Cstm_Sausage_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = ((RadioButton)sender);
            string name = rb.Name;

            if (name == "RB_Cstm_Sausage_reg")
            {
                if (rb.Checked)
                {
                    if (PB_Cstm_Sausage_L.Image == Utilities.PIZZA_LEFT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_SAUSAGE_L);
                        Images.Remove(Utilities.TOP_SAUSAGE_X_L);
                        Images.Remove(Utilities.TOP_SAUSAGE_R);
                        Images.Remove(Utilities.TOP_SAUSAGE_X_R);
                        Images.Add(Utilities.TOP_SAUSAGE_L);
                        CustomImage();
                    }
                    else if (PB_Cstm_Sausage_R.Image == Utilities.PIZZA_RIGHT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_SAUSAGE_L);
                        Images.Remove(Utilities.TOP_SAUSAGE_X_L);
                        Images.Remove(Utilities.TOP_SAUSAGE_R);
                        Images.Remove(Utilities.TOP_SAUSAGE_X_R);
                        Images.Add(Utilities.TOP_SAUSAGE_R);
                        CustomImage();
                    }
                    else
                    {
                        Images.Remove(Utilities.TOP_SAUSAGE_L);
                        Images.Remove(Utilities.TOP_SAUSAGE_X_L);
                        Images.Remove(Utilities.TOP_SAUSAGE_R);
                        Images.Remove(Utilities.TOP_SAUSAGE_X_R);
                        Images.Add(Utilities.TOP_SAUSAGE_L);
                        Images.Add(Utilities.TOP_SAUSAGE_R);
                        CustomImage();
                    }
                }
                else
                {
                    if (PB_Cstm_Sausage_L.Image == Utilities.PIZZA_LEFT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_SAUSAGE_L);
                        Images.Remove(Utilities.TOP_SAUSAGE_X_L);
                        Images.Remove(Utilities.TOP_SAUSAGE_R);
                        Images.Remove(Utilities.TOP_SAUSAGE_X_R);
                        Images.Add(Utilities.TOP_SAUSAGE_X_L);
                        CustomImage();
                    }
                    else if (PB_Cstm_Sausage_R.Image == Utilities.PIZZA_RIGHT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_SAUSAGE_L);
                        Images.Remove(Utilities.TOP_SAUSAGE_X_L);
                        Images.Remove(Utilities.TOP_SAUSAGE_R);
                        Images.Remove(Utilities.TOP_SAUSAGE_X_R);
                        Images.Add(Utilities.TOP_SAUSAGE_X_R);
                        CustomImage();
                    }
                    else
                    {
                        Images.Remove(Utilities.TOP_SAUSAGE_L);
                        Images.Remove(Utilities.TOP_SAUSAGE_X_L);
                        Images.Remove(Utilities.TOP_SAUSAGE_R);
                        Images.Remove(Utilities.TOP_SAUSAGE_X_R);
                        Images.Add(Utilities.TOP_SAUSAGE_X_L);
                        Images.Add(Utilities.TOP_SAUSAGE_X_R);
                        CustomImage();
                    }
                }
            }
        }

        private void PB_Cstm_Sausage_Whole_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Sausage.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Sausage_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED;
                PB_Cstm_Sausage_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Sausage_R.Image = Utilities.PIZZA_RIGHT;

                if (RB_Cstm_Pepperoni_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_SAUSAGE_L);
                    Images.Remove(Utilities.TOP_SAUSAGE_X_L);
                    Images.Remove(Utilities.TOP_SAUSAGE_R);
                    Images.Remove(Utilities.TOP_SAUSAGE_X_R);
                    Images.Add(Utilities.TOP_SAUSAGE_X_L);
                    Images.Add(Utilities.TOP_SAUSAGE_X_R);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_SAUSAGE_L);
                    Images.Remove(Utilities.TOP_SAUSAGE_X_L);
                    Images.Remove(Utilities.TOP_SAUSAGE_R);
                    Images.Remove(Utilities.TOP_SAUSAGE_X_R);
                    Images.Add(Utilities.TOP_SAUSAGE_L);
                    Images.Add(Utilities.TOP_SAUSAGE_R);
                    CustomImage();
                }
            }
        }

        private void PB_Cstm_Sausage_R_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Sausage.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Sausage_R.Image = Utilities.PIZZA_RIGHT_SELECTED;
                PB_Cstm_Sausage_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Sausage_Whole.Image = Utilities.PIZZA_WHOLE;

                if (RB_Cstm_Pepperoni_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_SAUSAGE_L);
                    Images.Remove(Utilities.TOP_SAUSAGE_X_L);
                    Images.Remove(Utilities.TOP_SAUSAGE_R);
                    Images.Remove(Utilities.TOP_SAUSAGE_X_R);
                    Images.Add(Utilities.TOP_SAUSAGE_X_R);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_SAUSAGE_L);
                    Images.Remove(Utilities.TOP_SAUSAGE_X_L);
                    Images.Remove(Utilities.TOP_SAUSAGE_R);
                    Images.Remove(Utilities.TOP_SAUSAGE_X_R);
                    Images.Add(Utilities.TOP_SAUSAGE_R);
                    CustomImage();
                }
            }
        }

        private void PB_Cstm_Sausage_L_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Sausage.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Sausage_R.Image = Utilities.PIZZA_RIGHT;
                PB_Cstm_Sausage_L.Image = Utilities.PIZZA_LEFT_SELECTED;
                PB_Cstm_Sausage_Whole.Image = Utilities.PIZZA_WHOLE;

                if (RB_Cstm_Sausage_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_SAUSAGE_L);
                    Images.Remove(Utilities.TOP_SAUSAGE_X_L);
                    Images.Remove(Utilities.TOP_SAUSAGE_R);
                    Images.Remove(Utilities.TOP_SAUSAGE_X_R);
                    Images.Add(Utilities.TOP_SAUSAGE_X_L);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_SAUSAGE_L);
                    Images.Remove(Utilities.TOP_SAUSAGE_X_L);
                    Images.Remove(Utilities.TOP_SAUSAGE_R);
                    Images.Remove(Utilities.TOP_SAUSAGE_X_R);
                    Images.Add(Utilities.TOP_SAUSAGE_L);
                    CustomImage();
                }
            }
        }

        private void CB_Cstm_Ham_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = ((CheckBox)sender);
            RB_Cstm_Ham_Reg.Checked = true;

            if (cb.Checked)
            {
                Custom.Ham = true;
                Images.Add(Utilities.TOP_HAM_L);
                Images.Add(Utilities.TOP_HAM_R);
                CustomImage();
                RB_Cstm_Ham_Reg.Enabled = true;
                RB_Cstm_Ham_Extra.Enabled = true;
                PB_Cstm_Ham_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED;
                PB_Cstm_Ham_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Ham_R.Image = Utilities.PIZZA_RIGHT;
                Cstm_Price += Utilities.HAM;
                LBL_Cstm_Price.Text = $"${Cstm_Price}";
            }
            else
            {
                Custom.Ham = false;
                Images.Remove(Utilities.TOP_HAM_L);
                Images.Remove(Utilities.TOP_HAM_R);
                Images.Remove(Utilities.TOP_HAM_X_L);
                Images.Remove(Utilities.TOP_HAM_X_R);
                CustomImage();
                RB_Cstm_Ham_Reg.Enabled = false;
                RB_Cstm_Ham_Extra.Enabled = false;
                PB_Cstm_Ham_Whole.Image = Utilities.PIZZA_WHOLE;
                PB_Cstm_Ham_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Ham_R.Image = Utilities.PIZZA_RIGHT;
                Cstm_Price -= Utilities.HAM;
                LBL_Cstm_Price.Text = $"${Cstm_Price}";
            }
        }

        private void RB_Cstm_Ham_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = ((RadioButton)sender);
            string name = rb.Name;

            if (name == "RB_Cstm_Ham_reg")
            {
                if (rb.Checked)
                {
                    if (PB_Cstm_Ham_L.Image == Utilities.PIZZA_LEFT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_HAM_L);
                        Images.Remove(Utilities.TOP_HAM_X_L);
                        Images.Remove(Utilities.TOP_HAM_R);
                        Images.Remove(Utilities.TOP_HAM_X_R);
                        Images.Add(Utilities.TOP_HAM_L);
                        CustomImage();
                    }
                    else if (PB_Cstm_Ham_R.Image == Utilities.PIZZA_RIGHT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_HAM_L);
                        Images.Remove(Utilities.TOP_HAM_X_L);
                        Images.Remove(Utilities.TOP_HAM_R);
                        Images.Remove(Utilities.TOP_HAM_X_R);
                        Images.Add(Utilities.TOP_HAM_R);
                        CustomImage();
                    }
                    else
                    {
                        Images.Remove(Utilities.TOP_HAM_L);
                        Images.Remove(Utilities.TOP_HAM_X_L);
                        Images.Remove(Utilities.TOP_HAM_R);
                        Images.Remove(Utilities.TOP_HAM_X_R);
                        Images.Add(Utilities.TOP_HAM_L);
                        Images.Add(Utilities.TOP_HAM_R);
                        CustomImage();
                    }
                }
                else
                {
                    if (PB_Cstm_Ham_L.Image == Utilities.PIZZA_LEFT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_HAM_L);
                        Images.Remove(Utilities.TOP_HAM_X_L);
                        Images.Remove(Utilities.TOP_HAM_R);
                        Images.Remove(Utilities.TOP_HAM_X_R);
                        Images.Add(Utilities.TOP_HAM_X_L);
                        CustomImage();
                    }
                    else if (PB_Cstm_Ham_R.Image == Utilities.PIZZA_RIGHT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_HAM_L);
                        Images.Remove(Utilities.TOP_HAM_X_L);
                        Images.Remove(Utilities.TOP_HAM_R);
                        Images.Remove(Utilities.TOP_HAM_X_R);
                        Images.Add(Utilities.TOP_HAM_X_R);
                        CustomImage();
                    }
                    else
                    {
                        Images.Remove(Utilities.TOP_HAM_L);
                        Images.Remove(Utilities.TOP_HAM_X_L);
                        Images.Remove(Utilities.TOP_HAM_R);
                        Images.Remove(Utilities.TOP_HAM_X_R);
                        Images.Add(Utilities.TOP_HAM_X_L);
                        Images.Add(Utilities.TOP_HAM_X_R);
                        CustomImage();
                    }
                }
            }
        }

        private void PB_Cstm_Ham_Whole_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Ham.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Ham_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED;
                PB_Cstm_Ham_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Ham_R.Image = Utilities.PIZZA_RIGHT;

                if (RB_Cstm_Pepperoni_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_HAM_L);
                    Images.Remove(Utilities.TOP_HAM_X_L);
                    Images.Remove(Utilities.TOP_HAM_R);
                    Images.Remove(Utilities.TOP_HAM_X_R);
                    Images.Add(Utilities.TOP_HAM_X_L);
                    Images.Add(Utilities.TOP_HAM_X_R);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_HAM_L);
                    Images.Remove(Utilities.TOP_HAM_X_L);
                    Images.Remove(Utilities.TOP_HAM_R);
                    Images.Remove(Utilities.TOP_HAM_X_R);
                    Images.Add(Utilities.TOP_HAM_L);
                    Images.Add(Utilities.TOP_HAM_R);
                    CustomImage();
                }
            }
        }

        private void PB_Cstm_Ham_R_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Ham.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Ham_R.Image = Utilities.PIZZA_RIGHT_SELECTED;
                PB_Cstm_Ham_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Ham_Whole.Image = Utilities.PIZZA_WHOLE;

                if (RB_Cstm_Pepperoni_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_HAM_L);
                    Images.Remove(Utilities.TOP_HAM_X_L);
                    Images.Remove(Utilities.TOP_HAM_R);
                    Images.Remove(Utilities.TOP_HAM_X_R);
                    Images.Add(Utilities.TOP_HAM_X_R);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_HAM_L);
                    Images.Remove(Utilities.TOP_HAM_X_L);
                    Images.Remove(Utilities.TOP_HAM_R);
                    Images.Remove(Utilities.TOP_HAM_X_R);
                    Images.Add(Utilities.TOP_HAM_R);
                    CustomImage();
                }
            }
        }

        private void PB_Cstm_Ham_L_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Ham.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Ham_R.Image = Utilities.PIZZA_RIGHT;
                PB_Cstm_Ham_L.Image = Utilities.PIZZA_LEFT_SELECTED;
                PB_Cstm_Ham_Whole.Image = Utilities.PIZZA_WHOLE;

                if (RB_Cstm_Ham_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_HAM_L);
                    Images.Remove(Utilities.TOP_HAM_X_L);
                    Images.Remove(Utilities.TOP_HAM_R);
                    Images.Remove(Utilities.TOP_HAM_X_R);
                    Images.Add(Utilities.TOP_HAM_X_L);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_HAM_L);
                    Images.Remove(Utilities.TOP_HAM_X_L);
                    Images.Remove(Utilities.TOP_HAM_R);
                    Images.Remove(Utilities.TOP_HAM_X_R);
                    Images.Add(Utilities.TOP_HAM_L);
                    CustomImage();
                }
            }
        }

        private void CB_Cstm_Bacon_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = ((CheckBox)sender);
            RB_Cstm_Bacon_Reg.Checked = true;

            if (cb.Checked)
            {
                Custom.Bacon = true;
                Images.Add(Utilities.TOP_BACON_L);
                Images.Add(Utilities.TOP_BACON_R);
                CustomImage();
                RB_Cstm_Bacon_Reg.Enabled = true;
                RB_Cstm_Bacon_Extra.Enabled = true;
                PB_Cstm_Bacon_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED;
                PB_Cstm_Bacon_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Bacon_R.Image = Utilities.PIZZA_RIGHT;
                Cstm_Price += Utilities.BACON;
                LBL_Cstm_Price.Text = $"${Cstm_Price}";
            }
            else
            {
                Custom.Bacon = false;
                Images.Remove(Utilities.TOP_BACON_L);
                Images.Remove(Utilities.TOP_BACON_R);
                Images.Remove(Utilities.TOP_BACON_X_L);
                Images.Remove(Utilities.TOP_BACON_X_R);
                CustomImage();
                RB_Cstm_Bacon_Reg.Enabled = false;
                RB_Cstm_Bacon_Extra.Enabled = false;
                PB_Cstm_Bacon_Whole.Image = Utilities.PIZZA_WHOLE;
                PB_Cstm_Bacon_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Bacon_R.Image = Utilities.PIZZA_RIGHT;
                Cstm_Price -= Utilities.BACON;
                LBL_Cstm_Price.Text = $"${Cstm_Price}";
            }
        }

        private void RB_Cstm_Bacon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = ((RadioButton)sender);
            string name = rb.Name;

            if (name == "RB_Cstm_Bacon_reg")
            {
                if (rb.Checked)
                {
                    if (PB_Cstm_Bacon_L.Image == Utilities.PIZZA_LEFT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_BACON_L);
                        Images.Remove(Utilities.TOP_BACON_X_L);
                        Images.Remove(Utilities.TOP_BACON_R);
                        Images.Remove(Utilities.TOP_BACON_X_R);
                        Images.Add(Utilities.TOP_BACON_L);
                        CustomImage();
                    }
                    else if (PB_Cstm_Bacon_R.Image == Utilities.PIZZA_RIGHT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_BACON_L);
                        Images.Remove(Utilities.TOP_BACON_X_L);
                        Images.Remove(Utilities.TOP_BACON_R);
                        Images.Remove(Utilities.TOP_BACON_X_R);
                        Images.Add(Utilities.TOP_BACON_R);
                        CustomImage();
                    }
                    else
                    {
                        Images.Remove(Utilities.TOP_BACON_L);
                        Images.Remove(Utilities.TOP_BACON_X_L);
                        Images.Remove(Utilities.TOP_BACON_R);
                        Images.Remove(Utilities.TOP_BACON_X_R);
                        Images.Add(Utilities.TOP_BACON_L);
                        Images.Add(Utilities.TOP_BACON_R);
                        CustomImage();
                    }
                }
                else
                {
                    if (PB_Cstm_Bacon_L.Image == Utilities.PIZZA_LEFT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_BACON_L);
                        Images.Remove(Utilities.TOP_BACON_X_L);
                        Images.Remove(Utilities.TOP_BACON_R);
                        Images.Remove(Utilities.TOP_BACON_X_R);
                        Images.Add(Utilities.TOP_BACON_X_L);
                        CustomImage();
                    }
                    else if (PB_Cstm_Bacon_R.Image == Utilities.PIZZA_RIGHT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_BACON_L);
                        Images.Remove(Utilities.TOP_BACON_X_L);
                        Images.Remove(Utilities.TOP_BACON_R);
                        Images.Remove(Utilities.TOP_BACON_X_R);
                        Images.Add(Utilities.TOP_BACON_X_R);
                        CustomImage();
                    }
                    else
                    {
                        Images.Remove(Utilities.TOP_BACON_L);
                        Images.Remove(Utilities.TOP_BACON_X_L);
                        Images.Remove(Utilities.TOP_BACON_R);
                        Images.Remove(Utilities.TOP_BACON_X_R);
                        Images.Add(Utilities.TOP_BACON_X_L);
                        Images.Add(Utilities.TOP_BACON_X_R);
                        CustomImage();
                    }
                }
            }
        }

        private void PB_Cstm_Bacon_Whole_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Bacon.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Bacon_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED;
                PB_Cstm_Bacon_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Bacon_R.Image = Utilities.PIZZA_RIGHT;

                if (RB_Cstm_Bacon_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_BACON_L);
                    Images.Remove(Utilities.TOP_BACON_X_L);
                    Images.Remove(Utilities.TOP_BACON_R);
                    Images.Remove(Utilities.TOP_BACON_X_R);
                    Images.Add(Utilities.TOP_BACON_X_L);
                    Images.Add(Utilities.TOP_BACON_X_R);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_BACON_L);
                    Images.Remove(Utilities.TOP_BACON_X_L);
                    Images.Remove(Utilities.TOP_BACON_R);
                    Images.Remove(Utilities.TOP_BACON_X_R);
                    Images.Add(Utilities.TOP_BACON_L);
                    Images.Add(Utilities.TOP_BACON_R);
                    CustomImage();
                }
            }
        }

        private void PB_Cstm_Bacon_R_Click(object sender, EventArgs e)
        {
            if (RB_Cstm_Bacon_Extra.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Bacon_R.Image = Utilities.PIZZA_RIGHT_SELECTED;
                PB_Cstm_Bacon_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Bacon_Whole.Image = Utilities.PIZZA_WHOLE;

                if (RB_Cstm_Bacon_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_BACON_L);
                    Images.Remove(Utilities.TOP_BACON_X_L);
                    Images.Remove(Utilities.TOP_BACON_R);
                    Images.Remove(Utilities.TOP_BACON_X_R);
                    Images.Add(Utilities.TOP_BACON_X_R);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_BACON_L);
                    Images.Remove(Utilities.TOP_BACON_X_L);
                    Images.Remove(Utilities.TOP_BACON_R);
                    Images.Remove(Utilities.TOP_BACON_X_R);
                    Images.Add(Utilities.TOP_BACON_R);
                    CustomImage();
                }
            }
        }

        private void PB_Cstm_Bacon_L_Click(object sender, EventArgs e)
        {
            if (RB_Cstm_Bacon_Extra.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Bacon_R.Image = Utilities.PIZZA_RIGHT;
                PB_Cstm_Bacon_L.Image = Utilities.PIZZA_LEFT_SELECTED;
                PB_Cstm_Bacon_Whole.Image = Utilities.PIZZA_WHOLE;

                if (RB_Cstm_Bacon_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_BACON_L);
                    Images.Remove(Utilities.TOP_BACON_X_L);
                    Images.Remove(Utilities.TOP_BACON_R);
                    Images.Remove(Utilities.TOP_BACON_X_R);
                    Images.Add(Utilities.TOP_BACON_X_L);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_BACON_L);
                    Images.Remove(Utilities.TOP_BACON_X_L);
                    Images.Remove(Utilities.TOP_BACON_R);
                    Images.Remove(Utilities.TOP_BACON_X_R);
                    Images.Add(Utilities.TOP_BACON_L);
                    CustomImage();
                }
            }
        }

        private void CB_Cstm_Mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = ((CheckBox)sender);
            RB_Cstm_Mushrooms_Reg.Checked = true;

            if (cb.Checked)
            {
                Custom.Mushrooms = true;
                Images.Add(Utilities.TOP_MUSHROOM_L);
                Images.Add(Utilities.TOP_MUSHROOM_R);
                CustomImage();
                RB_Cstm_Mushrooms_Reg.Enabled = true;
                RB_Cstm_Mushrooms_Extra.Enabled = true;
                PB_Cstm_Mushrooms_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED;
                PB_Cstm_Mushrooms_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Mushrooms_R.Image = Utilities.PIZZA_RIGHT;
                Cstm_Price += Utilities.MUSHROOMS;
                LBL_Cstm_Price.Text = $"${Cstm_Price}";
            }
            else
            {
                Custom.Mushrooms = false;
                Images.Remove(Utilities.TOP_MUSHROOM_L);
                Images.Remove(Utilities.TOP_MUSHROOM_R);
                Images.Remove(Utilities.TOP_MUSHROOM_X_L);
                Images.Remove(Utilities.TOP_MUSHROOM_X_R);
                CustomImage();
                RB_Cstm_Mushrooms_Reg.Enabled = false;
                RB_Cstm_Mushrooms_Extra.Enabled = false;
                PB_Cstm_Mushrooms_Whole.Image = Utilities.PIZZA_WHOLE;
                PB_Cstm_Mushrooms_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Mushrooms_R.Image = Utilities.PIZZA_RIGHT;
                Cstm_Price -= Utilities.MUSHROOMS;
                LBL_Cstm_Price.Text = $"${Cstm_Price}";
            }
        }

        private void RB_Cstm_Mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = ((RadioButton)sender);
            string name = rb.Name;

            if (name == "RB_Cstm_Mushrooms_reg")
            {
                if (rb.Checked)
                {
                    if (PB_Cstm_Mushrooms_L.Image == Utilities.PIZZA_LEFT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_MUSHROOM_L);
                        Images.Remove(Utilities.TOP_MUSHROOM_X_L);
                        Images.Remove(Utilities.TOP_MUSHROOM_R);
                        Images.Remove(Utilities.TOP_MUSHROOM_X_R);
                        Images.Add(Utilities.TOP_MUSHROOM_L);
                        CustomImage();
                    }
                    else if (PB_Cstm_Mushrooms_R.Image == Utilities.PIZZA_RIGHT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_MUSHROOM_L);
                        Images.Remove(Utilities.TOP_MUSHROOM_X_L);
                        Images.Remove(Utilities.TOP_MUSHROOM_R);
                        Images.Remove(Utilities.TOP_MUSHROOM_X_R);
                        Images.Add(Utilities.TOP_MUSHROOM_R);
                        CustomImage();
                    }
                    else
                    {
                        Images.Remove(Utilities.TOP_MUSHROOM_L);
                        Images.Remove(Utilities.TOP_MUSHROOM_X_L);
                        Images.Remove(Utilities.TOP_MUSHROOM_R);
                        Images.Remove(Utilities.TOP_MUSHROOM_X_R);
                        Images.Add(Utilities.TOP_MUSHROOM_L);
                        Images.Add(Utilities.TOP_MUSHROOM_R);
                        CustomImage();
                    }
                }
                else
                {
                    if (PB_Cstm_Mushrooms_L.Image == Utilities.PIZZA_LEFT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_MUSHROOM_L);
                        Images.Remove(Utilities.TOP_MUSHROOM_X_L);
                        Images.Remove(Utilities.TOP_MUSHROOM_R);
                        Images.Remove(Utilities.TOP_MUSHROOM_X_R);
                        Images.Add(Utilities.TOP_MUSHROOM_X_L);
                        CustomImage();
                    }
                    else if (PB_Cstm_Mushrooms_R.Image == Utilities.PIZZA_RIGHT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_MUSHROOM_L);
                        Images.Remove(Utilities.TOP_MUSHROOM_X_L);
                        Images.Remove(Utilities.TOP_MUSHROOM_R);
                        Images.Remove(Utilities.TOP_MUSHROOM_X_R);
                        Images.Add(Utilities.TOP_MUSHROOM_X_R);
                        CustomImage();
                    }
                    else
                    {
                        Images.Remove(Utilities.TOP_MUSHROOM_L);
                        Images.Remove(Utilities.TOP_MUSHROOM_X_L);
                        Images.Remove(Utilities.TOP_MUSHROOM_R);
                        Images.Remove(Utilities.TOP_MUSHROOM_X_R);
                        Images.Add(Utilities.TOP_MUSHROOM_X_L);
                        Images.Add(Utilities.TOP_MUSHROOM_X_R);
                        CustomImage();
                    }
                }
            }
        }

        private void PB_Cstm_Mushrooms_Whole_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Mushrooms.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Mushrooms_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED;
                PB_Cstm_Mushrooms_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Mushrooms_R.Image = Utilities.PIZZA_RIGHT;

                if (RB_Cstm_Pepperoni_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_MUSHROOM_L);
                    Images.Remove(Utilities.TOP_MUSHROOM_X_L);
                    Images.Remove(Utilities.TOP_MUSHROOM_R);
                    Images.Remove(Utilities.TOP_MUSHROOM_X_R);
                    Images.Add(Utilities.TOP_MUSHROOM_X_L);
                    Images.Add(Utilities.TOP_MUSHROOM_X_R);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_MUSHROOM_L);
                    Images.Remove(Utilities.TOP_MUSHROOM_X_L);
                    Images.Remove(Utilities.TOP_MUSHROOM_R);
                    Images.Remove(Utilities.TOP_MUSHROOM_X_R);
                    Images.Add(Utilities.TOP_MUSHROOM_L);
                    Images.Add(Utilities.TOP_MUSHROOM_R);
                    CustomImage();
                }
            }
        }

        private void PB_Cstm_Mushrooms_R_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Mushrooms.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Mushrooms_R.Image = Utilities.PIZZA_RIGHT_SELECTED;
                PB_Cstm_Mushrooms_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Mushrooms_Whole.Image = Utilities.PIZZA_WHOLE;

                if (RB_Cstm_Pepperoni_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_MUSHROOM_L);
                    Images.Remove(Utilities.TOP_MUSHROOM_X_L);
                    Images.Remove(Utilities.TOP_MUSHROOM_R);
                    Images.Remove(Utilities.TOP_MUSHROOM_X_R);
                    Images.Add(Utilities.TOP_MUSHROOM_X_R);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_MUSHROOM_L);
                    Images.Remove(Utilities.TOP_MUSHROOM_X_L);
                    Images.Remove(Utilities.TOP_MUSHROOM_R);
                    Images.Remove(Utilities.TOP_MUSHROOM_X_R);
                    Images.Add(Utilities.TOP_MUSHROOM_R);
                    CustomImage();
                }
            }
        }

        private void PB_Cstm_Mushrooms_L_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Mushrooms.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Mushrooms_R.Image = Utilities.PIZZA_RIGHT;
                PB_Cstm_Mushrooms_L.Image = Utilities.PIZZA_LEFT_SELECTED;
                PB_Cstm_Mushrooms_Whole.Image = Utilities.PIZZA_WHOLE;

                if (RB_Cstm_Mushrooms_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_MUSHROOM_L);
                    Images.Remove(Utilities.TOP_MUSHROOM_X_L);
                    Images.Remove(Utilities.TOP_MUSHROOM_R);
                    Images.Remove(Utilities.TOP_MUSHROOM_X_R);
                    Images.Add(Utilities.TOP_MUSHROOM_X_L);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_MUSHROOM_L);
                    Images.Remove(Utilities.TOP_MUSHROOM_X_L);
                    Images.Remove(Utilities.TOP_MUSHROOM_R);
                    Images.Remove(Utilities.TOP_MUSHROOM_X_R);
                    Images.Add(Utilities.TOP_MUSHROOM_L);
                    CustomImage();
                }
            }
        }

        private void CB_Cstm_Onions_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = ((CheckBox)sender);
            RB_Cstm_Onions_Reg.Checked = true;

            if (cb.Checked)
            {
                Custom.Onions = true;
                Images.Add(Utilities.TOP_ONION_L);
                Images.Add(Utilities.TOP_ONION_R);
                CustomImage();
                RB_Cstm_Onions_Reg.Enabled = true;
                RB_Cstm_Onions_Extra.Enabled = true;
                PB_Cstm_Onions_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED;
                PB_Cstm_Onions_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Onions_R.Image = Utilities.PIZZA_RIGHT;
                Cstm_Price += Utilities.ONIONS;
                LBL_Cstm_Price.Text = $"${Cstm_Price}";
            }
            else
            {
                Custom.Onions = false;
                Images.Remove(Utilities.TOP_ONION_L);
                Images.Remove(Utilities.TOP_ONION_R);
                Images.Remove(Utilities.TOP_ONION_X_L);
                Images.Remove(Utilities.TOP_ONION_X_R);
                CustomImage();
                RB_Cstm_Onions_Reg.Enabled = false;
                RB_Cstm_Onions_Extra.Enabled = false;
                PB_Cstm_Onions_Whole.Image = Utilities.PIZZA_WHOLE;
                PB_Cstm_Onions_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Onions_R.Image = Utilities.PIZZA_RIGHT;
                Cstm_Price -= Utilities.ONIONS;
                LBL_Cstm_Price.Text = $"${Cstm_Price}";
            }
        }

        private void RB_Cstm_Onions_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = ((RadioButton)sender);
            string name = rb.Name;

            if (name == "RB_Cstm_Onions_reg")
            {
                if (rb.Checked)
                {
                    if (PB_Cstm_Onions_L.Image == Utilities.PIZZA_LEFT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_ONION_L);
                        Images.Remove(Utilities.TOP_ONION_X_L);
                        Images.Remove(Utilities.TOP_ONION_R);
                        Images.Remove(Utilities.TOP_ONION_X_R);
                        Images.Add(Utilities.TOP_ONION_L);
                        CustomImage();
                    }
                    else if (PB_Cstm_Onions_R.Image == Utilities.PIZZA_RIGHT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_ONION_L);
                        Images.Remove(Utilities.TOP_ONION_X_L);
                        Images.Remove(Utilities.TOP_ONION_R);
                        Images.Remove(Utilities.TOP_ONION_X_R);
                        Images.Add(Utilities.TOP_ONION_R);
                        CustomImage();
                    }
                    else
                    {
                        Images.Remove(Utilities.TOP_ONION_L);
                        Images.Remove(Utilities.TOP_ONION_X_L);
                        Images.Remove(Utilities.TOP_ONION_R);
                        Images.Remove(Utilities.TOP_ONION_X_R);
                        Images.Add(Utilities.TOP_ONION_L);
                        Images.Add(Utilities.TOP_ONION_R);
                        CustomImage();
                    }
                }
                else
                {
                    if (PB_Cstm_Onions_L.Image == Utilities.PIZZA_LEFT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_ONION_L);
                        Images.Remove(Utilities.TOP_ONION_X_L);
                        Images.Remove(Utilities.TOP_ONION_R);
                        Images.Remove(Utilities.TOP_ONION_X_R);
                        Images.Add(Utilities.TOP_ONION_X_L);
                        CustomImage();
                    }
                    else if (PB_Cstm_Onions_R.Image == Utilities.PIZZA_RIGHT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_ONION_L);
                        Images.Remove(Utilities.TOP_ONION_X_L);
                        Images.Remove(Utilities.TOP_ONION_R);
                        Images.Remove(Utilities.TOP_ONION_X_R);
                        Images.Add(Utilities.TOP_ONION_X_R);
                        CustomImage();
                    }
                    else
                    {
                        Images.Remove(Utilities.TOP_ONION_L);
                        Images.Remove(Utilities.TOP_ONION_X_L);
                        Images.Remove(Utilities.TOP_ONION_R);
                        Images.Remove(Utilities.TOP_ONION_X_R);
                        Images.Add(Utilities.TOP_ONION_X_L);
                        Images.Add(Utilities.TOP_ONION_X_R);
                        CustomImage();
                    }
                }
            }
        }

        private void PB_Cstm_Onions_Whole_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Onions.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Onions_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED;
                PB_Cstm_Onions_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Onions_R.Image = Utilities.PIZZA_RIGHT;

                if (RB_Cstm_Pepperoni_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_ONION_L);
                    Images.Remove(Utilities.TOP_ONION_X_L);
                    Images.Remove(Utilities.TOP_ONION_R);
                    Images.Remove(Utilities.TOP_ONION_X_R);
                    Images.Add(Utilities.TOP_ONION_X_L);
                    Images.Add(Utilities.TOP_ONION_X_R);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_ONION_L);
                    Images.Remove(Utilities.TOP_ONION_X_L);
                    Images.Remove(Utilities.TOP_ONION_R);
                    Images.Remove(Utilities.TOP_ONION_X_R);
                    Images.Add(Utilities.TOP_ONION_L);
                    Images.Add(Utilities.TOP_ONION_R);
                    CustomImage();
                }
            }
        }

        private void PB_Cstm_Onions_R_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Onions.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Onions_R.Image = Utilities.PIZZA_RIGHT_SELECTED;
                PB_Cstm_Onions_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Onions_Whole.Image = Utilities.PIZZA_WHOLE;

                if (RB_Cstm_Pepperoni_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_ONION_L);
                    Images.Remove(Utilities.TOP_ONION_X_L);
                    Images.Remove(Utilities.TOP_ONION_R);
                    Images.Remove(Utilities.TOP_ONION_X_R);
                    Images.Add(Utilities.TOP_ONION_X_R);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_ONION_L);
                    Images.Remove(Utilities.TOP_ONION_X_L);
                    Images.Remove(Utilities.TOP_ONION_R);
                    Images.Remove(Utilities.TOP_ONION_X_R);
                    Images.Add(Utilities.TOP_ONION_R);
                    CustomImage();
                }
            }
        }

        private void PB_Cstm_Onions_L_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Onions.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Onions_R.Image = Utilities.PIZZA_RIGHT;
                PB_Cstm_Onions_L.Image = Utilities.PIZZA_LEFT_SELECTED;
                PB_Cstm_Onions_Whole.Image = Utilities.PIZZA_WHOLE;

                if (RB_Cstm_Onions_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_ONION_L);
                    Images.Remove(Utilities.TOP_ONION_X_L);
                    Images.Remove(Utilities.TOP_ONION_R);
                    Images.Remove(Utilities.TOP_ONION_X_R);
                    Images.Add(Utilities.TOP_ONION_X_L);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_ONION_L);
                    Images.Remove(Utilities.TOP_ONION_X_L);
                    Images.Remove(Utilities.TOP_ONION_R);
                    Images.Remove(Utilities.TOP_ONION_X_R);
                    Images.Add(Utilities.TOP_ONION_L);
                    CustomImage();
                }
            }
        }

        private void CB_Cstm_Olives_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = ((CheckBox)sender);
            RB_Cstm_Olives_Reg.Checked = true;

            if (cb.Checked)
            {
                Custom.Olives = true;
                Images.Add(Utilities.TOP_OLIVE_L);
                Images.Add(Utilities.TOP_OLIVE_R);
                CustomImage();
                RB_Cstm_Olives_Reg.Enabled = true;
                RB_Cstm_Olives_Extra.Enabled = true;
                PB_Cstm_Olives_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED;
                PB_Cstm_Olives_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Olives_R.Image = Utilities.PIZZA_RIGHT;
                Cstm_Price += Utilities.OLIVES;
                LBL_Cstm_Price.Text = $"${Cstm_Price}";
            }
            else
            {
                Custom.Olives = false;
                Images.Remove(Utilities.TOP_OLIVE_L);
                Images.Remove(Utilities.TOP_OLIVE_R);
                Images.Remove(Utilities.TOP_OLIVE_X_L);
                Images.Remove(Utilities.TOP_OLIVE_X_R);
                CustomImage();
                RB_Cstm_Olives_Reg.Enabled = false;
                RB_Cstm_Olives_Extra.Enabled = false;
                PB_Cstm_Olives_Whole.Image = Utilities.PIZZA_WHOLE;
                PB_Cstm_Olives_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Olives_R.Image = Utilities.PIZZA_RIGHT;
                Cstm_Price -= Utilities.OLIVES;
                LBL_Cstm_Price.Text = $"${Cstm_Price}";
            }
        }

        private void RB_Cstm_Olives_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = ((RadioButton)sender);
            string name = rb.Name;

            if (name == "RB_Cstm_Olives_reg")
            {
                if (rb.Checked)
                {
                    if (PB_Cstm_Olives_L.Image == Utilities.PIZZA_LEFT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_OLIVE_L);
                        Images.Remove(Utilities.TOP_OLIVE_X_L);
                        Images.Remove(Utilities.TOP_OLIVE_R);
                        Images.Remove(Utilities.TOP_OLIVE_X_R);
                        Images.Add(Utilities.TOP_OLIVE_L);
                        CustomImage();
                    }
                    else if (PB_Cstm_Olives_R.Image == Utilities.PIZZA_RIGHT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_OLIVE_L);
                        Images.Remove(Utilities.TOP_OLIVE_X_L);
                        Images.Remove(Utilities.TOP_OLIVE_R);
                        Images.Remove(Utilities.TOP_OLIVE_X_R);
                        Images.Add(Utilities.TOP_OLIVE_R);
                        CustomImage();
                    }
                    else
                    {
                        Images.Remove(Utilities.TOP_OLIVE_L);
                        Images.Remove(Utilities.TOP_OLIVE_X_L);
                        Images.Remove(Utilities.TOP_OLIVE_R);
                        Images.Remove(Utilities.TOP_OLIVE_X_R);
                        Images.Add(Utilities.TOP_OLIVE_L);
                        Images.Add(Utilities.TOP_OLIVE_R);
                        CustomImage();
                    }
                }
                else
                {
                    if (PB_Cstm_Olives_L.Image == Utilities.PIZZA_LEFT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_OLIVE_L);
                        Images.Remove(Utilities.TOP_OLIVE_X_L);
                        Images.Remove(Utilities.TOP_OLIVE_R);
                        Images.Remove(Utilities.TOP_OLIVE_X_R);
                        Images.Add(Utilities.TOP_OLIVE_X_L);
                        CustomImage();
                    }
                    else if (PB_Cstm_Olives_R.Image == Utilities.PIZZA_RIGHT_SELECTED)
                    {
                        Images.Remove(Utilities.TOP_OLIVE_L);
                        Images.Remove(Utilities.TOP_OLIVE_X_L);
                        Images.Remove(Utilities.TOP_OLIVE_R);
                        Images.Remove(Utilities.TOP_OLIVE_X_R);
                        Images.Add(Utilities.TOP_OLIVE_X_R);
                        CustomImage();
                    }
                    else
                    {
                        Images.Remove(Utilities.TOP_OLIVE_L);
                        Images.Remove(Utilities.TOP_OLIVE_X_L);
                        Images.Remove(Utilities.TOP_OLIVE_R);
                        Images.Remove(Utilities.TOP_OLIVE_X_R);
                        Images.Add(Utilities.TOP_OLIVE_X_L);
                        Images.Add(Utilities.TOP_OLIVE_X_R);
                        CustomImage();
                    }
                }
            }
        }

        private void PB_Cstm_Olives_Whole_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Olives.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Olives_Whole.Image = Utilities.PIZZA_WHOLE_SELECTED;
                PB_Cstm_Olives_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Olives_R.Image = Utilities.PIZZA_RIGHT;

                if (RB_Cstm_Pepperoni_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_OLIVE_L);
                    Images.Remove(Utilities.TOP_OLIVE_X_L);
                    Images.Remove(Utilities.TOP_OLIVE_R);
                    Images.Remove(Utilities.TOP_OLIVE_X_R);
                    Images.Add(Utilities.TOP_OLIVE_X_L);
                    Images.Add(Utilities.TOP_OLIVE_X_R);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_OLIVE_L);
                    Images.Remove(Utilities.TOP_OLIVE_X_L);
                    Images.Remove(Utilities.TOP_OLIVE_R);
                    Images.Remove(Utilities.TOP_OLIVE_X_R);
                    Images.Add(Utilities.TOP_OLIVE_L);
                    Images.Add(Utilities.TOP_OLIVE_R);
                    CustomImage();
                }
            }
        }

        private void PB_Cstm_Olives_R_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Olives.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Olives_R.Image = Utilities.PIZZA_RIGHT_SELECTED;
                PB_Cstm_Olives_L.Image = Utilities.PIZZA_LEFT;
                PB_Cstm_Olives_Whole.Image = Utilities.PIZZA_WHOLE;

                if (RB_Cstm_Pepperoni_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_OLIVE_L);
                    Images.Remove(Utilities.TOP_OLIVE_X_L);
                    Images.Remove(Utilities.TOP_OLIVE_R);
                    Images.Remove(Utilities.TOP_OLIVE_X_R);
                    Images.Add(Utilities.TOP_OLIVE_X_R);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_OLIVE_L);
                    Images.Remove(Utilities.TOP_OLIVE_X_L);
                    Images.Remove(Utilities.TOP_OLIVE_R);
                    Images.Remove(Utilities.TOP_OLIVE_X_R);
                    Images.Add(Utilities.TOP_OLIVE_R);
                    CustomImage();
                }
            }
        }

        private void PB_Cstm_Olives_L_Click(object sender, EventArgs e)
        {
            if (CB_Cstm_Olives.Checked)
            {
                PictureBox pb = ((PictureBox)sender);
                PB_Cstm_Olives_R.Image = Utilities.PIZZA_RIGHT;
                PB_Cstm_Olives_L.Image = Utilities.PIZZA_LEFT_SELECTED;
                PB_Cstm_Olives_Whole.Image = Utilities.PIZZA_WHOLE;

                if (RB_Cstm_Olives_Extra.Checked)
                {
                    Images.Remove(Utilities.TOP_OLIVE_L);
                    Images.Remove(Utilities.TOP_OLIVE_X_L);
                    Images.Remove(Utilities.TOP_OLIVE_R);
                    Images.Remove(Utilities.TOP_OLIVE_X_R);
                    Images.Add(Utilities.TOP_OLIVE_X_L);
                    CustomImage();
                }
                else
                {
                    Images.Remove(Utilities.TOP_OLIVE_L);
                    Images.Remove(Utilities.TOP_OLIVE_X_L);
                    Images.Remove(Utilities.TOP_OLIVE_R);
                    Images.Remove(Utilities.TOP_OLIVE_X_R);
                    Images.Add(Utilities.TOP_OLIVE_L);
                    CustomImage();
                }
            }
        }

        private void BTN_Cstm_Clear_ClickEvent(object sender, EventArgs e)
        {
            RB_Cstm_Crust_Pan.Checked = true;
            RB_Cstm_Size_Large.Checked = true;
            RB_Cstm_Sauce_Mar.Checked = true;
            CB_Cstm_Pepperoni.Checked = false;
            CB_Cstm_Sausage.Checked = false;
            CB_Cstm_Ham.Checked = false;
            CB_Cstm_Bacon.Checked = false;
            CB_Cstm_Mushrooms.Checked = false;
            CB_Cstm_Onions.Checked = false;
            CB_Cstm_Olives.Checked = false;
        }

        private void BTN_Cstm_Order_ClickEvent(object sender, EventArgs e)
        {
            Custom.Price = Double.Parse(Utilities.getLabelPrice(LBL_Cstm_Price));
            Custom.UpdateList();
            string Toppings = Custom.GetListToStrings();
            string CustomPrice = $"${Custom.Price}";
            Subtotal += Custom.Price;
            LBL_Order_Subtotal.Text = $"${Subtotal}";

            ListViewItem item = new ListViewItem("CSTM");
            item.SubItems.Add("Custom");
            item.SubItems.Add(Custom.Size);
            item.SubItems.Add(Custom.Crust);
            item.SubItems.Add(Toppings);
            item.SubItems.Add(CustomPrice);
            LV_Cart.Items.Add(item);

            PB_Order_Notify.Visible = true;
            MessageBox.Show("Custom Pizza added to Order!\n\nGo to 'Your Order' to Checkout ...");
        }

        private void LBL_Order_Subtotal_TextChanged(object sender, EventArgs e)
        {
            Tax = Subtotal * TaxRate;
            Total = Subtotal + Tax;
            LBL_Order_Tax.Text = $"${String.Format("{0:0.00}", Tax)}";
            LBL_Order_Total.Text = $"${String.Format("{0:0.00}", Total)}";
        }

        private void BTN_Order_Order_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Let's pretend you entered your credit card information here. I'm tired!");
        }
    }
}
