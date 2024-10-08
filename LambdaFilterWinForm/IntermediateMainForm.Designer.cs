
namespace LambdaFilterWinForm
{
    partial class IntermediateMainForm
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
            btnTallOnes = new System.Windows.Forms.Button();
            btnShortOnes = new System.Windows.Forms.Button();
            btnRedOnes = new System.Windows.Forms.Button();
            btnYellowOnes = new System.Windows.Forms.Button();
            btnShadeTolerant = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lstAllPlants
            // 
            lstAllPlants.Dock = System.Windows.Forms.DockStyle.Left;
            lstAllPlants.FormattingEnabled = true;
            lstAllPlants.ItemHeight = 25;
            lstAllPlants.Location = new System.Drawing.Point(0, 0);
            lstAllPlants.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            lstFilteredPlants.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            lstFilteredPlants.Name = "lstFilteredPlants";
            lstFilteredPlants.Size = new System.Drawing.Size(490, 562);
            lstFilteredPlants.TabIndex = 1;
            // 
            // btnTallOnes
            // 
            btnTallOnes.Dock = System.Windows.Forms.DockStyle.Top;
            btnTallOnes.Location = new System.Drawing.Point(486, 0);
            btnTallOnes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnTallOnes.Name = "btnTallOnes";
            btnTallOnes.Size = new System.Drawing.Size(373, 66);
            btnTallOnes.TabIndex = 2;
            btnTallOnes.Text = "&Tall ones ( > 100cm)";
            btnTallOnes.UseVisualStyleBackColor = true;
            // 
            // btnShortOnes
            // 
            btnShortOnes.Dock = System.Windows.Forms.DockStyle.Top;
            btnShortOnes.Location = new System.Drawing.Point(486, 66);
            btnShortOnes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnShortOnes.Name = "btnShortOnes";
            btnShortOnes.Size = new System.Drawing.Size(373, 66);
            btnShortOnes.TabIndex = 2;
            btnShortOnes.Text = "&Short ones ( <= 100cm)";
            btnShortOnes.UseVisualStyleBackColor = true;
            // 
            // btnRedOnes
            // 
            btnRedOnes.Dock = System.Windows.Forms.DockStyle.Top;
            btnRedOnes.Location = new System.Drawing.Point(486, 132);
            btnRedOnes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnRedOnes.Name = "btnRedOnes";
            btnRedOnes.Size = new System.Drawing.Size(373, 66);
            btnRedOnes.TabIndex = 2;
            btnRedOnes.Text = "&Red ones";
            btnRedOnes.UseVisualStyleBackColor = true;
            // 
            // btnYellowOnes
            // 
            btnYellowOnes.Dock = System.Windows.Forms.DockStyle.Top;
            btnYellowOnes.Location = new System.Drawing.Point(486, 198);
            btnYellowOnes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnYellowOnes.Name = "btnYellowOnes";
            btnYellowOnes.Size = new System.Drawing.Size(373, 66);
            btnYellowOnes.TabIndex = 2;
            btnYellowOnes.Text = "&Yellow ones";
            btnYellowOnes.UseVisualStyleBackColor = true;
            // 
            // btnShadeTolerant
            // 
            btnShadeTolerant.Dock = System.Windows.Forms.DockStyle.Top;
            btnShadeTolerant.Location = new System.Drawing.Point(486, 264);
            btnShadeTolerant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnShadeTolerant.Name = "btnShadeTolerant";
            btnShadeTolerant.Size = new System.Drawing.Size(373, 66);
            btnShadeTolerant.TabIndex = 2;
            btnShadeTolerant.Text = "T&olerates shade";
            btnShadeTolerant.UseVisualStyleBackColor = true;
            // 
            // IntermediateMainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1349, 562);
            Controls.Add(btnShadeTolerant);
            Controls.Add(btnYellowOnes);
            Controls.Add(btnRedOnes);
            Controls.Add(btnShortOnes);
            Controls.Add(btnTallOnes);
            Controls.Add(lstFilteredPlants);
            Controls.Add(lstAllPlants);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "IntermediateMainForm";
            Text = "Lambda filter form (Intermediate)";
            ResumeLayout(false);
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

