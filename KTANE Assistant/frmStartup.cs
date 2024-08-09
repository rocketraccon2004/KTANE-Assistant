namespace KTANE_Assistant;

public partial class frmStartup : Form
{
    public frmStartup()
    {
        InitializeComponent();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        Assistant.init();

        if (!int.TryParse(textBoxMinutes.Text, out var minutes) | !int.TryParse(textBoxSeconds.Text, out var seconds))
        {
            MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            int timer = minutes * 60 + seconds;
            Assistant.instance.setTimer(timer); 
            bombTimer.Start();
            Program.switchForm(new frmEdgeworkMode()); 
        }
    }

    private void bombTimer_Tick(object sender, EventArgs e)
    {
        Assistant.instance.tick();
    }
}