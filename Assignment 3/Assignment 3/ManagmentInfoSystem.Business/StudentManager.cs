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
    public class StudentManager : IManager<Student>
    {
        private readonly string _connectionString;
        private readonly IManager<Address> _addressManager;
        private readonly IManager<Department> _departmentManager;

        public StudentManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;
            _addressManager = new AddressManager();
            _departmentManager = new DepartmentManager();
        }

        public string Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(@"DELETE FROM Student WHERE Id = @id", con))
                {
                    try
                    {
                        cmd.Parameters.Add(new SqlParameter("@id", id));
                        _addressManager.Delete(id);
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

        public IEnumerable<Student> Get()
        {
            IEnumerable<Student> response = new List<Student>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Student", con))
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
                                            select new Student
                                            {
                                                Id = Convert.ToInt32(dr["Id"]),
                                                FirstName = dr["FirstName"].ToString(),
                                                LastName = dr["LastName"].ToString(),
                                                DepartmentId = Convert.ToInt32(dr["DepartmentId"])
                                            }).ToList();
                            }
                            catch (Exception ex)
                            {
                                return null;
                            }
                        }
                    }
                }
            }

            var addresses = _addressManager.Get();
            var departments = _departmentManager.Get();
            response = response.Join(
                    addresses,
                    student => student.Id,
                    address => address.StudentId,
                    (student, address) => new { student, address})
                .Join(departments,
                addressJoin => addressJoin.student.DepartmentId,
                department => department.Id,
                (addressJoin, department) => new Student
                {
                    Id = addressJoin.student.Id,
                    FirstName = addressJoin.student.FirstName,
                    LastName = addressJoin.student.LastName,
                    Address = addressJoin.address,
                    Department = department,
                    DepartmentId = addressJoin.student.Id
                }).ToList();

            return response;
        }

        public Student Get(int id)
        {
            var response = new Student();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Department WHERE Id = @id", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            try
                            {
                                sda.Fill(dt);
                                response = new Student
                                {
                                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                                    FirstName = dt.Rows[0]["FirstName"].ToString(),
                                    LastName = dt.Rows[0]["LastName"].ToString()
                                };
                            }
                            catch (Exception ex)
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            response.Address = _addressManager.Get(response.Id);
            response.Department = _departmentManager.Get(response.DepartmentId);
            return response;
        }

        public int Insert(Student item)
        {
            int resp;
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Student (FirstName, LastName, DepartmentId) VALUES (@firstName, @lastName, @departmentId); SELECT SCOPE_IDENTITY();", con))
                {
                    try
                    {
                        cmd.Parameters.Add(new SqlParameter("@firstName", item.FirstName));
                        cmd.Parameters.Add(new SqlParameter("@lastName", item.LastName));
                        cmd.Parameters.Add(new SqlParameter("@departmentId", item.DepartmentId));
                        con.Open();
                        resp = Convert.ToInt32(cmd.ExecuteScalar());
                        if (resp != 0)
                        {
                            item.Address.StudentId = resp;
                            var addrResp = _addressManager.Insert(item.Address);
                            if (addrResp == 0)
                            {
                                Delete(resp);
                                _addressManager.Delete(resp);
                                return 0;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        resp = 0;
                    }
                }
            }
            return resp;
        }

        public string Update(Student item)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(
                    @"UPDATE Student SET FirstName = @firstName, LastName = @lastName, DepartmentId = @departmentId WHERE Id = @id", con))
                {
                    try
                    {
                        cmd.Parameters.Add(new SqlParameter("@firstName", item.FirstName));
                        cmd.Parameters.Add(new SqlParameter("@lastName", item.LastName));
                        cmd.Parameters.Add(new SqlParameter("@departmentId", item.DepartmentId));
                        cmd.Parameters.Add(new SqlParameter("@id", item.Id));
                        con.Open();
                        cmd.ExecuteNonQuery();
                        _addressManager.Update(item.Address);
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
