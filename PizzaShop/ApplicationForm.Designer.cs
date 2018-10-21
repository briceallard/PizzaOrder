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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PB_Minimize = new System.Windows.Forms.PictureBox();
            this.PB_Exit = new System.Windows.Forms.PictureBox();
            this.PB_Maximize = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Menu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Maximize)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 24);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.PB_Minimize);
            this.panel6.Controls.Add(this.PB_Exit);
            this.panel6.Controls.Add(this.PB_Maximize);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1159, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(93, 24);
            this.panel6.TabIndex = 1;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caterina\'s Pizzeria";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.BTN_Menu);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 737);
            this.panel1.TabIndex = 2;
            // 
            // BTN_Menu
            // 
            this.BTN_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Menu.FlatAppearance.BorderSize = 0;
            this.BTN_Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BTN_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.BTN_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Menu.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Menu.ForeColor = System.Drawing.Color.White;
            this.BTN_Menu.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Menu.Image")));
            this.BTN_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Menu.Location = new System.Drawing.Point(0, 153);
            this.BTN_Menu.Name = "BTN_Menu";
            this.BTN_Menu.Size = new System.Drawing.Size(194, 86);
            this.BTN_Menu.TabIndex = 1;
            this.BTN_Menu.Text = "MENU";
            this.BTN_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTN_Menu.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 153);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(194, 697);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1058, 64);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(194, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1058, 673);
            this.panel5.TabIndex = 4;
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(109)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(1252, 761);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caterina";
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Maximize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Menu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox PB_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_Maximize;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox PB_Minimize;
    }
}

