

namespace MyException
{
    public class Input
    {
        string a = "";
        public void inputting()
        {
            Console.WriteLine("please insert text without a");
            try
            {
                a = Console.ReadLine();
            }
            catch (MyException ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("everything is ok");
            }
        }
        public class MyException : Exception
        {
            public string error;

            public MyException(string? a,out string message) : base(a)
            {
                message = "";
                a.ToLower();
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'a')
                    {
                         message = "There is a";
                        break;
                    }
                }
               
               
            }
            public string Message() 
            {
                error = "There is a";
                return error;

            }
            

        }
    }
}
