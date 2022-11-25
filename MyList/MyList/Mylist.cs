using System.Collections;

public class Mylist<T> : IEnumerable<T>
{
    private T[]? data;
    private int size = 0;
    private int capacity;

    public Mylist(int intialCapacity = 10)
    {
        if (intialCapacity < 1) intialCapacity = 1;

        this.capacity = intialCapacity;
        data = new T[intialCapacity];
    }

    public int Size { get { return size; } }
    public bool IsEmpty { get { return size == 0; } }

    public T GetAtElement(int index)
    {
        ThrowIfIndexOutOfRange(index);
        return data[index];
    }

    public void SetAtElement(int index, T newElement)
    {
        ThrowIfIndexOutOfRange(index);
        data[index] = newElement;
    }

    private void ThrowIfIndexOutOfRange(int index)
    {
        if (index > size - 1 || index < 0)
            throw new ArgumentOutOfRangeException("This index iz not vaild");
    }

    public void Add(T item)
    {
        if (size == capacity)
            Resize();

        data[size++] = item;
    }

    private void Resize()
    {
        T[] resizedArray = new T[2 * capacity];
        for (int i = 0; i < capacity; i++)
        {
            resizedArray[i] = data[i];
        }
        data = resizedArray;
        capacity = capacity * 2;
    }

    public void InsertAtElement(int index, T newElement)
    {
        ThrowIfIndexOutOfRange(index);

        if (size == capacity)
            Resize();

        for (int i = size; i > index; i--)
        {
            data[i] = data[i - 1];
        }


        data[index] = newElement;
        size++;
    }

    public void DeleteAtElement(int index)
    {
        ThrowIfIndexOutOfRange(index);

        if (index == size)
        {
            data[index] = default(T);
        }
        else
        {
            for (int i = index; i < size; i++)
            {
                data[i] = data[i + 1];
            }
        }
        size--;
    }

    public bool Contains(T? value)
    {
        for (int i = 0; i < size; i++)
        {
            if (data[i] == value)
            {
                return true;
            }
        }
        return false;
    }

    public void Clear()
    {
        data = new T[10];
        size = 0;
    }

    public void Sort()
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 1; j < size - i; j++)
            {
                if (data[i] > data[j])
                {
                    T temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }
        }
    }

    public void Reverse()
    {

        for (int i = 0; i < size - 1; i++)
        {
            for (int j = size - 1; j > 0; j--)
            {
                T temp = data[i];
                data[i] = data[j];
                data[j] = temp;
            }
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return data.AsEnumerable().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}