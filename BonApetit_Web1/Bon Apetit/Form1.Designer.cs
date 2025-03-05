
namespace Bon_Apetit
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AdminLogIN = new System.Windows.Forms.Button();
            this.CakeCategory = new System.Windows.Forms.Button();
            this.CookiesCategory = new System.Windows.Forms.Button();
            this.PastriesCategory = new System.Windows.Forms.Button();
            this.PiesCategory = new System.Windows.Forms.Button();
            this.panelNames = new System.Windows.Forms.Panel();
            this.panelRecipe = new System.Windows.Forms.Panel();
            this.PanelSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.panelSweet = new System.Windows.Forms.Panel();
            this.panelCookie = new System.Windows.Forms.Panel();
            this.panelBaseSweet = new System.Windows.Forms.Panel();
            this.buttonSweet = new System.Windows.Forms.Button();
            this.panelCake = new System.Windows.Forms.Panel();
            this.panelSalty = new System.Windows.Forms.Panel();
            this.panelPie = new System.Windows.Forms.Panel();
            this.panelBaseSalty = new System.Windows.Forms.Panel();
            this.buttonSalty = new System.Windows.Forms.Button();
            this.panelPastry = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SweetTimer = new System.Windows.Forms.Timer(this.components);
            this.timerSalty = new System.Windows.Forms.Timer(this.components);
            this.PanelSideBar.SuspendLayout();
            this.panelSweet.SuspendLayout();
            this.panelCookie.SuspendLayout();
            this.panelBaseSweet.SuspendLayout();
            this.panelCake.SuspendLayout();
            this.panelSalty.SuspendLayout();
            this.panelPie.SuspendLayout();
            this.panelBaseSalty.SuspendLayout();
            this.panelPastry.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminLogIN
            // 
            this.AdminLogIN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdminLogIN.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLogIN.ForeColor = System.Drawing.Color.White;
            this.AdminLogIN.Location = new System.Drawing.Point(-43, -6);
            this.AdminLogIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminLogIN.Name = "AdminLogIN";
            this.AdminLogIN.Size = new System.Drawing.Size(515, 113);
            this.AdminLogIN.TabIndex = 0;
            this.AdminLogIN.Text = "Admin Log In";
            this.AdminLogIN.UseVisualStyleBackColor = false;
            this.AdminLogIN.Click += new System.EventHandler(this.button1_Click);
            this.AdminLogIN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AdminLogIN_MouseClick);
            // 
            // CakeCategory
            // 
            this.CakeCategory.BackColor = System.Drawing.Color.OrangeRed;
            this.CakeCategory.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CakeCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CakeCategory.Location = new System.Drawing.Point(-24, -12);
            this.CakeCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CakeCategory.Name = "CakeCategory";
            this.CakeCategory.Size = new System.Drawing.Size(455, 92);
            this.CakeCategory.TabIndex = 4;
            this.CakeCategory.Text = "Cakes";
            this.CakeCategory.UseVisualStyleBackColor = false;
            this.CakeCategory.Click += new System.EventHandler(this.Category_Click);
            // 
            // CookiesCategory
            // 
            this.CookiesCategory.BackColor = System.Drawing.Color.OrangeRed;
            this.CookiesCategory.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CookiesCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CookiesCategory.Location = new System.Drawing.Point(-11, -8);
            this.CookiesCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CookiesCategory.Name = "CookiesCategory";
            this.CookiesCategory.Size = new System.Drawing.Size(421, 79);
            this.CookiesCategory.TabIndex = 5;
            this.CookiesCategory.Text = "Cookies";
            this.CookiesCategory.UseVisualStyleBackColor = false;
            this.CookiesCategory.Click += new System.EventHandler(this.Category_Click);
            // 
            // PastriesCategory
            // 
            this.PastriesCategory.BackColor = System.Drawing.Color.OrangeRed;
            this.PastriesCategory.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastriesCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PastriesCategory.Location = new System.Drawing.Point(-19, -10);
            this.PastriesCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PastriesCategory.Name = "PastriesCategory";
            this.PastriesCategory.Size = new System.Drawing.Size(445, 91);
            this.PastriesCategory.TabIndex = 6;
            this.PastriesCategory.Text = "Pastries";
            this.PastriesCategory.UseVisualStyleBackColor = false;
            this.PastriesCategory.Click += new System.EventHandler(this.Category_Click);
            // 
            // PiesCategory
            // 
            this.PiesCategory.BackColor = System.Drawing.Color.OrangeRed;
            this.PiesCategory.Font = new System.Drawing.Font("Palatino Linotype", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiesCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PiesCategory.Location = new System.Drawing.Point(-16, -11);
            this.PiesCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PiesCategory.Name = "PiesCategory";
            this.PiesCategory.Size = new System.Drawing.Size(436, 92);
            this.PiesCategory.TabIndex = 7;
            this.PiesCategory.Text = "Pies";
            this.PiesCategory.UseVisualStyleBackColor = false;
            this.PiesCategory.Click += new System.EventHandler(this.Category_Click);
            // 
            // panelNames
            // 
            this.panelNames.BackColor = System.Drawing.Color.Black;
            this.panelNames.Location = new System.Drawing.Point(479, 317);
            this.panelNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNames.Name = "panelNames";
            this.panelNames.Size = new System.Drawing.Size(256, 536);
            this.panelNames.TabIndex = 8;
            this.panelNames.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNames_Paint);
            // 
            // panelRecipe
            // 
            this.panelRecipe.BackColor = System.Drawing.Color.Black;
            this.panelRecipe.Location = new System.Drawing.Point(795, 317);
            this.panelRecipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelRecipe.Name = "panelRecipe";
            this.panelRecipe.Size = new System.Drawing.Size(1098, 536);
            this.panelRecipe.TabIndex = 9;
            this.panelRecipe.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRecipe_Paint);
            // 
            // PanelSideBar
            // 
            this.PanelSideBar.BackColor = System.Drawing.Color.Black;
            this.PanelSideBar.Controls.Add(this.LogoPanel);
            this.PanelSideBar.Controls.Add(this.panelSweet);
            this.PanelSideBar.Controls.Add(this.panelSalty);
            this.PanelSideBar.Controls.Add(this.panelAdmin);
            this.PanelSideBar.Controls.Add(this.ExitButton);
            this.PanelSideBar.Location = new System.Drawing.Point(0, 0);
            this.PanelSideBar.Name = "PanelSideBar";
            this.PanelSideBar.Size = new System.Drawing.Size(419, 1300);
            this.PanelSideBar.TabIndex = 10;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackgroundImage = global::Bon_Apetit.Properties.Resources.LOGO;
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPanel.Location = new System.Drawing.Point(3, 3);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(419, 309);
            this.LogoPanel.TabIndex = 0;
            // 
            // panelSweet
            // 
            this.panelSweet.BackColor = System.Drawing.Color.Black;
            this.panelSweet.Controls.Add(this.panelCookie);
            this.panelSweet.Controls.Add(this.panelBaseSweet);
            this.panelSweet.Controls.Add(this.panelCake);
            this.panelSweet.Location = new System.Drawing.Point(3, 318);
            this.panelSweet.MaximumSize = new System.Drawing.Size(403, 243);
            this.panelSweet.MinimumSize = new System.Drawing.Size(403, 107);
            this.panelSweet.Name = "panelSweet";
            this.panelSweet.Size = new System.Drawing.Size(403, 107);
            this.panelSweet.TabIndex = 0;
            // 
            // panelCookie
            // 
            this.panelCookie.Controls.Add(this.CookiesCategory);
            this.panelCookie.Location = new System.Drawing.Point(0, 175);
            this.panelCookie.Name = "panelCookie";
            this.panelCookie.Size = new System.Drawing.Size(405, 67);
            this.panelCookie.TabIndex = 5;
            // 
            // panelBaseSweet
            // 
            this.panelBaseSweet.Controls.Add(this.buttonSweet);
            this.panelBaseSweet.Location = new System.Drawing.Point(3, -10);
            this.panelBaseSweet.Name = "panelBaseSweet";
            this.panelBaseSweet.Size = new System.Drawing.Size(432, 117);
            this.panelBaseSweet.TabIndex = 1;
            // 
            // buttonSweet
            // 
            this.buttonSweet.BackColor = System.Drawing.Color.Black;
            this.buttonSweet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSweet.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSweet.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSweet.Image = global::Bon_Apetit.Properties.Resources.candy;
            this.buttonSweet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSweet.Location = new System.Drawing.Point(-17, 8);
            this.buttonSweet.Name = "buttonSweet";
            this.buttonSweet.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonSweet.Size = new System.Drawing.Size(461, 117);
            this.buttonSweet.TabIndex = 0;
            this.buttonSweet.Text = "           Sweet Recipes";
            this.buttonSweet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSweet.UseVisualStyleBackColor = false;
            this.buttonSweet.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelCake
            // 
            this.panelCake.Controls.Add(this.CakeCategory);
            this.panelCake.Location = new System.Drawing.Point(1, 107);
            this.panelCake.Name = "panelCake";
            this.panelCake.Size = new System.Drawing.Size(408, 72);
            this.panelCake.TabIndex = 2;
            // 
            // panelSalty
            // 
            this.panelSalty.Controls.Add(this.panelPie);
            this.panelSalty.Controls.Add(this.panelBaseSalty);
            this.panelSalty.Controls.Add(this.panelPastry);
            this.panelSalty.Location = new System.Drawing.Point(3, 431);
            this.panelSalty.MaximumSize = new System.Drawing.Size(411, 245);
            this.panelSalty.MinimumSize = new System.Drawing.Size(416, 104);
            this.panelSalty.Name = "panelSalty";
            this.panelSalty.Size = new System.Drawing.Size(416, 104);
            this.panelSalty.TabIndex = 1;
            // 
            // panelPie
            // 
            this.panelPie.Controls.Add(this.PiesCategory);
            this.panelPie.Location = new System.Drawing.Point(0, 175);
            this.panelPie.Name = "panelPie";
            this.panelPie.Size = new System.Drawing.Size(419, 72);
            this.panelPie.TabIndex = 1;
            // 
            // panelBaseSalty
            // 
            this.panelBaseSalty.Controls.Add(this.buttonSalty);
            this.panelBaseSalty.Location = new System.Drawing.Point(0, 0);
            this.panelBaseSalty.Name = "panelBaseSalty";
            this.panelBaseSalty.Size = new System.Drawing.Size(416, 104);
            this.panelBaseSalty.TabIndex = 3;
            // 
            // buttonSalty
            // 
            this.buttonSalty.BackColor = System.Drawing.Color.Black;
            this.buttonSalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalty.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalty.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSalty.Image = global::Bon_Apetit.Properties.Resources.saltyyy__1_;
            this.buttonSalty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalty.Location = new System.Drawing.Point(-5, -19);
            this.buttonSalty.Name = "buttonSalty";
            this.buttonSalty.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonSalty.Size = new System.Drawing.Size(432, 134);
            this.buttonSalty.TabIndex = 0;
            this.buttonSalty.Text = "           Salty Recipes";
            this.buttonSalty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalty.UseVisualStyleBackColor = false;
            this.buttonSalty.Click += new System.EventHandler(this.buttonSalty_Click);
            // 
            // panelPastry
            // 
            this.panelPastry.Controls.Add(this.PastriesCategory);
            this.panelPastry.Location = new System.Drawing.Point(0, 104);
            this.panelPastry.Name = "panelPastry";
            this.panelPastry.Size = new System.Drawing.Size(419, 75);
            this.panelPastry.TabIndex = 2;
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.AdminLogIN);
            this.panelAdmin.Location = new System.Drawing.Point(3, 541);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(416, 104);
            this.panelAdmin.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Palatino Linotype", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(3, 652);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(411, 139);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SweetTimer
            // 
            this.SweetTimer.Interval = 10;
            this.SweetTimer.Tick += new System.EventHandler(this.SweetTimer_Tick);
            // 
            // timerSalty
            // 
            this.timerSalty.Interval = 10;
            this.timerSalty.Tick += new System.EventHandler(this.timerSalty_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::Bon_Apetit.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1747, 867);
            this.Controls.Add(this.panelNames);
            this.Controls.Add(this.PanelSideBar);
            this.Controls.Add(this.panelRecipe);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bon Apetit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelSideBar.ResumeLayout(false);
            this.panelSweet.ResumeLayout(false);
            this.panelCookie.ResumeLayout(false);
            this.panelBaseSweet.ResumeLayout(false);
            this.panelCake.ResumeLayout(false);
            this.panelSalty.ResumeLayout(false);
            this.panelPie.ResumeLayout(false);
            this.panelBaseSalty.ResumeLayout(false);
            this.panelPastry.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminLogIN;
        private System.Windows.Forms.Button CakeCategory;
        private System.Windows.Forms.Button CookiesCategory;
        private System.Windows.Forms.Button PastriesCategory;
        private System.Windows.Forms.Button PiesCategory;
        private System.Windows.Forms.Panel panelNames;
        private System.Windows.Forms.Panel panelRecipe;
        private System.Windows.Forms.FlowLayoutPanel PanelSideBar;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel panelBaseSweet;
        private System.Windows.Forms.Button buttonSweet;
        private System.Windows.Forms.Button buttonSalty;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Panel panelBaseSalty;
        private System.Windows.Forms.Panel panelSweet;
        private System.Windows.Forms.Panel panelCookie;
        private System.Windows.Forms.Panel panelCake;
        private System.Windows.Forms.Timer SweetTimer;
        private System.Windows.Forms.Panel panelSalty;
        private System.Windows.Forms.Panel panelPie;
        private System.Windows.Forms.Panel panelPastry;
        private System.Windows.Forms.Timer timerSalty;
        private System.Windows.Forms.Button ExitButton;
    }
}

