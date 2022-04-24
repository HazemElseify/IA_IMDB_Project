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
        // function for geting all the movies stored in the database
        public static List<Movie> GetMoveis()
        {
            List<Movie> ret = new List<Movie>();
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IAPROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection c = new SqlConnection(connectionString);
            string sqlquery = "select * from CarClasses";
            SqlCommand command = new SqlCommand(sqlquery, c);
            c.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ret.Add(new Movie
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        desc = reader.GetString(2),
                        genre = reader.GetString(3),
                        imge = reader.GetString(4)
                    });
                }
            }
            c.Close();
            return ret;
        }
        // function for insert new movie into the database
        public static void insertMovie(Movie m)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IAPROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection c = new SqlConnection(connectionString);
            string sqlquery = "insert into movie values (@name,@desc,@gerens,@img)";
            SqlCommand command = new SqlCommand(sqlquery, c);
            command.Parameters.AddWithValue("@name", m.name);
            command.Parameters.AddWithValue("@desc", m.desc);
            command.Parameters.AddWithValue("@gerens", m.genre);
            command.Parameters.AddWithValue("@img", m.imge);
            c.Open();
            command.ExecuteNonQuery();
            c.Close();
        }
        //function for delete movie from the database
        public static void deleteMovie(int id)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IAPROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection c = new SqlConnection(connectionString);
            string sqlquery = "delete from movie where Id = @Id";
            SqlCommand command = new SqlCommand(sqlquery, c);
            command.Parameters.AddWithValue("@Id", id);
            c.Open();
            command.ExecuteNonQuery();
            c.Close();
        }
        // functio for update movie data in the database
        public static void updateMovie(Movie m)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IAPROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection c = new SqlConnection(connectionString);
            string sqlquery = "UPDATE movie SET [name] = @name, [desc] = @desc, [gerens] = @gerens, [img] =@img WHERE [Id] = @Id";
            SqlCommand command = new SqlCommand(sqlquery, c);
            command.Parameters.AddWithValue("@name", m.name);
            command.Parameters.AddWithValue("@desc", m.desc);
            command.Parameters.AddWithValue("@gerens", m.genre);
            command.Parameters.AddWithValue("@img", m.imge);
            command.Parameters.AddWithValue("@Id", m.id);
            c.Open();
            command.ExecuteNonQuery();
            c.Close();
        }
        public static List<Actors> GetActors()        {            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IAPROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";            List<Actors> ret = new List<Actors>();            SqlConnection c = new SqlConnection(connectionString);            string sqlquery = "select * from actor";            SqlCommand command = new SqlCommand(sqlquery, c);            c.Open();            SqlDataReader reader = command.ExecuteReader();            if (reader.HasRows)            {                while (reader.Read())                {                    ret.Add(new Actors
                    {
                        id = reader.GetInt32(0),
                        Fname = reader.GetString(1),
                        Lname = reader.GetString(2),
                        age = reader.GetInt32(3),
                        imge = reader.GetString(4),
                    });                }            }            return ret;        }
        public static void updateActor(Actors A)        {            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IAPROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";            SqlConnection c = new SqlConnection(connectionString);            string sqlquery = "UPDATE actor SET [Fname] = @Fname, [Lname] = @Lname, [Age] = @Age, [img] =@img WHERE [Id] = @Id";            SqlCommand command = new SqlCommand(sqlquery, c);            command.Parameters.AddWithValue("@Fname", A.Fname);            command.Parameters.AddWithValue("@Lname", A.Lname);            command.Parameters.AddWithValue("@Age", A.age);            command.Parameters.AddWithValue("@img", A.imge);            command.Parameters.AddWithValue("@Id", A.id);            c.Open();            command.ExecuteNonQuery();            c.Close();        }

        public static void deleteActor(int id)        {            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IAPROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";            SqlConnection c = new SqlConnection(connectionString);            string sqlquery = "delete from actor where Id = @Id";            SqlCommand command = new SqlCommand(sqlquery, c);            command.Parameters.AddWithValue("@Id", id);            c.Open();            command.ExecuteNonQuery();            c.Close();        }
    }
}