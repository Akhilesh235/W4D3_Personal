using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Personal
{

    public delegate void HelloFunctionDelegate(string Message);
    class Program
    {
        public static void Main(string[] args)
        {
            //// A delegate is a type safe function pointer
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from Delegate");
        }




        static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
            Console.ReadLine();
        }

    }

   
}
