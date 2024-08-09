namespace KTANE_Assistant;

public partial class frmTurnTheKey : Form
{
    public frmTurnTheKey()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(textBoxSeconds.Text, out var seconds) | !int.TryParse(textBoxMinutes.Text, out var minutes))
        {
            MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            int timer = minutes * 60 + seconds;
            Assistant.instance.addTurnKeyReminder(timer);
            Program.switchForm(new frmMain());
        }
    }
}