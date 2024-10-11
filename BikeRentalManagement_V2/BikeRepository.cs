using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BikeRentalManagement_V2
{
    internal class BikeRepository
    {
        static string ConnectionString = "Server=(localdb)\\MSSQLLocalDB; Initial Catalog=BikeRentalManagement";

        
        public void CreateBike(Bike bike)
            {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "INSERT INTO Bikes(BikeId, Brand, Model, RentalPrice) VALUES(@BikeId, @Brand, @Model, @RentalPrice);";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    Console.WriteLine("Enter the ID");
                    cmd.Parameters.AddWithValue("@BikeId", bike.bikeId);
                    Console.WriteLine("Enter the Brand");
                    cmd.Parameters.AddWithValue("@Brand", bike.Brand);
                    Console.WriteLine("Enter the Model");
                    cmd.Parameters.AddWithValue("@Model", bike.Model);
                    Console.WriteLine("Enter the RentalPrice");
                    cmd.Parameters.AddWithValue("@RentalPrice", bike.RentalPrice);
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Successfully Created");

                }

            }
        }

        //public void ReadBikes()
        //{

        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        string query = "SELECT * FROM Bikes";
        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            SqlDataReader reader = new SqlDataReader()
        //                while (reader.Read())
        //            {
        //                cmd.Parameters.AddWithValue("@BikeId", bike.bikeId);
        //            }
                    
                    



        //        }

        //    }
        //}

    }
}
