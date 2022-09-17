namespace Absrtact_Drawing
{
    public abstract class Drawing
    {
        public string paper { get; set; }
        public string environment { get; set; }
        public abstract void Draw();
    }


    public class Portrait_Painter:Drawing
    {
        
        public override void Draw()
        {
            Console.WriteLine($"Paint on {paper} in {environment} with mini details");
        }

        
    }

    public class Sea_Painter : Drawing
    {
       
        public override void Draw()
        {
            Console.WriteLine($"Paint on {paper} in {environment} with ocean view");
        }
    }

    public class Nature_Painter : Drawing
    {

        public override void Draw()
        {
            Console.WriteLine($"Paint on {paper} in {environment} with nature view");
        }
    }

}