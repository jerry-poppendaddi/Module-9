using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
namespace PracticeEvent;

public delegate void EventList(); //delegate created
public class EventClass
{
    public event EventList SortingAZ;  //creating an event A-Z
    public event EventList SortingZA;  //creating an event Z-A

    public void AZsorting()
    {
        AZSorting();
    }
    public void ZAsorting()
    {
        ZASorting();
    }    
    protected virtual void AZSorting() //Creating Sorting method A-Z
    {
        SortingAZ?.Invoke();
    }
    protected virtual void ZASorting() //Creating sorting method Z-A
    {
        SortingZA?.Invoke();
    }
}
class Program
{
    static void Main(string[] args)
    {
        //Little intro
        Console.WriteLine("Please enter either number 1 or number 2 below:");
        int input = Int32.Parse(Console.ReadLine());
        CheckInput(input);              //Checking input value whether it's 1 or 2
        
        EventClass obj = new EventClass(); //registering methods with their respective events
        obj.SortingAZ += SortingDown;
        obj.SortingZA += SortingUp;
                   
        if (input == 1)
        {
            obj.AZsorting();
        }
        else
        {
            if (input == 2)
            {
                obj.ZAsorting();
            }
        }

        Console.ReadKey();
    }

    public static void SortingUp() //method acting in the Z-A event
    {
        string[] list = new string[5]; //creating an array of names
        list[0] = "Anna";
        list[1] = "Bobby";
        list[2] = "Ciara";
        list[3] = "Howard";
        list[4] = "Sarah";

        Console.WriteLine("Here is your Z-A list:");
        Array.Sort(list);
        Array.Reverse(list);
        foreach (string s in list)
        {
            Console.WriteLine(s);
        }

    }
    public static void SortingDown() //method acting in the A-Z event
    {
        string[] list = new string[5]; //creating an array of names
        list[0] = "Anna";
        list[1] = "Bobby";
        list[2] = "Ciara";
        list[3] = "Howard";
        list[4] = "Sarah";

        Console.WriteLine("This is your A-Z list:");
        Array.Sort(list);
        foreach (string s in list)
        {
            Console.WriteLine(s);
        }
    }
    public class MyPersonalException : Exception  //creating our own Exception
    {
        public MyPersonalException() { }
        public MyPersonalException(string message) : base(String.Format("Invalid input"))
        {

        }
    }
    public static void CheckInput(int input)
    {
      if (input != 1)
        {
            throw new MyPersonalException();
        }
        else
        {
            if (input != 2 )
            {
                throw new MyPersonalException();
            }
        }
    }
}    
