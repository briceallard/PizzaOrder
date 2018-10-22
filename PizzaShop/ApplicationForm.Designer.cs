namespace PizzaShop
{
    partial class ApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TC_Navigation = new MaterialSkin.Controls.MaterialTabControl();
            this.TC_Tab_Menu = new System.Windows.Forms.TabPage();
            this.TC_Tab_Specialties = new System.Windows.Forms.TabPage();
            this.TC_Tab_Custom = new System.Windows.Forms.TabPage();
            this.TC_Tab_Cart = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Lightup_Panel_Order = new System.Windows.Forms.Panel();
            this.Lightup_Panel_Custom = new System.Windows.Forms.Panel();
            this.Lightup_Panel_Specialties = new System.Windows.Forms.Panel();
            this.Lightup_Panel_Menu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_Menu_Pizza = new System.Windows.Forms.Label();
            this.PNL_Pizza = new System.Windows.Forms.Panel();
            this.PNL_Pizza_Grid = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.LBL_Pizza_Cheese = new System.Windows.Forms.Label();
            this.PB_Menu_Title = new System.Windows.Forms.PictureBox();
            this.PB_Specials_Title = new System.Windows.Forms.PictureBox();
            this.PB_Custom_Title = new System.Windows.Forms.PictureBox();
            this.PB_Order_Title = new System.Windows.Forms.PictureBox();
            this.PB_About = new System.Windows.Forms.PictureBox();
            this.PB_Settings = new System.Windows.Forms.PictureBox();
            this.BTN_Nav_Order = new System.Windows.Forms.Button();
            this.BTN_Nav_Custom = new System.Windows.Forms.Button();
            this.BTN_Nav_Specialties = new System.Windows.Forms.Button();
            this.BTN_Nav_Menu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PB_Minimize = new System.Windows.Forms.PictureBox();
            this.PB_Exit = new System.Windows.Forms.PictureBox();
            this.PB_Maximize = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.TC_Navigation.SuspendLayout();
            this.TC_Tab_Menu.SuspendLayout();
            this.TC_Tab_Specialties.SuspendLayout();
            this.TC_Tab_Custom.SuspendLayout();
            this.TC_Tab_Cart.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PNL_Pizza.SuspendLayout();
            this.PNL_Pizza_Grid.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Menu_Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Specials_Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Custom_Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Order_Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_About)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Maximize)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.PB_Minimize);
            this.panel6.Controls.Add(this.PB_Exit);
            this.panel6.Controls.Add(this.PB_Maximize);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(931, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(93, 24);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TC_Navigation);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1024, 660);
            this.panel5.TabIndex = 4;
            // 
            // TC_Navigation
            // 
            this.TC_Navigation.Controls.Add(this.TC_Tab_Menu);
            this.TC_Navigation.Controls.Add(this.TC_Tab_Specialties);
            this.TC_Navigation.Controls.Add(this.TC_Tab_Custom);
            this.TC_Navigation.Controls.Add(this.TC_Tab_Cart);
            this.TC_Navigation.Depth = 0;
            this.TC_Navigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_Navigation.Location = new System.Drawing.Point(156, 24);
            this.TC_Navigation.MouseState = MaterialSkin.MouseState.HOVER;
            this.TC_Navigation.Name = "TC_Navigation";
            this.TC_Navigation.SelectedIndex = 0;
            this.TC_Navigation.Size = new System.Drawing.Size(868, 562);
            this.TC_Navigation.TabIndex = 5;
            // 
            // TC_Tab_Menu
            // 
            this.TC_Tab_Menu.AutoScroll = true;
            this.TC_Tab_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(109)))), ((int)(((byte)(123)))));
            this.TC_Tab_Menu.Controls.Add(this.PNL_Pizza);
            this.TC_Tab_Menu.Controls.Add(this.LBL_Menu_Pizza);
            this.TC_Tab_Menu.Controls.Add(this.PB_Menu_Title);
            this.TC_Tab_Menu.ForeColor = System.Drawing.Color.White;
            this.TC_Tab_Menu.Location = new System.Drawing.Point(4, 30);
            this.TC_Tab_Menu.Name = "TC_Tab_Menu";
            this.TC_Tab_Menu.Padding = new System.Windows.Forms.Padding(3);
            this.TC_Tab_Menu.Size = new System.Drawing.Size(860, 528);
            this.TC_Tab_Menu.TabIndex = 0;
            this.TC_Tab_Menu.Text = "Menu";
            // 
            // TC_Tab_Specialties
            // 
            this.TC_Tab_Specialties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(109)))), ((int)(((byte)(123)))));
            this.TC_Tab_Specialties.Controls.Add(this.PB_Specials_Title);
            this.TC_Tab_Specialties.ForeColor = System.Drawing.Color.White;
            this.TC_Tab_Specialties.Location = new System.Drawing.Point(4, 30);
            this.TC_Tab_Specialties.Name = "TC_Tab_Specialties";
            this.TC_Tab_Specialties.Padding = new System.Windows.Forms.Padding(3);
            this.TC_Tab_Specialties.Size = new System.Drawing.Size(860, 528);
            this.TC_Tab_Specialties.TabIndex = 1;
            this.TC_Tab_Specialties.Text = "Specialties";
            // 
            // TC_Tab_Custom
            // 
            this.TC_Tab_Custom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(109)))), ((int)(((byte)(123)))));
            this.TC_Tab_Custom.Controls.Add(this.PB_Custom_Title);
            this.TC_Tab_Custom.Location = new System.Drawing.Point(4, 30);
            this.TC_Tab_Custom.Name = "TC_Tab_Custom";
            this.TC_Tab_Custom.Padding = new System.Windows.Forms.Padding(3);
            this.TC_Tab_Custom.Size = new System.Drawing.Size(860, 528);
            this.TC_Tab_Custom.TabIndex = 2;
            this.TC_Tab_Custom.Text = "Custom";
            // 
            // TC_Tab_Cart
            // 
            this.TC_Tab_Cart.AutoScroll = true;
            this.TC_Tab_Cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(109)))), ((int)(((byte)(123)))));
            this.TC_Tab_Cart.Controls.Add(this.PB_Order_Title);
            this.TC_Tab_Cart.Location = new System.Drawing.Point(4, 30);
            this.TC_Tab_Cart.Name = "TC_Tab_Cart";
            this.TC_Tab_Cart.Padding = new System.Windows.Forms.Padding(3);
            this.TC_Tab_Cart.Size = new System.Drawing.Size(860, 528);
            this.TC_Tab_Cart.TabIndex = 3;
            this.TC_Tab_Cart.Text = "Cart";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(109)))), ((int)(((byte)(123)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(156, 586);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(868, 74);
            this.panel4.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.BTN_Nav_Order);
            this.panel1.Controls.Add(this.BTN_Nav_Custom);
            this.panel1.Controls.Add(this.BTN_Nav_Specialties);
            this.panel1.Controls.Add(this.BTN_Nav_Menu);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 636);
            this.panel1.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.PB_About);
            this.panel8.Controls.Add(this.PB_Settings);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 599);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(153, 37);
            this.panel8.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Lightup_Panel_Order);
            this.panel7.Controls.Add(this.Lightup_Panel_Custom);
            this.panel7.Controls.Add(this.Lightup_Panel_Specialties);
            this.panel7.Controls.Add(this.Lightup_Panel_Menu);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(153, 182);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 454);
            this.panel7.TabIndex = 1;
            // 
            // Lightup_Panel_Order
            // 
            this.Lightup_Panel_Order.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lightup_Panel_Order.Location = new System.Drawing.Point(0, 300);
            this.Lightup_Panel_Order.Name = "Lightup_Panel_Order";
            this.Lightup_Panel_Order.Size = new System.Drawing.Size(3, 100);
            this.Lightup_Panel_Order.TabIndex = 3;
            // 
            // Lightup_Panel_Custom
            // 
            this.Lightup_Panel_Custom.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lightup_Panel_Custom.Location = new System.Drawing.Point(0, 200);
            this.Lightup_Panel_Custom.Name = "Lightup_Panel_Custom";
            this.Lightup_Panel_Custom.Size = new System.Drawing.Size(3, 100);
            this.Lightup_Panel_Custom.TabIndex = 2;
            // 
            // Lightup_Panel_Specialties
            // 
            this.Lightup_Panel_Specialties.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lightup_Panel_Specialties.Location = new System.Drawing.Point(0, 100);
            this.Lightup_Panel_Specialties.Name = "Lightup_Panel_Specialties";
            this.Lightup_Panel_Specialties.Size = new System.Drawing.Size(3, 100);
            this.Lightup_Panel_Specialties.TabIndex = 1;
            // 
            // Lightup_Panel_Menu
            // 
            this.Lightup_Panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(28)))), ((int)(((byte)(11)))));
            this.Lightup_Panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lightup_Panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Lightup_Panel_Menu.Name = "Lightup_Panel_Menu";
            this.Lightup_Panel_Menu.Size = new System.Drawing.Size(3, 100);
            this.Lightup_Panel_Menu.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 182);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 24);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDownEvent);
            // 
            // LBL_Menu_Pizza
            // 
            this.LBL_Menu_Pizza.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Menu_Pizza.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_Menu_Pizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_Menu_Pizza.Font = new System.Drawing.Font("Italiano ", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Menu_Pizza.ForeColor = System.Drawing.Color.Black;
            this.LBL_Menu_Pizza.Location = new System.Drawing.Point(3, 252);
            this.LBL_Menu_Pizza.Name = "LBL_Menu_Pizza";
            this.LBL_Menu_Pizza.Size = new System.Drawing.Size(837, 100);
            this.LBL_Menu_Pizza.TabIndex = 1;
            this.LBL_Menu_Pizza.Text = "Pizza";
            this.LBL_Menu_Pizza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PNL_Pizza
            // 
            this.PNL_Pizza.Controls.Add(this.PNL_Pizza_Grid);
            this.PNL_Pizza.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_Pizza.Location = new System.Drawing.Point(3, 352);
            this.PNL_Pizza.Name = "PNL_Pizza";
            this.PNL_Pizza.Size = new System.Drawing.Size(837, 827);
            this.PNL_Pizza.TabIndex = 2;
            // 
            // PNL_Pizza_Grid
            // 
            this.PNL_Pizza_Grid.ColumnCount = 2;
            this.PNL_Pizza_Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PNL_Pizza_Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PNL_Pizza_Grid.Controls.Add(this.panel9, 0, 0);
            this.PNL_Pizza_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Pizza_Grid.Location = new System.Drawing.Point(0, 0);
            this.PNL_Pizza_Grid.Name = "PNL_Pizza_Grid";
            this.PNL_Pizza_Grid.RowCount = 2;
            this.PNL_Pizza_Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PNL_Pizza_Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PNL_Pizza_Grid.Size = new System.Drawing.Size(837, 827);
            this.PNL_Pizza_Grid.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button1);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.LBL_Pizza_Cheese);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(412, 407);
            this.panel9.TabIndex = 0;
            // 
            // LBL_Pizza_Cheese
            // 
            this.LBL_Pizza_Cheese.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Pizza_Cheese.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_Pizza_Cheese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_Pizza_Cheese.Font = new System.Drawing.Font("Italiano ", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Pizza_Cheese.ForeColor = System.Drawing.Color.Black;
            this.LBL_Pizza_Cheese.Image = global::PizzaShop.Properties.Resources.cheese_pizza_small;
            this.LBL_Pizza_Cheese.Location = new System.Drawing.Point(0, 0);
            this.LBL_Pizza_Cheese.Name = "LBL_Pizza_Cheese";
            this.LBL_Pizza_Cheese.Size = new System.Drawing.Size(412, 239);
            this.LBL_Pizza_Cheese.TabIndex = 0;
            this.LBL_Pizza_Cheese.Text = "Say Cheese!";
            this.LBL_Pizza_Cheese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_Menu_Title
            // 
            this.PB_Menu_Title.BackColor = System.Drawing.Color.Transparent;
            this.PB_Menu_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Menu_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.PB_Menu_Title.Image = global::PizzaShop.Properties.Resources.Menu_920x250;
            this.PB_Menu_Title.Location = new System.Drawing.Point(3, 3);
            this.PB_Menu_Title.Name = "PB_Menu_Title";
            this.PB_Menu_Title.Size = new System.Drawing.Size(837, 249);
            this.PB_Menu_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_Menu_Title.TabIndex = 0;
            this.PB_Menu_Title.TabStop = false;
            // 
            // PB_Specials_Title
            // 
            this.PB_Specials_Title.BackColor = System.Drawing.Color.Transparent;
            this.PB_Specials_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Specials_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.PB_Specials_Title.Image = global::PizzaShop.Properties.Resources.Specials_920x250;
            this.PB_Specials_Title.Location = new System.Drawing.Point(3, 3);
            this.PB_Specials_Title.Name = "PB_Specials_Title";
            this.PB_Specials_Title.Size = new System.Drawing.Size(854, 249);
            this.PB_Specials_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_Specials_Title.TabIndex = 1;
            this.PB_Specials_Title.TabStop = false;
            // 
            // PB_Custom_Title
            // 
            this.PB_Custom_Title.BackColor = System.Drawing.Color.Transparent;
            this.PB_Custom_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Custom_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.PB_Custom_Title.Image = global::PizzaShop.Properties.Resources.Custom_920x250;
            this.PB_Custom_Title.Location = new System.Drawing.Point(3, 3);
            this.PB_Custom_Title.Name = "PB_Custom_Title";
            this.PB_Custom_Title.Size = new System.Drawing.Size(854, 250);
            this.PB_Custom_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_Custom_Title.TabIndex = 1;
            this.PB_Custom_Title.TabStop = false;
            // 
            // PB_Order_Title
            // 
            this.PB_Order_Title.BackColor = System.Drawing.Color.Transparent;
            this.PB_Order_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Order_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.PB_Order_Title.Image = global::PizzaShop.Properties.Resources.Order_920x250;
            this.PB_Order_Title.Location = new System.Drawing.Point(3, 3);
            this.PB_Order_Title.Name = "PB_Order_Title";
            this.PB_Order_Title.Size = new System.Drawing.Size(854, 250);
            this.PB_Order_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_Order_Title.TabIndex = 1;
            this.PB_Order_Title.TabStop = false;
            // 
            // PB_About
            // 
            this.PB_About.BackColor = System.Drawing.Color.Transparent;
            this.PB_About.Dock = System.Windows.Forms.DockStyle.Left;
            this.PB_About.Image = global::PizzaShop.Properties.Resources.info_white_thin_24x24;
            this.PB_About.Location = new System.Drawing.Point(50, 0);
            this.PB_About.Name = "PB_About";
            this.PB_About.Size = new System.Drawing.Size(50, 37);
            this.PB_About.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_About.TabIndex = 8;
            this.PB_About.TabStop = false;
            this.PB_About.MouseEnter += new System.EventHandler(this.PB_About_MouseEnterEvent);
            this.PB_About.MouseLeave += new System.EventHandler(this.PB_About_MouseLeaveEvent);
            // 
            // PB_Settings
            // 
            this.PB_Settings.BackColor = System.Drawing.Color.Transparent;
            this.PB_Settings.Dock = System.Windows.Forms.DockStyle.Left;
            this.PB_Settings.Image = global::PizzaShop.Properties.Resources.settings_white_thin_24x24;
            this.PB_Settings.Location = new System.Drawing.Point(0, 0);
            this.PB_Settings.Name = "PB_Settings";
            this.PB_Settings.Size = new System.Drawing.Size(50, 37);
            this.PB_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_Settings.TabIndex = 7;
            this.PB_Settings.TabStop = false;
            this.PB_Settings.MouseEnter += new System.EventHandler(this.PB_Settings_MouseEnterEvent);
            this.PB_Settings.MouseLeave += new System.EventHandler(this.PB_Settings_MouseLeaveEvent);
            // 
            // BTN_Nav_Order
            // 
            this.BTN_Nav_Order.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Nav_Order.FlatAppearance.BorderSize = 0;
            this.BTN_Nav_Order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BTN_Nav_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Nav_Order.ForeColor = System.Drawing.Color.White;
            this.BTN_Nav_Order.Image = global::PizzaShop.Properties.Resources.order_white_24x24;
            this.BTN_Nav_Order.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Nav_Order.Location = new System.Drawing.Point(0, 482);
            this.BTN_Nav_Order.Name = "BTN_Nav_Order";
            this.BTN_Nav_Order.Size = new System.Drawing.Size(153, 100);
            this.BTN_Nav_Order.TabIndex = 5;
            this.BTN_Nav_Order.Text = "Your Order";
            this.BTN_Nav_Order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Nav_Order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Nav_Order.UseVisualStyleBackColor = true;
            this.BTN_Nav_Order.Click += new System.EventHandler(this.BTN_Nav_Order_Click);
            this.BTN_Nav_Order.MouseEnter += new System.EventHandler(this.BTN_Nav_Order_MouseEnterEvent);
            this.BTN_Nav_Order.MouseLeave += new System.EventHandler(this.BTN_Nav_Order_MouseLeaveEvent);
            // 
            // BTN_Nav_Custom
            // 
            this.BTN_Nav_Custom.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Nav_Custom.FlatAppearance.BorderSize = 0;
            this.BTN_Nav_Custom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BTN_Nav_Custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Nav_Custom.ForeColor = System.Drawing.Color.White;
            this.BTN_Nav_Custom.Image = global::PizzaShop.Properties.Resources.custom_white_24x24;
            this.BTN_Nav_Custom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Nav_Custom.Location = new System.Drawing.Point(0, 382);
            this.BTN_Nav_Custom.Name = "BTN_Nav_Custom";
            this.BTN_Nav_Custom.Size = new System.Drawing.Size(153, 100);
            this.BTN_Nav_Custom.TabIndex = 4;
            this.BTN_Nav_Custom.Text = "Build Your Own";
            this.BTN_Nav_Custom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Nav_Custom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Nav_Custom.UseVisualStyleBackColor = true;
            this.BTN_Nav_Custom.Click += new System.EventHandler(this.BTN_Nav_Custom_Click);
            this.BTN_Nav_Custom.MouseEnter += new System.EventHandler(this.BTN_Nav_Custom_MouseEnterEvent);
            this.BTN_Nav_Custom.MouseLeave += new System.EventHandler(this.BTN_Nav_Custom_MouseLeaveEvent);
            // 
            // BTN_Nav_Specialties
            // 
            this.BTN_Nav_Specialties.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Nav_Specialties.FlatAppearance.BorderSize = 0;
            this.BTN_Nav_Specialties.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BTN_Nav_Specialties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Nav_Specialties.ForeColor = System.Drawing.Color.White;
            this.BTN_Nav_Specialties.Image = global::PizzaShop.Properties.Resources.specialties_white_24x24;
            this.BTN_Nav_Specialties.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Nav_Specialties.Location = new System.Drawing.Point(0, 282);
            this.BTN_Nav_Specialties.Name = "BTN_Nav_Specialties";
            this.BTN_Nav_Specialties.Size = new System.Drawing.Size(153, 100);
            this.BTN_Nav_Specialties.TabIndex = 3;
            this.BTN_Nav_Specialties.Text = "Specialties";
            this.BTN_Nav_Specialties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Nav_Specialties.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Nav_Specialties.UseVisualStyleBackColor = true;
            this.BTN_Nav_Specialties.Click += new System.EventHandler(this.BTN_Nav_Specialties_Click);
            this.BTN_Nav_Specialties.MouseEnter += new System.EventHandler(this.BTN_Nav_Specialties_MouseEnterEvent);
            this.BTN_Nav_Specialties.MouseLeave += new System.EventHandler(this.BTN_Nav_Specialties_MouseLeaveEvent);
            // 
            // BTN_Nav_Menu
            // 
            this.BTN_Nav_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Nav_Menu.FlatAppearance.BorderSize = 0;
            this.BTN_Nav_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BTN_Nav_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Nav_Menu.ForeColor = System.Drawing.Color.White;
            this.BTN_Nav_Menu.Image = global::PizzaShop.Properties.Resources.menu_white_24x24;
            this.BTN_Nav_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Nav_Menu.Location = new System.Drawing.Point(0, 182);
            this.BTN_Nav_Menu.Name = "BTN_Nav_Menu";
            this.BTN_Nav_Menu.Size = new System.Drawing.Size(153, 100);
            this.BTN_Nav_Menu.TabIndex = 2;
            this.BTN_Nav_Menu.Text = "Menu";
            this.BTN_Nav_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Nav_Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Nav_Menu.UseVisualStyleBackColor = true;
            this.BTN_Nav_Menu.Click += new System.EventHandler(this.BTN_Nav_Menu_Click);
            this.BTN_Nav_Menu.MouseEnter += new System.EventHandler(this.BTN_Nav_Menu_MouseEnterEvent);
            this.BTN_Nav_Menu.MouseLeave += new System.EventHandler(this.BTN_Nav_Menu_MouseLeaveEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PizzaShop.Properties.Resources.Logo_400x400;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PB_Minimize
            // 
            this.PB_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.PB_Minimize.BackgroundImage = global::PizzaShop.Properties.Resources.minimize_thin_white_16x16;
            this.PB_Minimize.Location = new System.Drawing.Point(26, 4);
            this.PB_Minimize.Name = "PB_Minimize";
            this.PB_Minimize.Size = new System.Drawing.Size(16, 16);
            this.PB_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Minimize.TabIndex = 0;
            this.PB_Minimize.TabStop = false;
            this.PB_Minimize.Click += new System.EventHandler(this.PB_Minimize_ClickEvent);
            this.PB_Minimize.MouseEnter += new System.EventHandler(this.PB_Minimize_MouseEnterEvent);
            this.PB_Minimize.MouseLeave += new System.EventHandler(this.PB_Minimize_MouseLeaveEvent);
            // 
            // PB_Exit
            // 
            this.PB_Exit.BackColor = System.Drawing.Color.Transparent;
            this.PB_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Exit.BackgroundImage")));
            this.PB_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Exit.Location = new System.Drawing.Point(70, 4);
            this.PB_Exit.Name = "PB_Exit";
            this.PB_Exit.Size = new System.Drawing.Size(16, 16);
            this.PB_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_Exit.TabIndex = 0;
            this.PB_Exit.TabStop = false;
            this.PB_Exit.Click += new System.EventHandler(this.PB_Exit_ClickEvent);
            this.PB_Exit.MouseEnter += new System.EventHandler(this.PB_Exit_MouseEnterEvent);
            this.PB_Exit.MouseLeave += new System.EventHandler(this.PB_Exit_MouseLeaveEvent);
            // 
            // PB_Maximize
            // 
            this.PB_Maximize.BackColor = System.Drawing.Color.Transparent;
            this.PB_Maximize.Image = global::PizzaShop.Properties.Resources.maximize_active_white_16x16;
            this.PB_Maximize.Location = new System.Drawing.Point(48, 4);
            this.PB_Maximize.Name = "PB_Maximize";
            this.PB_Maximize.Size = new System.Drawing.Size(16, 16);
            this.PB_Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Maximize.TabIndex = 0;
            this.PB_Maximize.TabStop = false;
            this.PB_Maximize.Click += new System.EventHandler(this.PB_Maximize_ClickEvent);
            this.PB_Maximize.MouseEnter += new System.EventHandler(this.PB_Maximize_MouseEnterEvent);
            this.PB_Maximize.MouseLeave += new System.EventHandler(this.PB_Maximize_MouseLeaveEvent);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Small - $7.99",
            "Medium - $9.99",
            "Large - $11.99"});
            this.comboBox1.Location = new System.Drawing.Point(135, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 29);
            this.comboBox1.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.comboBox1);
            this.panel10.Location = new System.Drawing.Point(36, 242);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(340, 30);
            this.panel10.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(-40, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "- Size -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.comboBox2);
            this.panel11.Location = new System.Drawing.Point(36, 275);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(340, 30);
            this.panel11.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(-40, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "- Cheese -";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Regular - +$0.00",
            "Extra - +$0.99",
            "Insane - +$1.99"});
            this.comboBox2.Location = new System.Drawing.Point(135, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 29);
            this.comboBox2.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.Controls.Add(this.label3);
            this.panel12.Controls.Add(this.comboBox3);
            this.panel12.Location = new System.Drawing.Point(36, 308);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(340, 30);
            this.panel12.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(-40, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "- Sauce -";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.ForeColor = System.Drawing.Color.White;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Regular - +$0.00",
            "Extra - +$0.99",
            "Insane - +$1.99"});
            this.comboBox3.Location = new System.Drawing.Point(135, 0);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(205, 29);
            this.comboBox3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(36, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Order Now";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(109)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(1024, 660);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 660);
            this.Name = "ApplicationForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caterina";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.TC_Navigation.ResumeLayout(false);
            this.TC_Tab_Menu.ResumeLayout(false);
            this.TC_Tab_Specialties.ResumeLayout(false);
            this.TC_Tab_Custom.ResumeLayout(false);
            this.TC_Tab_Cart.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PNL_Pizza.ResumeLayout(false);
            this.PNL_Pizza_Grid.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Menu_Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Specials_Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Custom_Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Order_Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_About)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Maximize)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox PB_Minimize;
        private System.Windows.Forms.PictureBox PB_Exit;
        private System.Windows.Forms.PictureBox PB_Maximize;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialTabControl TC_Navigation;
        private System.Windows.Forms.TabPage TC_Tab_Menu;
        private System.Windows.Forms.TabPage TC_Tab_Specialties;
        private System.Windows.Forms.Button BTN_Nav_Menu;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel Lightup_Panel_Menu;
        private System.Windows.Forms.Button BTN_Nav_Specialties;
        private System.Windows.Forms.Button BTN_Nav_Custom;
        private System.Windows.Forms.Panel Lightup_Panel_Specialties;
        private System.Windows.Forms.Panel Lightup_Panel_Custom;
        private System.Windows.Forms.TabPage TC_Tab_Custom;
        private System.Windows.Forms.TabPage TC_Tab_Cart;
        private System.Windows.Forms.Button BTN_Nav_Order;
        private System.Windows.Forms.Panel Lightup_Panel_Order;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox PB_Settings;
        private System.Windows.Forms.PictureBox PB_About;
        private System.Windows.Forms.PictureBox PB_Menu_Title;
        private System.Windows.Forms.PictureBox PB_Specials_Title;
        private System.Windows.Forms.PictureBox PB_Custom_Title;
        private System.Windows.Forms.PictureBox PB_Order_Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBL_Menu_Pizza;
        private System.Windows.Forms.Panel PNL_Pizza;
        private System.Windows.Forms.TableLayoutPanel PNL_Pizza_Grid;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label LBL_Pizza_Cheese;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
    }
}

