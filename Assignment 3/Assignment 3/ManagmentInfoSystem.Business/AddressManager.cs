using ManagmentInfoSystem.Business.Contracts;
using ManagmentInfoSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ManagmentInfoSystem.Business
{
    public class AddressManager : IManager<Address>
    {
        private readonly string _connectionString;
        public AddressManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;
        }

        public string Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Address WHERE StudentId = @id", con))
                {
                    try
                    {
                        cmd.Parameters.Add(new SqlParameter("@id", id));
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

        public IEnumerable<Address> Get()
        {
            var response = new List<Address>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Address", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            response = (from DataRow dr in dt.Rows
                                        select new Address
                                        {
                                            Id = Convert.ToInt32(dr["Id"]),
                                            Line1 = dr["Line1"].ToString(),
                                            Line2 = dr["Line2"].ToString(),
                                            City = dr["City"].ToString(),
                                            State = dr["State"].ToString(),
                                            ZipCode = dr["ZipCode"].ToString(),
                                            StudentId = Convert.ToInt32(dr["StudentId"])
                                        }).ToList();
                        }
                    }
                }
            }
            return response;
        }

        public Address Get(int id)
        {
            var response = new Address();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Address WHERE StudentId = @id", con))
                {
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            response = new Address
                            {
                                Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                                Line1 = dt.Rows[0]["Line1"].ToString(),
                                Line2 = dt.Rows[0]["Line2"].ToString(),
                                City = dt.Rows[0]["City"].ToString(),
                                State = dt.Rows[0]["State"].ToString(),
                                ZipCode = dt.Rows[0]["ZipCode"].ToString()
                            };
                        }
                    }
                }
            }
            return response;
        }

        public int Insert(Address item)
        {
            int resp;
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Address (StudentId, Line1, Line2, City, State, ZipCode) VALUES (@studentId, @line1, @line2, @city, @state, @zipCode); SELECT SCOPE_IDENTITY();", con))
                {
                    try
                    {
                        cmd.Parameters.Add(new SqlParameter("@studentId", item.StudentId));
                        cmd.Parameters.Add(new SqlParameter("@line1", item.Line1));
                        cmd.Parameters.Add(new SqlParameter("@line2", item.Line2));
                        cmd.Parameters.Add(new SqlParameter("@city", item.City));
                        cmd.Parameters.Add(new SqlParameter("@state", item.State));
                        cmd.Parameters.Add(new SqlParameter("@zipCode", item.ZipCode));
                        con.Open();
                        resp = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        resp = 0;
                    }
                }
            }
            return resp;
        }

        public string Update(Address item)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"UPDATE Address SET Line1 = @line1,
                    Line2 = @line2,
                    City = @city,
                    State = @state,
                    ZipCode = @zipCode
                    WHERE StudentId = @studentId", con))
                {
                    try
                    {
                        cmd.Parameters.Add(new SqlParameter("@line1", item.Line1));
                        cmd.Parameters.Add(new SqlParameter("@line2", item.Line2));
                        cmd.Parameters.Add(new SqlParameter("@city", item.City));
                        cmd.Parameters.Add(new SqlParameter("@state", item.State));
                        cmd.Parameters.Add(new SqlParameter("@zipCode", item.ZipCode));
                        cmd.Parameters.Add(new SqlParameter("@studentId", item.StudentId));
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
