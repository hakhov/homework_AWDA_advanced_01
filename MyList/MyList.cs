using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyList
{
    public class MyList<T>
    {
        private T[] data;
        private int size = 0;
        private int capacity ;
        public MyList(int initialCapacity=10)
        {
            if (initialCapacity<1)
            {
                capacity = 1;
            }
               this.capacity= initialCapacity;
            data= new T[capacity];
        }

        public MyList(T[] values)
        {
            //for (int i = 0; i < values.Length; i++)
            //{
            //    size = values.Length;
            //    data[i] = values[i];
            //}
            data= values;
        }
        public int Size { get { return size; }  }
        public bool IsEmpty { get { return size == 0;} }

        public T GetAtElement(int index)
        {
            ThrowIndexOutOfRange(index);
            return data[index];
        }
        public void SetAtElement(int index, T element)
        {
            ThrowIndexOutOfRange(index);
            data[index] = element;
        }
        public void Add(T item)
        {
            if (size==capacity)
            {
                resize();
               
            }
            data[size++] = item;
        }

        private void resize()
        {
            T[] resizedArray = new T[capacity*2];
            for (int i = 0; i < capacity; i++)
            {
                resizedArray[i] = data[i];
                //size++;
            }
            data = resizedArray;
            capacity = capacity * 2;
            
        }

        private void ThrowIndexOutOfRange(int index)
        {
            if (index > size-1  || index<0)
            {
         
                throw new ArgumentOutOfRangeException("invalid index");
               

            }
        }
        public void InsertAtElement(int index, T item)
        {
            ThrowIndexOutOfRange(index);
            if (size == capacity) 
                resize();
            else if (size <= capacity)
            {
                size = capacity;
            }
            for (int i = size; i > index; i--)
            {
                data[i] = data[i - 1];
            }
            data[index] = item;
            size++;

        }
        public void DeleteAtElement(int index)
        {
            ThrowIndexOutOfRange(index);
            T[] resizedArray = new T[size-1];
            for (int i = index; i < size-1; i++)
            {
                data[i] = data[i++];
                
            }
            for (int i = 0; i < resizedArray.Length; i++)
            {
                resizedArray[i] = data[i];
            }
            data = resizedArray;
            capacity= capacity--;
            
           
        }
        //public bool Contains(T item)
        //{
        //    if (data is not null)
        //    {
        //        for (int i = 0; i < data.Length; i++)
        //        {
        //            if (data[i]==item)
        //            {
        //            }
        //        }
        //    }
        //    return false;
        //}
        public void Clear() { }

        //public int CompareTo(MyList<T>? other)
        //{
        //    if (other != null)
        //    {
        //        for (int i = 0; i < other.data.Length; i++)
        //        {
        //            if (other.data[i] == this.data[i])
        //            {
        //                return 0;
        //            }
        //        }

        //    }
        //    throw new NotImplementedException();
        //}
        //public static MyList<T> operator = (MyList<T>  d, MyList<T> d1) 
        //{
        //    if (d.data is not null && d1.data is not null)
        //    {
        //        for (int i = 0; i < d.data.Length; i++)
        //        {
        //            for (int j = 0; j < d1.data.Length; j++)
        //            {
        //                if (d.data[i] == d1.data[j])
        //                {
        //                    return 
        //                }
        //            }
                   
        //        }
        //    }
        //} 
    }
}
