using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Practice Problems!!!");
            Console.WriteLine("\n1. Enter valid First Name");
            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Validate validate1 = new Validate();
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Your First Name : ");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine(validate1.ValidateFirstName(FirstName));
                    break;

                default:
                    Console.WriteLine("Please enter correct choice");
                    break;

            }
        }
    }
}