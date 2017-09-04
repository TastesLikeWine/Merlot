using System;

namespace Conditional

{
   
   
    class Program
    {
        static void Main()
                   
            {
            Console.WriteLine("Please enter a number Between 1 and 10");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter a number Between 1 and 10");
            int num2 = Convert.ToInt16(Console.ReadLine());


            if (num < num2 ) 
            {
                Console.WriteLine("{0} is less than {1}", num, num2) ;
             }
            if (num == num2)
            {
                Console.WriteLine("{0} is the same as {1}", num, num2);
            }
            else 
            {
                Console.WriteLine("{0} is larger than {1}", num, num2);
            }





            Console.Read();
        }
    }
}
