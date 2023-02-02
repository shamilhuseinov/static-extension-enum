using System;
namespace test
{
    public class Program
    {
        static void Main()
        {
            User user1 = new User("Shamil", "Huseynov", RegistrationMonth.January,"CFCGHF55");
            Console.WriteLine(user1.GetDetails());
            User user2 = new User("Shamil", "Huseynov", RegistrationMonth.March, "CFJHVGJF55");
            Console.WriteLine(user2.GetDetails());
            User user3 = new User("Shamil", "Huseynov", RegistrationMonth.June, "CGHF");
            Console.WriteLine(user3.GetDetails());
            User user4 = new User("Shamil", "Huseynov", RegistrationMonth.August, "CFCGHDF5");
            Console.WriteLine(user4.GetDetails());
            User user5 = new User("Shamil", "Huseynov", RegistrationMonth.September, "CSFHGJHF55");
            Console.WriteLine(user5.GetDetails());
        }
    }
}