
namespace Bon_Apetit.FrontEnd.UserControls
{
    partial class AdminEditing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEditing));
            this.KindOfRecipe = new System.Windows.Forms.Label();
            this.NameR = new System.Windows.Forms.Label();
            this.TimeOfPreparation = new System.Windows.Forms.Label();
            this.LevelOfDifficulty = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Button();
            this.NameRecipe = new System.Windows.Forms.TextBox();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.TextRecipe = new System.Windows.Forms.TextBox();
            this.UploadImg = new System.Windows.Forms.Button();
            this.panelAddRecipe = new System.Windows.Forms.Panel();
            this.reqOven = new System.Windows.Forms.CheckBox();
            this.Back = new System.Windows.Forms.Button();
            this.TimePreparation = new System.Windows.Forms.MaskedTextBox();
            this.ComboBoxKind = new System.Windows.Forms.ComboBox();
            this.recipeLabel = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EditComboBox = new System.Windows.Forms.ComboBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.userControlAddPastry1 = new Bon_Apetit.FrontEnd.UserControls.UserControlAddPastry();
            this.userControlAddPie1 = new Bon_Apetit.FrontEnd.UserControls.UserControlAddPie();
            this.userControlAddCookie1 = new Bon_Apetit.FrontEnd.UserControls.UserControlAddCookie();
            this.userControlAddCakes1 = new Bon_Apetit.FrontEnd.UserControls.UserControlAddCake();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panelAddRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // KindOfRecipe
            // 
            this.KindOfRecipe.AutoSize = true;
            this.KindOfRecipe.BackColor = System.Drawing.Color.Transparent;
            this.KindOfRecipe.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KindOfRecipe.ForeColor = System.Drawing.Color.White;
            this.KindOfRecipe.Location = new System.Drawing.Point(9, 86);
            this.KindOfRecipe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KindOfRecipe.Name = "KindOfRecipe";
            this.KindOfRecipe.Size = new System.Drawing.Size(98, 18);
            this.KindOfRecipe.TabIndex = 1;
            this.KindOfRecipe.Text = "* Kind of recipe:";
            // 
            // NameR
            // 
            this.NameR.AutoSize = true;
            this.NameR.BackColor = System.Drawing.Color.Transparent;
            this.NameR.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameR.ForeColor = System.Drawing.Color.White;
            this.NameR.Location = new System.Drawing.Point(9, 122);
            this.NameR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameR.Name = "NameR";
            this.NameR.Size = new System.Drawing.Size(53, 18);
            this.NameR.TabIndex = 2;
            this.NameR.Text = "* Name:";
            // 
            // TimeOfPreparation
            // 
            this.TimeOfPreparation.AutoSize = true;
            this.TimeOfPreparation.BackColor = System.Drawing.Color.Transparent;
            this.TimeOfPreparation.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOfPreparation.ForeColor = System.Drawing.Color.White;
            this.TimeOfPreparation.Location = new System.Drawing.Point(9, 156);
            this.TimeOfPreparation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeOfPreparation.Name = "TimeOfPreparation";
            this.TimeOfPreparation.Size = new System.Drawing.Size(191, 18);
            this.TimeOfPreparation.TabIndex = 3;
            this.TimeOfPreparation.Text = "* Time of preparation: (HH/MM)";
            // 
            // LevelOfDifficulty
            // 
            this.LevelOfDifficulty.AutoSize = true;
            this.LevelOfDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.LevelOfDifficulty.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelOfDifficulty.ForeColor = System.Drawing.Color.White;
            this.LevelOfDifficulty.Location = new System.Drawing.Point(9, 190);
            this.LevelOfDifficulty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LevelOfDifficulty.Name = "LevelOfDifficulty";
            this.LevelOfDifficulty.Size = new System.Drawing.Size(120, 18);
            this.LevelOfDifficulty.TabIndex = 4;
            this.LevelOfDifficulty.Text = "* Level of difficulty:";
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(309, 82);
            this.picture.Margin = new System.Windows.Forms.Padding(2);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(207, 158);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 15;
            this.picture.TabStop = false;
            // 
            // Add
            // 
            this.Add.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.Add.Location = new System.Drawing.Point(174, 737);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(59, 23);
            this.Add.TabIndex = 16;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // NameRecipe
            // 
            this.NameRecipe.Location = new System.Drawing.Point(137, 122);
            this.NameRecipe.Margin = new System.Windows.Forms.Padding(2);
            this.NameRecipe.Name = "NameRecipe";
            this.NameRecipe.Size = new System.Drawing.Size(119, 20);
            this.NameRecipe.TabIndex = 18;
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Location = new System.Drawing.Point(136, 190);
            this.comboBoxDifficulty.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(119, 21);
            this.comboBoxDifficulty.TabIndex = 20;
            // 
            // TextRecipe
            // 
            this.TextRecipe.Location = new System.Drawing.Point(531, 27);
            this.TextRecipe.Margin = new System.Windows.Forms.Padding(2);
            this.TextRecipe.Multiline = true;
            this.TextRecipe.Name = "TextRecipe";
            this.TextRecipe.Size = new System.Drawing.Size(515, 706);
            this.TextRecipe.TabIndex = 21;
            // 
            // UploadImg
            // 
            this.UploadImg.Image = ((System.Drawing.Image)(resources.GetObject("UploadImg.Image")));
            this.UploadImg.Location = new System.Drawing.Point(397, 244);
            this.UploadImg.Margin = new System.Windows.Forms.Padding(2);
            this.UploadImg.Name = "UploadImg";
            this.UploadImg.Size = new System.Drawing.Size(39, 33);
            this.UploadImg.TabIndex = 22;
            this.UploadImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.UploadImg.UseVisualStyleBackColor = true;
            this.UploadImg.Click += new System.EventHandler(this.UploadImg_Click);
            // 
            // panelAddRecipe
            // 
            this.panelAddRecipe.BackColor = System.Drawing.Color.Transparent;
            this.panelAddRecipe.Controls.Add(this.userControlAddPastry1);
            this.panelAddRecipe.Controls.Add(this.userControlAddPie1);
            this.panelAddRecipe.Controls.Add(this.userControlAddCookie1);
            this.panelAddRecipe.Controls.Add(this.userControlAddCakes1);
            this.panelAddRecipe.Location = new System.Drawing.Point(2, 254);
            this.panelAddRecipe.Margin = new System.Windows.Forms.Padding(2);
            this.panelAddRecipe.Name = "panelAddRecipe";
            this.panelAddRecipe.Size = new System.Drawing.Size(344, 479);
            this.panelAddRecipe.TabIndex = 23;
            // 
            // reqOven
            // 
            this.reqOven.AutoSize = true;
            this.reqOven.BackColor = System.Drawing.Color.Transparent;
            this.reqOven.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqOven.ForeColor = System.Drawing.Color.White;
            this.reqOven.Location = new System.Drawing.Point(11, 223);
            this.reqOven.Margin = new System.Windows.Forms.Padding(2);
            this.reqOven.Name = "reqOven";
            this.reqOven.Size = new System.Drawing.Size(113, 22);
            this.reqOven.TabIndex = 25;
            this.reqOven.Text = "Requires oven?";
            this.reqOven.UseVisualStyleBackColor = false;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(2, 737);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(64, 23);
            this.Back.TabIndex = 26;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // TimePreparation
            // 
            this.TimePreparation.Location = new System.Drawing.Point(202, 156);
            this.TimePreparation.Margin = new System.Windows.Forms.Padding(2);
            this.TimePreparation.Mask = "00:00";
            this.TimePreparation.Name = "TimePreparation";
            this.TimePreparation.Size = new System.Drawing.Size(60, 20);
            this.TimePreparation.TabIndex = 27;
            this.TimePreparation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimePreparation.ValidatingType = typeof(System.DateTime);
            this.TimePreparation.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TimePreparation_MaskInputRejected);
            // 
            // ComboBoxKind
            // 
            this.ComboBoxKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxKind.FormattingEnabled = true;
            this.ComboBoxKind.Location = new System.Drawing.Point(137, 86);
            this.ComboBoxKind.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxKind.Name = "ComboBoxKind";
            this.ComboBoxKind.Size = new System.Drawing.Size(119, 21);
            this.ComboBoxKind.TabIndex = 0;
            this.ComboBoxKind.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKind_SelectedIndexChanged);
            // 
            // recipeLabel
            // 
            this.recipeLabel.AutoSize = true;
            this.recipeLabel.Location = new System.Drawing.Point(528, 10);
            this.recipeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recipeLabel.Name = "recipeLabel";
            this.recipeLabel.Size = new System.Drawing.Size(51, 13);
            this.recipeLabel.TabIndex = 28;
            this.recipeLabel.Text = "* Recipe:";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(81, 737);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(56, 23);
            this.clear.TabIndex = 29;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "I would like to edit an existing recipe:";
            // 
            // EditComboBox
            // 
            this.EditComboBox.FormattingEnabled = true;
            this.EditComboBox.Location = new System.Drawing.Point(252, 41);
            this.EditComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.EditComboBox.Name = "EditComboBox";
            this.EditComboBox.Size = new System.Drawing.Size(170, 21);
            this.EditComboBox.TabIndex = 31;
            this.EditComboBox.SelectedValueChanged += new System.EventHandler(this.RecipeSelected);
            // 
            // Remove
            // 
            this.Remove.ForeColor = System.Drawing.Color.Red;
            this.Remove.Location = new System.Drawing.Point(306, 739);
            this.Remove.Margin = new System.Windows.Forms.Padding(2);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(70, 22);
            this.Remove.TabIndex = 32;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Modify
            // 
            this.Modify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Modify.Location = new System.Drawing.Point(238, 739);
            this.Modify.Margin = new System.Windows.Forms.Padding(2);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(64, 21);
            this.Modify.TabIndex = 33;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // userControlAddPastry1
            // 
            this.userControlAddPastry1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlAddPastry1.ForeColor = System.Drawing.Color.White;
            this.userControlAddPastry1.Location = new System.Drawing.Point(7, 274);
            this.userControlAddPastry1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlAddPastry1.Name = "userControlAddPastry1";
            this.userControlAddPastry1.Size = new System.Drawing.Size(259, 62);
            this.userControlAddPastry1.TabIndex = 3;
            // 
            // userControlAddPie1
            // 
            this.userControlAddPie1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlAddPie1.ForeColor = System.Drawing.Color.White;
            this.userControlAddPie1.Location = new System.Drawing.Point(2, 340);
            this.userControlAddPie1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlAddPie1.Name = "userControlAddPie1";
            this.userControlAddPie1.Size = new System.Drawing.Size(340, 84);
            this.userControlAddPie1.TabIndex = 2;
            // 
            // userControlAddCookie1
            // 
            this.userControlAddCookie1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlAddCookie1.ForeColor = System.Drawing.Color.White;
            this.userControlAddCookie1.Location = new System.Drawing.Point(11, 143);
            this.userControlAddCookie1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlAddCookie1.Name = "userControlAddCookie1";
            this.userControlAddCookie1.Size = new System.Drawing.Size(249, 124);
            this.userControlAddCookie1.TabIndex = 1;
            // 
            // userControlAddCakes1
            // 
            this.userControlAddCakes1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControlAddCakes1.ForeColor = System.Drawing.Color.White;
            this.userControlAddCakes1.Location = new System.Drawing.Point(2, 2);
            this.userControlAddCakes1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlAddCakes1.Name = "userControlAddCakes1";
            this.userControlAddCakes1.Size = new System.Drawing.Size(251, 148);
            this.userControlAddCakes1.TabIndex = 0;
            // 
            // AdminEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Bon_Apetit.Properties.Resources.addRecepie;
            this.ClientSize = new System.Drawing.Size(1083, 772);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.EditComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.recipeLabel);
            this.Controls.Add(this.TimePreparation);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.reqOven);
            this.Controls.Add(this.panelAddRecipe);
            this.Controls.Add(this.UploadImg);
            this.Controls.Add(this.TextRecipe);
            this.Controls.Add(this.comboBoxDifficulty);
            this.Controls.Add(this.NameRecipe);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.LevelOfDifficulty);
            this.Controls.Add(this.TimeOfPreparation);
            this.Controls.Add(this.NameR);
            this.Controls.Add(this.KindOfRecipe);
            this.Controls.Add(this.ComboBoxKind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminEditing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEditing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panelAddRecipe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label KindOfRecipe;
        private System.Windows.Forms.Label NameR;
        private System.Windows.Forms.Label TimeOfPreparation;
        private System.Windows.Forms.Label LevelOfDifficulty;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox NameRecipe;
        private System.Windows.Forms.ComboBox comboBoxDifficulty;
        private System.Windows.Forms.TextBox TextRecipe;
        private System.Windows.Forms.Button UploadImg;
        private System.Windows.Forms.Panel panelAddRecipe;
        private UserControlAddCookie userControlAddCookie1;
        private System.Windows.Forms.CheckBox reqOven;
        private UserControlAddPie userControlAddPie1;
        private UserControlAddPastry userControlAddPastry1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.MaskedTextBox TimePreparation;
        private System.Windows.Forms.ComboBox ComboBoxKind;
        private UserControlAddCake userControlAddCakes1;
        private System.Windows.Forms.Label recipeLabel;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EditComboBox;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Modify;
    }
}