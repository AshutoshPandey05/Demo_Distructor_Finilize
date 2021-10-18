using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Destructor_Finalize
{
   public class MyClass1
    {
        public void Display_Msg()
        {
            Console.WriteLine("Inside Display Method()");
        }
       public MyClass1 ()
        {
            Console.WriteLine("Default Constructor..");
        }
       public MyClass1 ( string msg)
        {
            Console.WriteLine("Parametrized Constructor with a Message {0}", msg);
        }
        ~MyClass1()
        {
            Console.WriteLine("Freeing up Resources...");
        }
        public void Dispose()
        {
            Console.WriteLine("Freeing Up Resouces using Dispose");
            GC.SuppressFinalize(this);
        }
    }
}
