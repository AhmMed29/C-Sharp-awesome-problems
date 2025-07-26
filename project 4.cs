// This is the class of our linked list ( The implementation in main is below !)

using System;
using System.Linq.Expressions;

public class DynamicArray
{
	public int size;
	public int capacity = 10;
	object[] array;

	public DynamicArray()
	{
		this.array = new object[capacity]; // the size by default is 10
	}
    public DynamicArray(int capacity)
    {
		this.capacity = capacity;
        this.array = new object[capacity];
    }
	public void Add(object item)
	{
        if(size >= capacity)
        {
            grow();
        }
        array[size] = item;
        size++;
	}
    public void insert(int index, object item)
    {
        if(size >= capacity)
        {
            grow();
        }
        for(int i = size; i > index; i--)
        {
            array[i] = array[i - 1];
        }
        array[index] = item;
        size++;
    }
    public void Delete(object item)
    {
        for (int i = 0; i < size; i++)
        {
            if (array[i] == item)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    array[i + j] = array[i + j + 1];
                }
                if(size > 0)
                {

                }
                array[size - 1] = null;
                size--;
                if (size <= (int) (capacity / 3))
                {
                    shrink();
                }
                break; // exit the loop after deleting the item
            }
        }
        
    }
    public int Search(object item)
    {
        for(int i=0;i<size;i++)
        {
            if (array[i] == item)
            {
                return i;
            }
        }
        return -1;
    }
    public void grow()
    {
        int newcapacity = (int)(capacity * 2);
        object[] newArrray = new object[newcapacity];
        for (int i = 0;i < size;i++)
        {
            newArrray[i] = array[i];
        }
        capacity = newcapacity; // update the capacity
        array = newArrray; // update the array reference to the new array
    }
    public void shrink()
    {
        int newcapacity = (int)(capacity / 2);
        object[] newArrray = new object[newcapacity];
        for (int i = 0; i < size; i++)
        {
            newArrray[i] = array[i];
        }
        capacity = newcapacity; // update the capacity
        array = newArrray; // update the array reference to the new array
    }
    public bool isEmpty()
    {
        return size == 0 ? true : false ; 
    }
    public string toString()
    {
        // this for displaying the array elements
        string strng = "";
        for(int i=0;i<size;i++)
        {
            strng += array[i] + ", ";
        }
        if(strng != "") // لو الاسترنج مش فاضي يعني فيه عنصر 
        {
            /*
                 دي بتقص الاسترنج بتاعنا لحد نقطه معينه للي هي الطول ناقص اتنين substringعندنا ميثود اسمها 
                 للي هما الفاصله والمسافه اللي في الاخر
            */
            strng = "[" +strng.Substring(0, strng.Length - 2) + "]" ;
        }
        else
        {
            strng = "[]"; // لو الاسترنج فاضي يبقي مفيش عناصر في المصفوفه
        }
            return strng;
    }
}

// =================== The Code below is in other (basic) class (Program) ====================

namespace learning;
class Program
{
    static void Main(string[] args)
    {
        DynamicArray dynamicarr = new DynamicArray();
        
        // adding elements to the dynamic array ===

        dynamicarr.Add("A");
        dynamicarr.Add("M");
        dynamicarr.Add("G");
        dynamicarr.Add("Z");
        dynamicarr.Add("W");

        // dynamicarr.Add("G"); // grow method will be called here 

        //dynamicarr.insert(0, "X");
        //dynamicarr.Delete("X");
        //Console.WriteLine(dynamicarr.Search("Ahmed"));

        // here we will delete an item to use the shrink method
        dynamicarr.Delete("Z");
        dynamicarr.Delete("A");
        dynamicarr.Delete("G");

        Console.WriteLine(dynamicarr.toString());
        Console.WriteLine("Size : " + dynamicarr.size);
        Console.WriteLine("capacity : " + dynamicarr.capacity);
        Console.WriteLine("empty : " + dynamicarr.isEmpty());
    }
}