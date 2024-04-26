using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ManagmentInfoSystem.Business.Contracts;
using ManagmentInfoSystem.Business.Models;

namespace ManagmentInfoSystem.Business
{
    public class DepartmentManager : IManager<Department>
    {
        private readonly string _connectionString;
        public DepartmentManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;
        }

        public string Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Department WHERE StudentId = @studentId", con))
                {
                    try
                    {
                        cmd.Parameters.Add(new SqlParameter("@studentId", id));
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                }
            }
            return "Record deleted successfully";
        }

        public IEnumerable<Department> Get()
        {
            var response = new List<Department>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Department", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            try
                            {
                                sda.Fill(dt);
                                response = (from DataRow dr in dt.Rows
                                            select new Department
                                            {
                                                Id = Convert.ToInt32(dr["Id"]),
                                                Name = dr["Name"].ToString()
                                            }).ToList();
                            }
                            catch (Exception e)
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            return response;
        }

        public Department Get(int id)
        {
            var response = new Department();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Department WHERE id = @id", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            try
                            {
                                cmd.Parameters.Add(new SqlParameter("@id", id));
                                sda.Fill(dt);
                                response = new Department
                                {
                                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                                    Name = dt.Rows[0]["Name"].ToString()
                                };
                            }
                            catch (Exception e)
                            {

                                throw;
                            }
                        }
                    }
                }
            }
            return response;
        }

        public int Insert(Department item)
        {
            int resp;
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Department (Name) VALUES (@name)", con))
                {
                    try
                    {
                        cmd.Parameters.Add(new SqlParameter("@name", item.Name));
                        con.Open();
                        resp = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        resp = 0;
                    }
                }
            }
            return resp;
        }

        public string Update(Department item)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Department SET Name = @name WHERE Id = @id", con))
                {
                    try
                    {
                        cmd.Parameters.Add(new SqlParameter("@id", item.Id));
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                }
            }
            return "Record updated successfully";
        }
    }
}
