LinkedList<string> mylist = new LinkedList<string>();
mylist.AddLast("Gayane Tsaturyan");
mylist.AddLast("Anush Manukyan");
mylist.AddLast("Ararat Yesayan");

start: Console.Write("Please enter your name and sourname - ");
string name=Console.ReadLine();

foreach (string item in mylist)
{
    if (item == name)
    {
        Console.Clear();
        goto start;
    }    
}
Console.Write("Please enter your mail - ");
string mail = Console.ReadLine();
Console.Write("Please enter your phone number - ");
int number = int.Parse(Console.ReadLine());

UsingSMSDelegat usingSMSDelegat = (string method, string name, int usincode) => { Console.WriteLine(method + " " + name + "\nThis is your code - " + usincode); };

string UsingSMS() => "Thank you";
int UsingCode() => number + (number - 1111);
Console.WriteLine("-------------------------------------------------------------------------");
usingSMSDelegat(UsingSMS(), name, UsingCode());
delegate void UsingSMSDelegat(string method,string name,int usingcode);

