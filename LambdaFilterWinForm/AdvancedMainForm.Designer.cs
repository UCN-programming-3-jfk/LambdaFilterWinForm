
namespace LambdaFilterWinForm
{
    partial class AdvancedMainForm
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
            lstAllPlants = new System.Windows.Forms.ListBox();
            lstFilteredPlants = new System.Windows.Forms.ListBox();
            chkTallOnes = new System.Windows.Forms.CheckBox();
            chkShortOnes = new System.Windows.Forms.CheckBox();
            chkRedOnes = new System.Windows.Forms.CheckBox();
            chkToleratesShade = new System.Windows.Forms.CheckBox();
            chkYellowOnes = new System.Windows.Forms.CheckBox();
            btnFilter = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lstAllPlants
            // 
            lstAllPlants.Dock = System.Windows.Forms.DockStyle.Left;
            lstAllPlants.FormattingEnabled = true;
            lstAllPlants.ItemHeight = 25;
            lstAllPlants.Location = new System.Drawing.Point(0, 0);
            lstAllPlants.Margin = new System.Windows.Forms.Padding(4);
            lstAllPlants.Name = "lstAllPlants";
            lstAllPlants.Size = new System.Drawing.Size(486, 562);
            lstAllPlants.TabIndex = 0;
            // 
            // lstFilteredPlants
            // 
            lstFilteredPlants.Dock = System.Windows.Forms.DockStyle.Right;
            lstFilteredPlants.FormattingEnabled = true;
            lstFilteredPlants.ItemHeight = 25;
            lstFilteredPlants.Location = new System.Drawing.Point(859, 0);
            lstFilteredPlants.Margin = new System.Windows.Forms.Padding(4);
            lstFilteredPlants.Name = "lstFilteredPlants";
            lstFilteredPlants.Size = new System.Drawing.Size(490, 562);
            lstFilteredPlants.TabIndex = 1;
            // 
            // chkTallOnes
            // 
            chkTallOnes.AutoSize = true;
            chkTallOnes.Dock = System.Windows.Forms.DockStyle.Top;
            chkTallOnes.Font = new System.Drawing.Font("Segoe UI", 12F);
            chkTallOnes.Location = new System.Drawing.Point(486, 0);
            chkTallOnes.Name = "chkTallOnes";
            chkTallOnes.Size = new System.Drawing.Size(373, 36);
            chkTallOnes.TabIndex = 3;
            chkTallOnes.Text = "&Tall ones ( > 100cm)";
            chkTallOnes.UseVisualStyleBackColor = true;
            // 
            // chkShortOnes
            // 
            chkShortOnes.AutoSize = true;
            chkShortOnes.Dock = System.Windows.Forms.DockStyle.Top;
            chkShortOnes.Font = new System.Drawing.Font("Segoe UI", 12F);
            chkShortOnes.Location = new System.Drawing.Point(486, 36);
            chkShortOnes.Name = "chkShortOnes";
            chkShortOnes.Size = new System.Drawing.Size(373, 36);
            chkShortOnes.TabIndex = 4;
            chkShortOnes.Text = "&Short ones ( <= 100cm)";
            chkShortOnes.UseVisualStyleBackColor = true;
            // 
            // chkRedOnes
            // 
            chkRedOnes.AutoSize = true;
            chkRedOnes.Dock = System.Windows.Forms.DockStyle.Top;
            chkRedOnes.Font = new System.Drawing.Font("Segoe UI", 12F);
            chkRedOnes.Location = new System.Drawing.Point(486, 72);
            chkRedOnes.Name = "chkRedOnes";
            chkRedOnes.Size = new System.Drawing.Size(373, 36);
            chkRedOnes.TabIndex = 5;
            chkRedOnes.Text = "&Red ones";
            chkRedOnes.UseVisualStyleBackColor = true;
            // 
            // chkToleratesShade
            // 
            chkToleratesShade.AutoSize = true;
            chkToleratesShade.Dock = System.Windows.Forms.DockStyle.Top;
            chkToleratesShade.Font = new System.Drawing.Font("Segoe UI", 12F);
            chkToleratesShade.Location = new System.Drawing.Point(486, 144);
            chkToleratesShade.Name = "chkToleratesShade";
            chkToleratesShade.Size = new System.Drawing.Size(373, 36);
            chkToleratesShade.TabIndex = 7;
            chkToleratesShade.Text = "T&olerates shade";
            chkToleratesShade.UseVisualStyleBackColor = true;
            // 
            // chkYellowOnes
            // 
            chkYellowOnes.AutoSize = true;
            chkYellowOnes.Dock = System.Windows.Forms.DockStyle.Top;
            chkYellowOnes.Font = new System.Drawing.Font("Segoe UI", 12F);
            chkYellowOnes.Location = new System.Drawing.Point(486, 108);
            chkYellowOnes.Name = "chkYellowOnes";
            chkYellowOnes.Size = new System.Drawing.Size(373, 36);
            chkYellowOnes.TabIndex = 6;
            chkYellowOnes.Text = "&Yellow ones";
            chkYellowOnes.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            btnFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnFilter.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnFilter.Location = new System.Drawing.Point(486, 502);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(373, 60);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "&Filter";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // AdvancedMainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1349, 562);
            Controls.Add(btnFilter);
            Controls.Add(chkToleratesShade);
            Controls.Add(chkYellowOnes);
            Controls.Add(chkRedOnes);
            Controls.Add(chkShortOnes);
            Controls.Add(chkTallOnes);
            Controls.Add(lstFilteredPlants);
            Controls.Add(lstAllPlants);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "AdvancedMainForm";
            Text = "Lambda filter form (Advanced)";
            ResumeLayout(false);
            PerformLayout();
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

