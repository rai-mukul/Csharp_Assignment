
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
    public class UserManager : IManager<User>
    {
        private readonly string _connectionString;
        public UserManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;
        }

        public IEnumerable<User> Get()
        {
            var response = new List<User>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [User]", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            response = (from DataRow dr in dt.Rows
                                        select new User
                                        {
                                            Id = Convert.ToInt32(dr["Id"]),
                                            UserName = dr["Name"].ToString(),
                                            Password = dr["Password"].ToString()
                                        }).ToList();
                        }
                    }
                }
            }
            return response;
        }

        public string Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public User Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Insert(User item)
        {
            throw new System.NotImplementedException();
        }

        public string Update(User item)
        {
            throw new System.NotImplementedException();
        }
    }
}
