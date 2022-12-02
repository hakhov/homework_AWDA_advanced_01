internal class Classes
{
    public int Count;
    public double Area;
    public Classes(int count,double area)
    {
        Count = count;
        Area = area;    
    }
    public Classes()
    {
         
    }
    public void Answer()
    {
        Console.WriteLine($"Student count : {Count}\nClasses area : {Area}");
    }
    public static Classes operator +(Classes classA, Classes classB)
    {
        Classes classAll = new Classes();
        classAll.Count = classA.Count + classB.Count;
        classAll.Area = classA.Area + classB.Area;
        return classAll;
    }

    public static bool operator >(Classes classA, Classes classB)
    {
        if (classA.Count > classB.Count)
            return true;
        else
            return false;
    }
    public static bool operator <(Classes classA, Classes classB)
    {
        if (classA.Count < classB.Count)
            return true;
        else
            return false;
    }
}
