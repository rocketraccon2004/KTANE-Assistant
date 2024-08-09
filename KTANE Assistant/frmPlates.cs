#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace KTANE_Assistant;

public partial class frmPlates : Form
{
    private int batteries;
    private int holders;
    private int plates; 
    Day day;
    private List<Indicator> indicators;
    private string serial;
    private Plate[] plateArray;
    private int currentIteration = 1;
    
    public frmPlates()
    {
        InitializeComponent();
    }

    public void start(int batteries, int holders, int plates, Day day, List<Indicator> indicators, string serial)
    {
        this.batteries = batteries;
        this.holders = holders;
        this.plates = plates;
        this.day = day;
        this.indicators = indicators;
        this.serial = serial;
        Show();
        plateArray = new Plate[plates];
        updateLabel();
    }

    private void updateLabel()
    {
        label1.Text = $"Plate {currentIteration} of {plates}";
    }
    
    private void PlateForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        currentIteration--;
        updateLabel();
    }

    private void submitButton_Click(object sender, EventArgs e)
    {
        Plate p = new Plate()
        {
            dvid = DviCheckBox.Checked,
            parallel = parellelCheckBox.Checked,
            ps2 = psCheckBox.Checked,
            rj45 = rjCheckBox.Checked,
            serial = serialCheckBox.Checked,
            rca = RcaCheckBox.Checked,
            empty = isEmpty()
        };
        plateArray[currentIteration - 1] = p;
        if (currentIteration != plates)
        {
            currentIteration++;
            updateLabel();
            return;
        }

        Assistant.instance.setBomb(new Bomb()
        {
            batteries = batteries,
            day = day,
            emptyPlates = getEmptyPlates(),
            holders = holders,
            indicators = indicators,
            plates = plateArray,
            serial = serial.ToUpper()
        });
        Program.switchForm(new frmMain());
    }

    private int getEmptyPlates()
    {
        int count = 0;
        foreach (var p in plateArray)
        {
            if (p.empty)
            {
                count++;
            }
        }

        return count;
    }

    private bool isEmpty()
    {
        return !serialCheckBox.Checked && !DviCheckBox.Checked && !parellelCheckBox.Checked && !psCheckBox.Checked &&
               !rjCheckBox.Checked && !RcaCheckBox.Checked;
    }
}