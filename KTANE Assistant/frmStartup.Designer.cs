using System.ComponentModel;

namespace KTANE_Assistant;

partial class frmStartup
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
        this.components = new System.ComponentModel.Container();
        this.bombTimer = new System.Windows.Forms.Timer(this.components);
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.textBoxMinutes = new System.Windows.Forms.TextBox();
        this.textBoxSeconds = new System.Windows.Forms.TextBox();
        this.btnStart = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // bombTimer
        // 
        this.bombTimer.Interval = 1000;
        this.bombTimer.Tick += new System.EventHandler(this.bombTimer_Tick);
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(12, 34);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(160, 41);
        this.label1.TabIndex = 0;
        this.label1.Text = "Bomb Time:";
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(230, 34);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(14, 29);
        this.label2.TabIndex = 3;
        this.label2.Text = ":";
        // 
        // textBoxMinutes
        // 
        this.textBoxMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textBoxMinutes.Location = new System.Drawing.Point(163, 34);
        this.textBoxMinutes.Name = "textBoxMinutes";
        this.textBoxMinutes.Size = new System.Drawing.Size(61, 30);
        this.textBoxMinutes.TabIndex = 4;
        // 
        // textBoxSeconds
        // 
        this.textBoxSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.textBoxSeconds.Location = new System.Drawing.Point(250, 34);
        this.textBoxSeconds.Name = "textBoxSeconds";
        this.textBoxSeconds.Size = new System.Drawing.Size(61, 30);
        this.textBoxSeconds.TabIndex = 5;
        // 
        // btnStart
        // 
        this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnStart.Location = new System.Drawing.Point(107, 171);
        this.btnStart.Name = "btnStart";
        this.btnStart.Size = new System.Drawing.Size(279, 68);
        this.btnStart.TabIndex = 6;
        this.btnStart.Text = "Start";
        this.btnStart.UseVisualStyleBackColor = true;
        this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
        // 
        // frmStartup
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(566, 269);
        this.Controls.Add(this.btnStart);
        this.Controls.Add(this.textBoxSeconds);
        this.Controls.Add(this.textBoxMinutes);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Location = new System.Drawing.Point(15, 15);
        this.Name = "frmStartup";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxMinutes;
    private System.Windows.Forms.TextBox textBoxSeconds;
    private System.Windows.Forms.Button btnStart;

    private System.Windows.Forms.Timer bombTimer;

    #endregion
}