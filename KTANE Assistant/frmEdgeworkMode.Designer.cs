namespace KTANE_Assistant
{
    partial class frmEdgeworkMode
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
            this.manualButton = new System.Windows.Forms.Button();
            this.automaticButton = new System.Windows.Forms.Button();
            this.promptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // manualButton
            // 
            this.manualButton.Location = new System.Drawing.Point(253, 81);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(104, 41);
            this.manualButton.TabIndex = 5;
            this.manualButton.Text = "Manual";
            this.manualButton.UseVisualStyleBackColor = true;
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // automaticButton
            // 
            this.automaticButton.Location = new System.Drawing.Point(253, 34);
            this.automaticButton.Name = "automaticButton";
            this.automaticButton.Size = new System.Drawing.Size(104, 41);
            this.automaticButton.TabIndex = 4;
            this.automaticButton.Text = "Automatic";
            this.automaticButton.UseVisualStyleBackColor = true;
            this.automaticButton.Click += new System.EventHandler(this.automaticButton_Click);
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(17, 6);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(549, 17);
            this.promptLabel.TabIndex = 3;
            this.promptLabel.Text = "Would you like to manually input the edgework or use the information in Edgework." + "txt?";
            // 
            // frmEdgeworkSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 132);
            this.Controls.Add(this.manualButton);
            this.Controls.Add(this.automaticButton);
            this.Controls.Add(this.promptLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEdgeworkMode";
            this.Text = "EdgeworkSelectionForm";
            this.Load += new System.EventHandler(this.frmEdgeworkSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.Button automaticButton;
        private Label promptLabel;
    }
}