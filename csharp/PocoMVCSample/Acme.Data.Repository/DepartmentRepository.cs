using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Acme.Data.Entity;

namespace Acme.Data.Repository
{
    public class DepartmentRepository : IRepository<Department>
    {
        public int Add(Department obj)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
                {
                    connection.Open();
                    connection.ChangeDatabase("Acme");
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Insert into Department values(@Name,@Location)";
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@Location", obj.Location);
                    cmd.Connection = connection;
                    int i = cmd.ExecuteNonQuery();
                    return i;
                }

            }

            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            return 0;
        }

        public int Delete(int id)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString());
            SqlCommand cmd = new SqlCommand();
            try
            {
                connection.Open();

                cmd.CommandText = "Delete from Department where id=@id";
                cmd.Parameters.AddWithValue("@name", id);
                cmd.Connection = connection;
                int i = cmd.ExecuteNonQuery();
                return i;
            }

            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return 0;
        }

        public IEnumerable<Department> GetAll()
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString());
            SqlCommand cmd = new SqlCommand();
            try
            {
                connection.Open();

                cmd.CommandText = "Select * from Department";
                cmd.Connection = connection;
                SqlDataReader reader = cmd.ExecuteReader();
                List<Department> lstDepartment = new List<Department>();
                while (reader.Read())
                {
                    Department department = new Department();
                    department.Id = Convert.ToInt32(reader["Id"]);
                    department.Name = Convert.ToString(reader["Name"]);
                    department.Location = Convert.ToString(reader["Location"]);
                    lstDepartment.Add(department);
                }
                return lstDepartment.AsEnumerable();
            }

            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public Department GetById(int id)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString());
            SqlCommand cmd = new SqlCommand();
            try
            {
                connection.Open();

                cmd.CommandText = "Select * from Department where id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = connection;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Department department = new Department();
                    department.Id = Convert.ToInt32(reader["Id"]);
                    department.Name = Convert.ToString(reader["Name"]);
                    department.Location = Convert.ToString(reader["Location"]);
                    return department;
                }
            }

            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public int Update(Department obj)
        {
            throw new System.NotImplementedException();
        }
    }


}