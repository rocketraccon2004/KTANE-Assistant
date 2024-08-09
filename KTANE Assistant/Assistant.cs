namespace KTANE_Assistant;

public class Assistant
{
    public static Assistant instance;

    private Bomb bomb;

    private int strikes;

    private int timer;

    private List<int> turnKeyReminders = new List<int>();

    public List<string> modules = new List<string>()
    {
        "Wires",
        "Button",
        "Keypads",
        "Simon Says",
        "Who's On First",
        "Memory",
        "Morse Code",
        "Complicated Wires",
        "Wire Sequences",
        "Maze",
        "Password",
        "Knobs",
        "Turn the key"
    };

    public static void init()
    {
        if (instance == null) instance = new Assistant();
    }

    public void tick()
    {
        timer--;

        if (timer == 0)
        {
            MessageBox.Show("Boom!!!");
        }

        foreach (var i in turnKeyReminders)
        {
            if (timer == i + 90)
            {
                MessageBox.Show("Turn the key in 90 seconds", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            if (timer == i + 60)
            {
                MessageBox.Show("Turn the key in 60 seconds", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            if (timer == i + 30)
            {
                MessageBox.Show("Turn the key in 30 seconds", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public void addTurnKeyReminder(int time)
    {
        turnKeyReminders.Add(time);
    }

    public void setTimer(int timer)
    {
        this.timer = timer;
    }

    public int lastDigitOfSerial()
    {
        return int.Parse(bomb.serial[5].ToString());
    }

    public void SelectModule(string Module)
    {
        switch (Module)
        {
            case "Button":
                Program.switchForm(new frmButton());
                break;
            case "Turn the key":
                Program.switchForm(new frmTurnTheKey());
                break;
            case "Wires":
                Program.switchForm(new frmWires());
                break;
        }
    }

    public void addStrike()
    {
        strikes++;
    }

    public int getStrikes()
    {
        return strikes;
    }

    public Bomb getBomb()
    {
        return bomb;
    }


    public void setBomb(Bomb b)
    {
        bomb = b;
    }
    
    public bool litCAR()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "CAR" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    
    public bool unlitCAR()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "CAR" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litSND()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "SND" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitSND()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "SND" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litCLR()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "CLR" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    
    public bool unlitCLR()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "CAR" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litIND()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "IND" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitIND()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "IND" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litFRQ()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "FRQ" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitFRQ()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "FRQ" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litSIG()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "SIG" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitSIG()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "SIG" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litNSA()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "NSA" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitNSA()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "NSA" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litMSA()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "MSA" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitMSA()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "MSA" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litTRN()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "TRN" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitTRN()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "TRN" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litBOB()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "BOB" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitBOB()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "BOB" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool litFRK()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "FRK" & i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
    public bool unlitFRK()
    {
        foreach (var i in bomb.indicators)
        {
            if (i.name == "FRK" & !i.lit & i.visible)
            {
                return true;
            }
        }

        return false;
    }
}