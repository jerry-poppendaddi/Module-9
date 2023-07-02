using System;
using System.Runtime.ExceptionServices;

namespace ExceptionPractice;

class Program
{
    static void Main(string[] args)
    {
        Exception[] exceptions = new Exception[5];

        exceptions[0] = new ArgumentOutOfRangeException("Argument is out of range");
        exceptions[1] = new DivideByZeroException("You cannot divide by zero");
        exceptions[2] = new ArgumentNullException("The value of your parameter is null");
        exceptions[3] = new PathTooLongException("The path to the file is too long");
        exceptions[4] = new Exception();

        for (int i = 0; i < exceptions.Length; i++)
        {
            try
            {
                Exception ex = exceptions[i];
                Console.WriteLine(ex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
               
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
               
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                
            }
            catch (FormatException)
            { }
        }
    }
}



    
  
        
 




