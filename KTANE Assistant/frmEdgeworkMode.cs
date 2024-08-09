using Newtonsoft.Json;

namespace KTANE_Assistant;

public partial class frmEdgeworkMode : Form
{
   public frmEdgeworkMode()
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
      Assistant.instance.setBomb(JsonConvert.DeserializeObject<Bomb>(json));
      sr.Close();
      Program.switchForm(new frmMain());      
   }

   private void manualButton_Click(object sender, EventArgs e)
   {
      Program.switchForm(new frmEdgeworkInput());
   }

   private void frmEdgeworkSelection_Load(object sender, EventArgs e)
   {
      Assistant.init();
   }
}