﻿namespace KTANE_Assistant;

public partial class frmButton : Form
{
    public frmButton()
    {
        InitializeComponent();
    }

    private void btnStrike_Click(object sender, EventArgs e)
    {
        Assistant.instance.addStrike();
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        string Colour = dropDownColour.SelectedItem.ToString();
        string Label = dropDownText.SelectedItem.ToString();

        if (Colour == "Blue" & Label == "Abort")
        {
            holdButton();
        }
        else if (Assistant.instance.getBomb().batteries > 1 & Label == "Detonate")
        {
            pressAndReleaseButton();
        }
        else if (Colour == "White" & Assistant.instance.litCAR())
        {
            holdButton();
        }
        else if (Colour == "Yellow")
        {
            holdButton();
        }
        else if (Assistant.instance.getBomb().batteries > 2 & Assistant.instance.litFRK())
        {
            pressAndReleaseButton();
        }
        else if (Colour == "Red" & Label == "Hold")
        {
            pressAndReleaseButton();
        }
        else
        {
            holdButton();
        }

        frmMain main = new frmMain();
        main.Show();
    }

    private void pressAndReleaseButton()
    {
        MessageBox.Show("Press and immediately release the button", "Button answer");
    }

    private void holdButton()
    {
        MessageBox.Show(
            "Hold the button \nBlue Strip: Release when 4 in any position on timer \nYellow Strip: Release when 5 in any position on timer \nElse: Release when 1 in any position on timer", "Button answer");
    }

    private void frmButton_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
}