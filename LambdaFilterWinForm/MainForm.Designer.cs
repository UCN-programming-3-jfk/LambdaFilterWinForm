
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
            this.chkTallOnes = new System.Windows.Forms.CheckBox();
            this.chkShortOnes = new System.Windows.Forms.CheckBox();
            this.chkRedOnes = new System.Windows.Forms.CheckBox();
            this.chkToleratesShade = new System.Windows.Forms.CheckBox();
            this.chkYellowOnes = new System.Windows.Forms.CheckBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAllPlants
            // 
            this.lstAllPlants.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstAllPlants.FormattingEnabled = true;
            this.lstAllPlants.ItemHeight = 25;
            this.lstAllPlants.Location = new System.Drawing.Point(0, 0);
            this.lstAllPlants.Margin = new System.Windows.Forms.Padding(4);
            this.lstAllPlants.Name = "lstAllPlants";
            this.lstAllPlants.Size = new System.Drawing.Size(486, 562);
            this.lstAllPlants.TabIndex = 0;
            // 
            // lstFilteredPlants
            // 
            this.lstFilteredPlants.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstFilteredPlants.FormattingEnabled = true;
            this.lstFilteredPlants.ItemHeight = 25;
            this.lstFilteredPlants.Location = new System.Drawing.Point(859, 0);
            this.lstFilteredPlants.Margin = new System.Windows.Forms.Padding(4);
            this.lstFilteredPlants.Name = "lstFilteredPlants";
            this.lstFilteredPlants.Size = new System.Drawing.Size(490, 562);
            this.lstFilteredPlants.TabIndex = 1;
            // 
            // chkTallOnes
            // 
            this.chkTallOnes.AutoSize = true;
            this.chkTallOnes.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkTallOnes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkTallOnes.Location = new System.Drawing.Point(486, 0);
            this.chkTallOnes.Name = "chkTallOnes";
            this.chkTallOnes.Size = new System.Drawing.Size(373, 36);
            this.chkTallOnes.TabIndex = 3;
            this.chkTallOnes.Text = "&Tall ones ( > 100cm)";
            this.chkTallOnes.UseVisualStyleBackColor = true;
            // 
            // chkShortOnes
            // 
            this.chkShortOnes.AutoSize = true;
            this.chkShortOnes.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkShortOnes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkShortOnes.Location = new System.Drawing.Point(486, 36);
            this.chkShortOnes.Name = "chkShortOnes";
            this.chkShortOnes.Size = new System.Drawing.Size(373, 36);
            this.chkShortOnes.TabIndex = 4;
            this.chkShortOnes.Text = "&Short ones ( <= 100cm)";
            this.chkShortOnes.UseVisualStyleBackColor = true;
            // 
            // chkRedOnes
            // 
            this.chkRedOnes.AutoSize = true;
            this.chkRedOnes.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkRedOnes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkRedOnes.Location = new System.Drawing.Point(486, 72);
            this.chkRedOnes.Name = "chkRedOnes";
            this.chkRedOnes.Size = new System.Drawing.Size(373, 36);
            this.chkRedOnes.TabIndex = 5;
            this.chkRedOnes.Text = "&Red ones";
            this.chkRedOnes.UseVisualStyleBackColor = true;
            // 
            // chkToleratesShade
            // 
            this.chkToleratesShade.AutoSize = true;
            this.chkToleratesShade.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkToleratesShade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkToleratesShade.Location = new System.Drawing.Point(486, 144);
            this.chkToleratesShade.Name = "chkToleratesShade";
            this.chkToleratesShade.Size = new System.Drawing.Size(373, 36);
            this.chkToleratesShade.TabIndex = 7;
            this.chkToleratesShade.Text = "T&olerates shade";
            this.chkToleratesShade.UseVisualStyleBackColor = true;
            // 
            // chkYellowOnes
            // 
            this.chkYellowOnes.AutoSize = true;
            this.chkYellowOnes.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkYellowOnes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkYellowOnes.Location = new System.Drawing.Point(486, 108);
            this.chkYellowOnes.Name = "chkYellowOnes";
            this.chkYellowOnes.Size = new System.Drawing.Size(373, 36);
            this.chkYellowOnes.TabIndex = 6;
            this.chkYellowOnes.Text = "&Yellow ones";
            this.chkYellowOnes.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.Location = new System.Drawing.Point(486, 502);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(373, 60);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 562);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.chkToleratesShade);
            this.Controls.Add(this.chkYellowOnes);
            this.Controls.Add(this.chkRedOnes);
            this.Controls.Add(this.chkShortOnes);
            this.Controls.Add(this.chkTallOnes);
            this.Controls.Add(this.lstFilteredPlants);
            this.Controls.Add(this.lstAllPlants);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Lambda filter form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllPlants;
        private System.Windows.Forms.ListBox lstFilteredPlants;
        private System.Windows.Forms.CheckBox chkTallOnes;
        private System.Windows.Forms.CheckBox chkShortOnes;
        private System.Windows.Forms.CheckBox chkRedOnes;
        private System.Windows.Forms.CheckBox chkToleratesShade;
        private System.Windows.Forms.CheckBox chkYellowOnes;
        private System.Windows.Forms.Button btnFilter;
    }
}

