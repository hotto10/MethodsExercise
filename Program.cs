using System;

public class Class1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a random whole number...");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another random whole number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            MyAdd(num1, num2);
            MySub(num1, num2);

            Console.WriteLine();
            Console.WriteLine("End of Test");
        }

        public static void MyAdd(int num1, int num2)
        {
            int result = (num1 + num2);
            Console.WriteLine($"The sume of {num1} and {num2} is : {result}");
            return;
        }
        public static void MySub(int num1, int num2)
        {
            int result = (num1 - num2);
            Console.WriteLine($"The remainder of {num1} minus {num2} is : {result}");
        }
    }
}
