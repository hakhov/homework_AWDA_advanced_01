

namespace TryCatchInTryCatch
{
    public class Calc
    {
        public void div()
        {
            int first = 0;
            int second;
            Console.Write("Please insert first number => ");
            try
            {
                first = int.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.Write("Please insert second number => ");
            try
            {

                try
                {
                    second = int.Parse(Console.ReadLine());
                    double res = first / second;
                    Console.WriteLine($"result = {res}");
                }
                catch (DivideByZeroException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception)
            {

                throw;
            }



        }
    }

  
}
