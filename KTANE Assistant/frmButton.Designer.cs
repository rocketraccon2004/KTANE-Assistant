using System.ComponentModel;

namespace KTANE_Assistant;

partial class frmButton
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.btnStrike = new System.Windows.Forms.Button();
        this.btnSubmit = new System.Windows.Forms.Button();
        this.dropDownColour = new System.Windows.Forms.ComboBox();
        this.dropDownText = new System.Windows.Forms.ComboBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // btnStrike
        // 
        this.btnStrike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnStrike.Location = new System.Drawing.Point(12, 198);
        this.btnStrike.Name = "btnStrike";
        this.btnStrike.Size = new System.Drawing.Size(258, 48);
        this.btnStrike.TabIndex = 0;
        this.btnStrike.Text = "Strike";
        this.btnStrike.UseVisualStyleBackColor = true;
        this.btnStrike.Click += new System.EventHandler(this.btnStrike_Click);
        // 
        // btnSubmit
        // 
        this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnSubmit.Location = new System.Drawing.Point(290, 198);
        this.btnSubmit.Name = "btnSubmit";
        this.btnSubmit.Size = new System.Drawing.Size(258, 48);
        this.btnSubmit.TabIndex = 1;
        this.btnSubmit.Text = "Submit";
        this.btnSubmit.UseVisualStyleBackColor = true;
        this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
        // 
        // dropDownColour
        // 
        this.dropDownColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.dropDownColour.FormattingEnabled = true;
        this.dropDownColour.Items.AddRange(new object[] { "Blue", "White", "Yellow", "Red" });
        this.dropDownColour.Location = new System.Drawing.Point(285, 42);
        this.dropDownColour.Name = "dropDownColour";
        this.dropDownColour.Size = new System.Drawing.Size(263, 33);
        this.dropDownColour.TabIndex = 2;
        // 
        // dropDownText
        // 
        this.dropDownText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.dropDownText.FormattingEnabled = true;
        this.dropDownText.Items.AddRange(new object[] { "Abort", "Detonate", "Hold", "Press" });
        this.dropDownText.Location = new System.Drawing.Point(285, 118);
        this.dropDownText.Name = "dropDownText";
        this.dropDownText.Size = new System.Drawing.Size(263, 33);
        this.dropDownText.TabIndex = 3;
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(186, 42);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(93, 28);
        this.label1.TabIndex = 4;
        this.label1.Text = "Colour";
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(186, 121);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(84, 28);
        this.label2.TabIndex = 5;
        this.label2.Text = "Label";
        // 
        // frmButton
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(567, 292);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.dropDownText);
        this.Controls.Add(this.dropDownColour);
        this.Controls.Add(this.btnSubmit);
        this.Controls.Add(this.btnStrike);
        this.Name = "frmButton";
        this.Text = "Button";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmButton_FormClosing);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.ComboBox dropDownText;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox dropDownColour;

    private System.Windows.Forms.Button btnSubmit;

    private System.Windows.Forms.Button btnStrike;

    #endregion
}