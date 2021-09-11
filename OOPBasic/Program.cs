using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vaccine> vaccines = initialVaccine();
            Vaccine vaccine = new Vaccine();
            User user = new User();
            int reserve = 0;

            Console.WriteLine("####################");
            Console.WriteLine("# available vaccines");

            foreach (var item in vaccines)
            {
                Console.WriteLine($"# {item.name} ({item.stock})");
            }

            Console.WriteLine("####################");
            Console.WriteLine();
            Console.Write("Enter fullname : ");
            user.fullname = Console.ReadLine();
            Console.Write("Enter year of birth : ");
            user.yearofbirth = Console.ReadLine();
            Console.Write("Reserve number : ");
            reserve = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("####################");
            Console.WriteLine("# reserve information");

            try
            {
                if (user.age >= 60)
                {
                    vaccine = vaccines.Where(x => x.name == "Astrazeneca").SingleOrDefault();
                    vaccine.reserveVaccine(reserve);

                }
                else
                {
                    vaccine = vaccines.Where(x => x.name == "Sinovac").SingleOrDefault();
                    vaccine.reserveVaccine(reserve);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"# {ex.Message}");
                Console.WriteLine("####################");
                Environment.Exit(0);
            }
            
            Console.WriteLine($"# fullname : {user.fullname}");
            Console.WriteLine($"# age : {user.age}");
            Console.WriteLine($"# vaccine : {vaccine.name}");
            Console.WriteLine($"# reserve : {reserve}");
            Console.WriteLine($"# current stock : {vaccine.stock}");
            Console.WriteLine("####################");

        }

        private static List<Vaccine> initialVaccine()
        {
            List<Vaccine> vaccines = new List<Vaccine>();
            vaccines.Add(new Vaccine()
            {
                name = "Sinovac",
                stock = 100
                
            });
            vaccines.Add(new Vaccine()
            {
                name = "Astrazeneca",
                stock = 10
            });

            return vaccines;
        }
    }
}
