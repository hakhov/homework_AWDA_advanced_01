using Explisit_Implisit;

ClassA classA = new ClassA(20,60);
ClassA classB = new ClassA(40,80);
ClassA classA1 = new();
ClassA classA2 = new();
ClassA classA3 = new();
ClassA classA4 = new();
classA1 = classA + classB;
classA2 = classA * classB;
classA3 = classA - classB;
classA4 = classA / classB;

PrintInfo(classA1);
PrintInfo(classA2);
PrintInfo(classA3);
PrintInfo(classA4);

void PrintInfo(ClassA classA)
{
    Console.WriteLine($"{classA.a}\t{classA.b}");
}