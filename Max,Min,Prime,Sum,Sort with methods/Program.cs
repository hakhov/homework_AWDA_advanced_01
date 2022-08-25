//Մեթոդների կիրառմամբ ստեղծել զանգվածի ստացման ավտոմատ և մանուալ տարբերակներ։
//Գտնել Max, Min, Sum, Prime, Sort գաղափարները։ Ինչպես նաև տպելու տարբեր հնարավորույթուններ։
using Max_Min_Prime_Sum_Sort_with_methods;


Console.WriteLine("Enter 0 for auto or 1 for manual");
Console.Write("number=");
int number=int.Parse(Console.ReadLine());
if (number == 0)
{
    Matrix m1 = new();
    m1.SetAuto();
}
else
{
    Matrix m2 = new();
    m2.SetManual();
}
