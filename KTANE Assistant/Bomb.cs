namespace KTANE_Assistant;

public struct Bomb
{
    public int batteries;
    public int holders;
    public string serial;
    public Day day;
    public int emptyPlates;
    public Plate[] plates;
    public List<Indicator> indicators;
}

public enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}