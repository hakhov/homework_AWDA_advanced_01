using System;

namespace _00String
{
    class Program
    {
        static void Main(string[] args)
        {
            string myText = "Yes, this is my city this";
            string str1 = "this";
            string str2 = "Yerevan";
            //Console.WriteLine(IsEqual(str1, str2));
            //Console.WriteLine(_Equals(str1, str2));
            Console.WriteLine(_MyReplase(myText,str1,str2));


            bool _Equals(string s1, string s2)
            {
                return s1.Equals(s2);
            } //Equals method
            int IsEqual(string s1, string s2)
            {
                //return s1.CompareTo(s2);
                foreach (char item1 in s1)
                {
                    foreach (char item2 in s2)
                    {
                        if (item1.Equals(item2))
                        {
                            break;
                        }
                        else if (item1 > item2)
                        {
                            return 1;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    s2 = s2.Substring(1);
                    Console.WriteLine($"s2 is {s2}\ns1 is {s1}");
                }
                return 0;
            } //CompareTo method

            string _MyReplase(string text,string s1, string s2)
            {
                int size = s1.Length;
                if (text.Contains(s1))
                {
                    for (int i = 1; i <= text.Length-size; i++)
                    {
                        if(text.Substring(i-1,size)== s1)
                        {  
                            text = text.Substring(0,i-1) + s2 + text.Substring(i+size);
                        }
                    }
                }
                return text;
            } //Replace own method
            //  string _MyInsert(string text,string str, int startIndex)
            //{
            //    if (startIndex <= text.Length - 1)
            //    {
            //        text = text.Substring(0, startIndex) + str + text.Substring(startIndex + 1);
            //    }
            //    else
            //    {
            //        return text;
            //    }
            //}
        }




    }
}
