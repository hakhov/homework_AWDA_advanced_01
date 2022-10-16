

abstract class Maker
{
    private void addSugger()
    {Console.WriteLine("Adding sugger!");}
    private void boilWater()
    {Console.WriteLine("Boiling Water!");}
    private void addCup()
    {Console.WriteLine("Adding cup!");}
    private void addSpoon()
    { Console.WriteLine("Adding Spoon!"); }
    public void RecipeMaker()
    {
        Console.WriteLine("Welcome to my range!\nStart");
        add();
        addCup();
        addSugger();
        addSpoon();
        boilWater();
        addSticker();
        Console.WriteLine("You finished");
    }
    public abstract void add();
    public abstract void addSticker();
}

