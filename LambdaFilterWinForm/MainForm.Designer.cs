
namespace LambdaFilterWinForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstAllPlants = new System.Windows.Forms.ListBox();
            this.lstFilteredPlants = new System.Windows.Forms.ListBox();
            this.btnTallOnes = new System.Windows.Forms.Button();
            this.btnShortOnes = new System.Windows.Forms.Button();
            this.btnRedOnes = new System.Windows.Forms.Button();
            this.btnYellowOnes = new System.Windows.Forms.Button();
            this.btnShadeTolerant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAllPlants
            // 
            this.lstAllPlants.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstAllPlants.FormattingEnabled = true;
            this.lstAllPlants.ItemHeight = 20;
            this.lstAllPlants.Location = new System.Drawing.Point(0, 0);
            this.lstAllPlants.Name = "lstAllPlants";
            this.lstAllPlants.Size = new System.Drawing.Size(390, 450);
            this.lstAllPlants.TabIndex = 0;
            // 
            // lstFilteredPlants
            // 
            this.lstFilteredPlants.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstFilteredPlants.FormattingEnabled = true;
            this.lstFilteredPlants.ItemHeight = 20;
            this.lstFilteredPlants.Location = new System.Drawing.Point(686, 0);
            this.lstFilteredPlants.Name = "lstFilteredPlants";
            this.lstFilteredPlants.Size = new System.Drawing.Size(393, 450);
            this.lstFilteredPlants.TabIndex = 1;
            // 
            // btnTallOnes
            // 
            this.btnTallOnes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTallOnes.Location = new System.Drawing.Point(390, 0);
            this.btnTallOnes.Name = "btnTallOnes";
            this.btnTallOnes.Size = new System.Drawing.Size(296, 53);
            this.btnTallOnes.TabIndex = 2;
            this.btnTallOnes.Text = "&Tall ones ( > 100cm)";
            this.btnTallOnes.UseVisualStyleBackColor = true;
            this.btnTallOnes.Click += new System.EventHandler(this.btnTallOnes_Click);
            // 
            // btnShortOnes
            // 
            this.btnShortOnes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShortOnes.Location = new System.Drawing.Point(390, 53);
            this.btnShortOnes.Name = "btnShortOnes";
            this.btnShortOnes.Size = new System.Drawing.Size(296, 53);
            this.btnShortOnes.TabIndex = 2;
            this.btnShortOnes.Text = "&Short ones ( <= 100cm)";
            this.btnShortOnes.UseVisualStyleBackColor = true;
            this.btnShortOnes.Click += new System.EventHandler(this.btnShortOnes_Click);
            // 
            // btnRedOnes
            // 
            this.btnRedOnes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRedOnes.Location = new System.Drawing.Point(390, 106);
            this.btnRedOnes.Name = "btnRedOnes";
            this.btnRedOnes.Size = new System.Drawing.Size(296, 53);
            this.btnRedOnes.TabIndex = 2;
            this.btnRedOnes.Text = "&Red ones";
            this.btnRedOnes.UseVisualStyleBackColor = true;
            this.btnRedOnes.Click += new System.EventHandler(this.btnRedOnes_Click);
            // 
            // btnYellowOnes
            // 
            this.btnYellowOnes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYellowOnes.Location = new System.Drawing.Point(390, 159);
            this.btnYellowOnes.Name = "btnYellowOnes";
            this.btnYellowOnes.Size = new System.Drawing.Size(296, 53);
            this.btnYellowOnes.TabIndex = 2;
            this.btnYellowOnes.Text = "&Yellow ones";
            this.btnYellowOnes.UseVisualStyleBackColor = true;
            this.btnYellowOnes.Click += new System.EventHandler(this.btnYellowOnes_Click);
            // 
            // btnShadeTolerant
            // 
            this.btnShadeTolerant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShadeTolerant.Location = new System.Drawing.Point(390, 212);
            this.btnShadeTolerant.Name = "btnShadeTolerant";
            this.btnShadeTolerant.Size = new System.Drawing.Size(296, 53);
            this.btnShadeTolerant.TabIndex = 2;
            this.btnShadeTolerant.Text = "T&olerates shade";
            this.btnShadeTolerant.UseVisualStyleBackColor = true;
            this.btnShadeTolerant.Click += new System.EventHandler(this.btnShadeTolerant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.btnShadeTolerant);
            this.Controls.Add(this.btnYellowOnes);
            this.Controls.Add(this.btnRedOnes);
            this.Controls.Add(this.btnShortOnes);
            this.Controls.Add(this.btnTallOnes);
            this.Controls.Add(this.lstFilteredPlants);
            this.Controls.Add(this.lstAllPlants);
            this.Name = "Form1";
            this.Text = "Lambda filter form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllPlants;
        private System.Windows.Forms.ListBox lstFilteredPlants;
        private System.Windows.Forms.Button btnTallOnes;
        private System.Windows.Forms.Button btnShortOnes;
        private System.Windows.Forms.Button btnRedOnes;
        private System.Windows.Forms.Button btnYellowOnes;
        private System.Windows.Forms.Button btnShadeTolerant;
    }
}

