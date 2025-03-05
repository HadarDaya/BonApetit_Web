
namespace Bon_Apetit.FrontEnd.UserControls
{
    partial class UserControlAddPastry
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
            this.RequiresKneading = new System.Windows.Forms.CheckBox();
            this.HasMeat = new System.Windows.Forms.CheckBox();
            this.HasFilling = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // HasVegtables
            // 
            this.HasVegtables.AutoSize = true;
            this.HasVegtables.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HasVegtables.ForeColor = System.Drawing.Color.White;
            this.HasVegtables.Location = new System.Drawing.Point(9, 11);
            this.HasVegtables.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HasVegtables.Name = "HasVegtables";
            this.HasVegtables.Size = new System.Drawing.Size(101, 19);
            this.HasVegtables.TabIndex = 1;
            this.HasVegtables.Text = "Has vegtables?";
            this.HasVegtables.UseVisualStyleBackColor = true;
            // 
            // RequiresKneading
            // 
            this.RequiresKneading.AutoSize = true;
            this.RequiresKneading.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequiresKneading.ForeColor = System.Drawing.Color.White;
            this.RequiresKneading.Location = new System.Drawing.Point(110, 11);
            this.RequiresKneading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RequiresKneading.Name = "RequiresKneading";
            this.RequiresKneading.Size = new System.Drawing.Size(125, 19);
            this.RequiresKneading.TabIndex = 5;
            this.RequiresKneading.Text = "Requires kneading?";
            this.RequiresKneading.UseVisualStyleBackColor = true;
            // 
            // HasMeat
            // 
            this.HasMeat.AutoSize = true;
            this.HasMeat.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HasMeat.ForeColor = System.Drawing.Color.White;
            this.HasMeat.Location = new System.Drawing.Point(9, 32);
            this.HasMeat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HasMeat.Name = "HasMeat";
            this.HasMeat.Size = new System.Drawing.Size(79, 19);
            this.HasMeat.TabIndex = 6;
            this.HasMeat.Text = "Has Meat?";
            this.HasMeat.UseVisualStyleBackColor = true;
            // 
            // HasFilling
            // 
            this.HasFilling.AutoSize = true;
            this.HasFilling.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HasFilling.ForeColor = System.Drawing.Color.White;
            this.HasFilling.Location = new System.Drawing.Point(110, 32);
            this.HasFilling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HasFilling.Name = "HasFilling";
            this.HasFilling.Size = new System.Drawing.Size(86, 19);
            this.HasFilling.TabIndex = 7;
            this.HasFilling.Text = "Has filling?";
            this.HasFilling.UseVisualStyleBackColor = true;
            // 
            // UserControlAddPastry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HasFilling);
            this.Controls.Add(this.HasMeat);
            this.Controls.Add(this.RequiresKneading);
            this.Controls.Add(this.HasVegtables);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControlAddPastry";
            this.Size = new System.Drawing.Size(259, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox HasVegtables;
        private System.Windows.Forms.CheckBox RequiresKneading;
        private System.Windows.Forms.CheckBox HasMeat;
        private System.Windows.Forms.CheckBox HasFilling;
    }
}
