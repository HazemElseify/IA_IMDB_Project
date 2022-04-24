using IA_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IA_Project.Models
{
    public class database
    {
                  public static List<Actors> GetActors()        {            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IAPROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";            List<Actors> ret = new List<Actors>();            SqlConnection c = new SqlConnection(connectionString);            string sqlquery = "select * from actor";            SqlCommand command = new SqlCommand(sqlquery, c);            c.Open();            SqlDataReader reader = command.ExecuteReader();            if (reader.HasRows)            {                while (reader.Read())                {                    ret.Add(new Actors
                    {
                        id = reader.GetInt32(0),
                        Fname = reader.GetString(1),
                        Lname=reader.GetString(2),
                        age=reader.GetInt32(3),
                        imge=reader.GetString(4),
                    });                }            }            return ret;        }
        public static void updateActor(Actors A)        {            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IAPROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";            SqlConnection c = new SqlConnection(connectionString);            string sqlquery = "UPDATE actor SET [Fname] = @Fname, [Lname] = @Lname, [Age] = @Age, [img] =@img WHERE [Id] = @Id";            SqlCommand command = new SqlCommand(sqlquery, c);            command.Parameters.AddWithValue("@Fname", A.Fname);            command.Parameters.AddWithValue("@Lname", A.Lname);            command.Parameters.AddWithValue("@Age", A.age);            command.Parameters.AddWithValue("@img", A.imge);            command.Parameters.AddWithValue("@Id", A.id);            c.Open();            command.ExecuteNonQuery();            c.Close();        }
    }
}