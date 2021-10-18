using System;

namespace Demo_Destructor_Finalize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Finilizer..");
            MyClass1 obj1 = new MyClass1();
            obj1.Display_Msg();

            //MyClass1 obj2 = new MyClass1("Secret Message");
            //obj2.Display_Msg();

            obj1.Dispose();
        }
    }
}
