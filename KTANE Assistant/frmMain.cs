using Newtonsoft.Json;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
namespace KTANE_Assistant;

public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        setModules();
    }

    private void setModules()
    {
        foreach (var s in Assistant.instance.modules) dropDownModules.Items.Add(s);
    }

    private void saveEdgeworkButton_Click(object sender, EventArgs e)
    {
        string json = JsonConvert.SerializeObject(Assistant.instance.bomb);
        File.WriteAllText("Edgework.json", json);
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }
}
#pragma warning restore CS8602 // Dereference of a possibly null reference.