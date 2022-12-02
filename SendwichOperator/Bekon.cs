internal class Bekon
{
    public string bekon;
    public Bekon(string bekon)
    { this.bekon = bekon; }
        public static Sendwich operator +(Bread bread, Bekon bekon)
    {
        Sendwich sendwich = new Sendwich();
        sendwich.sendwich += bread.bread + " " + bekon.bekon;
        return sendwich;
    }

}
