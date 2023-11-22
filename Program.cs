using System;


namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            Console.WriteLine("Enter the Empoyee id:");
            id = int.Parse(Console.ReadLine());

            string name;
            Console.WriteLine("Enter the Employee Name:");
            name = (Console.ReadLine());

            string gender;
            Console.WriteLine("Enter the gender");
            gender = (Console.ReadLine());

            float salary;
            Console.WriteLine("Enter the salary");
            salary = float.Parse(Console.ReadLine());

            DateTime doj;
            Console.WriteLine("Enter the date of joining");
            doj =DateTime.Parse(Console.ReadLine());

            if(salary>90000)
            {
                double tax = salary * 0.3;
                Console.WriteLine("You have to pay "+tax+"tax");
            }
            else
            {
                double tax = salary * 0.15;
                Console.WriteLine("You have to pay "+tax+"tax");
            }

            Console.ReadKey();

        }
    }
}
