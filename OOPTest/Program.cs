using System;

namespace OOPTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object
            User user = new User();
            user.name = "Narit";
            user.yearofbirth = "2534";
            
            Console.WriteLine($"name : {user.name}, year : {user.yearofbirth}, age : {user.age}");
        }
    }
}
