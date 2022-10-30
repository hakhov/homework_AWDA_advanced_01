using System;

namespace Delegate_Verification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your details for register");

            Verification ver = new Verification();

            Console.Write("Your Name is ");
            string name = Console.ReadLine();
            MyDelegate mydelegate = new MyDelegate(ver.MyName);
            mydelegate.Invoke(name);

            Console.Write("Your Lastname is ");
            string lastname = Console.ReadLine();
            MyDelegate mydelegate1 = new MyDelegate(ver.MyLastName);
            mydelegate1.Invoke(lastname);

            Console.Write("Your Number is (e.g +374(10)100-100) - ");
            string number = Console.ReadLine();
            MyDelegate mydelegate2 = new MyDelegate(ver.MyNumber);
            mydelegate2.Invoke(number);

            Console.Write("Your Email is ");
            string email = Console.ReadLine();
            MyDelegate mydelegate3 = new MyDelegate(ver.MyEmail);
            mydelegate3.Invoke(email);
        }
    }
}
