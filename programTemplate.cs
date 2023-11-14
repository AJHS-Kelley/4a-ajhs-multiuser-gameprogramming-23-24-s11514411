using System;


namespace MethodParamer
{
    class MethodParamer
    {

        //
        //
        //
        static void MyMethod()
        {
            console.WriteLine("mhm cheeseburger.\n");
        }
        //
        //

        static int DoubleUp()
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it.\n");
            Console.WriteLine("Please enter a number on the next line.\n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            sum *= 2;
            Console.WriteLine(sum);
            return sum;
        }

        //
        static void MakePancakes(int num)
        {
            for (int i = 0; 1 < num; i++)
            {
                Console.WriteLine("One golden, fluffy pancake coming up!\n")
            }
        }

        static void MakeBurger(int num = 1)
        {
            Console.WriteLine("I am going to cook" + num + "hamburgers.\n");
        }

        //
        static void AllMyChildren(string child1, string child2, string child3)
        {
            Console.WriteLine("My favorite child is" + child3);
        }

        //
        //
        static int FindSum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum: " + sum);
            return sum;
        }

        staticvoid Main(string[] args)
        {
            //
            //
            //
            //
            //
            //
            //
            FindSum(1, 5);
            FindSum(9.5, 2.4);
            FindSum(5, 2.5);
        }
    }
}