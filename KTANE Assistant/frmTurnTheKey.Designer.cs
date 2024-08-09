using System.ComponentModel;

namespace KTANE_Assistant;

partial class frmTurnTheKey
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
        this.btnSave = new System.Windows.Forms.Button();
        this.textBoxSeconds = new System.Windows.Forms.TextBox();
        this.textBoxMinutes = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // btnSave
        // 
        this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnSave.Location = new System.Drawing.Point(116, 162);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(279, 68);
        this.btnSave.TabIndex = 11;
        this.btnSave.Text = "Save";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        // 
        // textBoxSeconds
        // 
        this.textBoxSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textBoxSeconds.Location = new System.Drawing.Point(259, 25);
        this.textBoxSeconds.Name = "textBoxSeconds";
        this.textBoxSeconds.Size = new System.Drawing.Size(61, 30);
        this.textBoxSeconds.TabIndex = 10;
        // 
        // textBoxMinutes
        // 
        this.textBoxMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textBoxMinutes.Location = new System.Drawing.Point(172, 25);
        this.textBoxMinutes.Name = "textBoxMinutes";
        this.textBoxMinutes.Size = new System.Drawing.Size(61, 30);
        this.textBoxMinutes.TabIndex = 9;
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(239, 25);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(14, 29);
        this.label2.TabIndex = 8;
        this.label2.Text = ":";
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(21, 25);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(160, 41);
        this.label1.TabIndex = 7;
        this.label1.Text = "Bomb Time:";
        // 
        // frmTurnTheKey
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(530, 291);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.textBoxSeconds);
        this.Controls.Add(this.textBoxMinutes);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "frmTurnTheKey";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Turn the key";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox textBoxSeconds;
    private System.Windows.Forms.TextBox textBoxMinutes;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;

    #endregion
}