using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Acme.Data.Entity;

namespace Acme.Data.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        public int Add(Customer obj)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString());
            SqlCommand cmd = new SqlCommand();

            connection.Open();

            cmd.CommandText = "Insert into Customer values(@name,@mobile,@city)";
            cmd.Parameters.AddWithValue("@name", obj.Name);
            cmd.Parameters.AddWithValue("@mobile", obj.Mobile);
            cmd.Parameters.AddWithValue("@city", obj.City);

            cmd.Connection = connection;

            int i = cmd.ExecuteNonQuery();  // used to execute dml statement
            connection.Close();

            return i;
        }

        public int Delete(int id)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString());
            SqlCommand cmd = new SqlCommand();
            try
            {
                connection.Open();

                cmd.CommandText = "Delete Customer where id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = connection;

                int i = cmd.ExecuteNonQuery();
                return i;

            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
            }
            return 0;
        }

        public IEnumerable<Customer> GetAll()
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.Open();
                cmd.CommandText = "Select * from Customer";
                cmd.Connection = con;
                SqlDataReader reader = cmd.ExecuteReader();
                List<Customer> lstCustomer = new List<Customer>();
                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.Id = Convert.ToInt32(reader["Id"]);
                    customer.Name = Convert.ToString(reader["Name"]);
                    customer.City = Convert.ToString(reader["City"]);
                    customer.Mobile = Convert.ToString(reader["Mobile"]);
                    lstCustomer.Add(customer);
                }
                return lstCustomer.AsEnumerable();

            }
            catch (Exception ex)
            { }
            finally
            {
                con.Close();
            }

            return null;
        }

        public Customer GetById(int id)
        {
            SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString());
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();
                cmd.CommandText = "Select * from Customer where id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.Id = Convert.ToInt32(reader["Id"]);
                    customer.Name = Convert.ToString(reader["Name"]);
                    customer.City = Convert.ToString(reader["City"]);
                    customer.Mobile = Convert.ToString(reader["Mobile"]);
                    return customer;
                }

            }
            catch (Exception ex)
            { }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public int Update(Customer obj)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString());
            SqlCommand command = new SqlCommand();
            try
            {
                connection.Open();
                command.CommandText = "Update Customer set name=@name, city =@city, mobile=@mobile where id=@id";
                command.Parameters.AddWithValue("@name", obj.Name);
                command.Parameters.AddWithValue("@city", obj.City);
                command.Parameters.AddWithValue("@mobile", obj.Mobile);
                command.Parameters.AddWithValue("@id", obj.Id);
                command.Connection = connection;

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }
            finally
            {
                connection.Close();
            }
            return 0;
        }
    }
}
