
namespace Bon_Apetit.FrontEnd.UserControls
{
    partial class UserControlAddPie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HasVegtables = new System.Windows.Forms.CheckBox();
            this.HasMeat = new System.Windows.Forms.CheckBox();
            this.comboBoxDough = new System.Windows.Forms.ComboBox();
            this.TypeOfDough = new System.Windows.Forms.Label();
            this.RequiresKneading = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // HasVegtables
            // 
            this.HasVegtables.AutoSize = true;
            this.HasVegtables.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HasVegtables.ForeColor = System.Drawing.Color.White;
            this.HasVegtables.Location = new System.Drawing.Point(18, 23);
            this.HasVegtables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HasVegtables.Name = "HasVegtables";
            this.HasVegtables.Size = new System.Drawing.Size(192, 33);
            this.HasVegtables.TabIndex = 0;
            this.HasVegtables.Text = "Has vegtables?";
            this.HasVegtables.UseVisualStyleBackColor = true;
            // 
            // HasMeat
            // 
            this.HasMeat.AutoSize = true;
            this.HasMeat.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HasMeat.ForeColor = System.Drawing.Color.White;
            this.HasMeat.Location = new System.Drawing.Point(480, 23);
            this.HasMeat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HasMeat.Name = "HasMeat";
            this.HasMeat.Size = new System.Drawing.Size(152, 33);
            this.HasMeat.TabIndex = 1;
            this.HasMeat.Text = "Has Meat?";
            this.HasMeat.UseVisualStyleBackColor = true;
            // 
            // comboBoxDough
            // 
            this.comboBoxDough.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDough.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDough.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDough.FormattingEnabled = true;
            this.comboBoxDough.Location = new System.Drawing.Point(220, 90);
            this.comboBoxDough.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDough.Name = "comboBoxDough";
            this.comboBoxDough.Size = new System.Drawing.Size(192, 37);
            this.comboBoxDough.TabIndex = 2;
            // 
            // TypeOfDough
            // 
            this.TypeOfDough.AutoSize = true;
            this.TypeOfDough.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeOfDough.ForeColor = System.Drawing.Color.White;
            this.TypeOfDough.Location = new System.Drawing.Point(14, 90);
            this.TypeOfDough.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeOfDough.Name = "TypeOfDough";
            this.TypeOfDough.Size = new System.Drawing.Size(171, 29);
            this.TypeOfDough.TabIndex = 3;
            this.TypeOfDough.Text = "* Type of dough:";
            this.TypeOfDough.Click += new System.EventHandler(this.TypeOfDough_Click);
            // 
            // RequiresKneading
            // 
            this.RequiresKneading.AutoSize = true;
            this.RequiresKneading.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequiresKneading.ForeColor = System.Drawing.Color.White;
            this.RequiresKneading.Location = new System.Drawing.Point(220, 23);
            this.RequiresKneading.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RequiresKneading.Name = "RequiresKneading";
            this.RequiresKneading.Size = new System.Drawing.Size(233, 33);
            this.RequiresKneading.TabIndex = 4;
            this.RequiresKneading.Text = "Requires kneading?";
            this.RequiresKneading.UseVisualStyleBackColor = true;
            // 
            // UserControlAddPie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RequiresKneading);
            this.Controls.Add(this.TypeOfDough);
            this.Controls.Add(this.comboBoxDough);
            this.Controls.Add(this.HasMeat);
            this.Controls.Add(this.HasVegtables);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlAddPie";
            this.Size = new System.Drawing.Size(680, 162);
            this.Load += new System.EventHandler(this.UserControlAddPies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox HasVegtables;
        private System.Windows.Forms.CheckBox HasMeat;
        private System.Windows.Forms.ComboBox comboBoxDough;
        private System.Windows.Forms.Label TypeOfDough;
        private System.Windows.Forms.CheckBox RequiresKneading;
    }
}
