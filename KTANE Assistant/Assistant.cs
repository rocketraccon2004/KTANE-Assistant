namespace KTANE_Assistant;

public class Assistant
{
    public static Assistant? instance;

    public Bomb? bomb;

    public List<string> modules = new()
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
        "Knobs"
    };

    public static void init()
    {
        if (instance == null) instance = new Assistant();
    }
}