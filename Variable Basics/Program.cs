using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_Basics
{
    class Program
    {
        static void Main()
        {
            var name = "bugs Bunny";
            var age = 25;
            var isRabbit = true;

            //turns out there is a type variable and the system can return the type of variable lol

            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isRabbitType = isRabbit.GetType();

            Console.WriteLine("name is type " + nameType.ToString());
            Console.WriteLine("age is type " + ageType.ToString());
            Console.WriteLine("isRabbit is type " + isRabbitType.ToString());

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("variables and scopes");

            // not possible for to declare the same variable name in the same scope
            //eg 

            //int i = 20;
            //int i = 30;
            //however the is posible because 
            bool completed = false;
            for (int i = 0; i <= 5 && !completed; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
                if (i > 4)
                {
                    completed = true;
                }

            } // the scope for i ends here
            for (int i = 4; i > 0 && completed; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
            }
            Console.ReadKey();
            Console.Clear();
        }
        
    }
}
