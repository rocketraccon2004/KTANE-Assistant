using Newtonsoft.Json;
#pragma warning disable CS8602 // Dereference of a possibly null reference.

namespace KTANE_Assistant;

public partial class frmEdgeworkSelection : Form
{
   public frmEdgeworkSelection()
   {
      InitializeComponent();
   }


   private void automaticButton_Click(object sender, EventArgs e)
   {
      StreamReader sr = new StreamReader("Edgework.json");
      string json = string.Empty;
      for (int line = 1; line <= File.ReadAllLines("Edgework.json").Length; line++)
      {
         json += sr.ReadLine();
      }
      Assistant.instance.bomb = JsonConvert.DeserializeObject<Bomb>(json);
      frmMain main = new frmMain();
      sr.Close();
      Hide();
      main.Show();
   }

   private void manualButton_Click(object sender, EventArgs e)
   {
      frmEdgeworkInput input = new frmEdgeworkInput();
      Hide();
      input.Show();
   }

   private void frmEdgeworkSelection_Load(object sender, EventArgs e)
   {
      Assistant.init();
   }
}