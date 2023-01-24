using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Practice Problems!!!");
            Console.WriteLine("\n1. Enter valid First Name");
            Console.WriteLine("2. Enter valid Last Name");
            Console.WriteLine("3. Enter valid email");
            Console.WriteLine("4. Enter Mobile number along with country code");
            Console.WriteLine("5. Minimum 8 character password");
            Console.WriteLine("6. Password previous condition with atleast 1 upper case");
            Console.WriteLine("7. Password previous conditions with atleast 1 numeric number");
            Console.WriteLine("8. Password all previous conditions with exactly 1 special character");
            Console.WriteLine("9. Test all the sample emails provided separately");
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
                case 2:
                    Console.Write("Enter Your Last Name : ");
                    string LastName = Console.ReadLine();
                    Console.WriteLine(validate1.ValidateLastName(LastName));
                    break;
                case 3: 
                    Console.Write("Enter Your Email : ");
                    string email = Console.ReadLine();
                    Console.WriteLine(validate1.ValidateEmail(email));
                    break;
                case 4:
                    Console.Write("Enter Your Phone Number : ");
                    string PhoneNumber = Console.ReadLine();
                    Console.WriteLine(validate1.ValidateMobile(PhoneNumber));
                    break;
                case 5:
                    Console.WriteLine("Enter Your Password");
                    string password = Console.ReadLine();
                    Console.WriteLine(validate1.ValidatePassword1(password));
                    break;
                case 6:
                    Console.WriteLine("Enter Your Password");
                    string password2 = Console.ReadLine();
                    Console.WriteLine(validate1.ValidatePassword1(password2));
                    break;
                case 7:
                    Console.WriteLine("Enter Your Password");
                    string password3 = Console.ReadLine();
                    Console.WriteLine(validate1.ValidatePassword1(password3));
                    break;
                case 8:
                    Console.WriteLine("Enter Your Password");
                    string password4 = Console.ReadLine();
                    Console.WriteLine(validate1.ValidatePassword1(password4));
                    break;
                case 9:
                   // Validate validate1 = new Validate();
                    validate1.Test();
                    break;
                default:
                    Console.WriteLine("Please enter correct choice");
                    break;

            }
        }
    }
}