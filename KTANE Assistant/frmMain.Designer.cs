namespace KTANE_Assistant
{

    partial class frmMain
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dropDownModules = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeEdgework = new System.Windows.Forms.Button();
            this.btnSaveEdgework = new System.Windows.Forms.Button();
            this.btnStrike = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dropDownModules
            // 
            this.dropDownModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownModules.FormattingEnabled = true;
            this.dropDownModules.Location = new System.Drawing.Point(385, 48);
            this.dropDownModules.Name = "dropDownModules";
            this.dropDownModules.Size = new System.Drawing.Size(289, 33);
            this.dropDownModules.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a module:";
            // 
            // btnChangeEdgework
            // 
            this.btnChangeEdgework.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEdgework.Location = new System.Drawing.Point(12, 161);
            this.btnChangeEdgework.Name = "btnChangeEdgework";
            this.btnChangeEdgework.Size = new System.Drawing.Size(220, 37);
            this.btnChangeEdgework.TabIndex = 2;
            this.btnChangeEdgework.Text = "Change Edgework";
            this.btnChangeEdgework.UseVisualStyleBackColor = true;
            this.btnChangeEdgework.Click += new System.EventHandler(this.btnChangeEdgework_Click);
            // 
            // btnSaveEdgework
            // 
            this.btnSaveEdgework.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEdgework.Location = new System.Drawing.Point(250, 161);
            this.btnSaveEdgework.Name = "btnSaveEdgework";
            this.btnSaveEdgework.Size = new System.Drawing.Size(220, 37);
            this.btnSaveEdgework.TabIndex = 4;
            this.btnSaveEdgework.Text = "Save Edgework";
            this.btnSaveEdgework.UseVisualStyleBackColor = true;
            this.btnSaveEdgework.Click += new System.EventHandler(this.saveEdgeworkButton_Click);
            // 
            // btnStrike
            // 
            this.btnStrike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrike.Location = new System.Drawing.Point(488, 161);
            this.btnStrike.Name = "btnStrike";
            this.btnStrike.Size = new System.Drawing.Size(220, 37);
            this.btnStrike.TabIndex = 5;
            this.btnStrike.Text = "Strike";
            this.btnStrike.UseVisualStyleBackColor = true;
            this.btnStrike.Click += new System.EventHandler(this.btnStrike_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(726, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select Module";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 256);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStrike);
            this.Controls.Add(this.btnSaveEdgework);
            this.Controls.Add(this.btnChangeEdgework);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropDownModules);
            this.Name = "frmMain";
            this.Text = "KTANE Assistant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button btnStrike;
        private System.Windows.Forms.Button btnSaveEdgework;

        private System.Windows.Forms.Button btnChangeEdgework;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox dropDownModules;

        #endregion
    }
}