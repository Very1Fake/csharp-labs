using System;

namespace Labs
{
    public static class Lab1
    {
        public static void Task1()
        {
            float x = float.Parse(Console.ReadLine());
            float z = float.Parse(Console.ReadLine());

            double b = x * (Math.Atan(z) - Math.Exp(-(x + 3)));
            Console.WriteLine("x = " + x.ToString() + "z = " + z.ToString());
            Console.WriteLine("b = " + b.ToString());
        }
        
        public static void Task2()
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float z = float.Parse(Console.ReadLine());

            double phi = (Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Abs(x - y), x + y)) / (Math.Atan(x) + Math.Atan(z))
                         + Math.Pow(Math.Pow(x, 6) + Math.Pow(Math.Log10(y), 2), 1/3);
            
            Console.WriteLine("Answer is " + phi.ToString());
        }
    }

    class Lab1A
    {
        private const string _password = "4secretpass!";

        public static void Task1()
        {
            byte p = 2, i = 0;
            int result = 1;
            while (i < 10)
            {
                i++;
                result *= p;
                Console.WriteLine($"{p} in degree {i} is equal to {result}");
            }

            i = 0;
            result = 1;
            do
            {
                i++;
                result *= p;
                Console.WriteLine($"{p} in degree {i} is equal to {result}");
            } while (i < 10);
        }
        
        public static void Task2()
        {
            string userInput = "";
            while (true)
            {
                Console.Write("Enter password: ");
                userInput = Console.ReadLine();

                if (userInput == _password) break;
                else Console.WriteLine("Wrong password");
            }
            Console.WriteLine("Correct password. Access granted");
        }
    }
}