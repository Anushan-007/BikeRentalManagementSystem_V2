using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagement_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Repo = new BikeRepository();

            var status = true;
            while (status)
            {
                Console.WriteLine("................................");
                Console.WriteLine("Bike Rental Management System: ");
                Console.WriteLine("1. Add a Bike: ");
                Console.WriteLine("2. View All Bikes: ");
                Console.WriteLine("3. Update a Bike: ");
                Console.WriteLine("4. Delete a Bike: ");
                Console.WriteLine("5. Exit: ");
                Console.Write("Choose an option: ");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Repo.CreateBike();
                        break;
                    case "2":
                        Repo.ReadBikes();
                        break;
                    case "3":
                        Repo.UpdateBike();
                        break;
                    case "4":
                        Repo.DeleteBike();
                        break;
                    case "5":
                        status = false;
                        break;
                    default:
                        Console.Clear();
                        Menu();
                        break;
                }

            }
        }
    }
}