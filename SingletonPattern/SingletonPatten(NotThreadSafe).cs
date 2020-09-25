using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{

    // use to create only one reference
    public class Single
    {
        public static Single SingleInstance {get; set;}
        public int Count { get; set; }

        // Always have private constructor.
        private Single()
        {
            Count = 0;
        }

        public static Single GetInstance()
        {
            if (SingleInstance == null)
                SingleInstance = new Single();

            return SingleInstance;
        }
    }

    class SingletonPattern
    {
        public static void Main(String[] args)
        {
            Single singleInstance = Single.GetInstance();
            singleInstance.Count++;
            Console.WriteLine("Count " + singleInstance.Count);

            Single secondSingleInstance = Single.GetInstance();
            secondSingleInstance.Count++;
            Console.WriteLine("Count " + secondSingleInstance.Count);
            // here singleInstance and secondSingleInstance will have same reference
            Console.ReadKey();
        }
       
    }
}
