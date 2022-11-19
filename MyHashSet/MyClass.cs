   internal class MyClass
{ 
     char first;
     char last;
    bool val = true;
    public int count;
    public MyClass(object? first,object? last,int count)
    {
       this.first = (char)first;
        this.last = (char)last;
        this.count = count;
        
    }
    public  bool MyMethod()
    {
        if ((last - first) > 2)
           return false; 
        else
        return true;
    }
    }

