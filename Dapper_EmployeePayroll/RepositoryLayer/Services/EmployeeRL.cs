using CommonLayer.Model;
using Dapper;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Services
{
    public class EmployeeRL : IEmployeeRL
    {
        private readonly string connetionString;
        public EmployeeRL(IConfiguration configuration)
        {   
            connetionString = configuration.GetConnectionString("EmployeeDapper");
        }

        public int AddEmployee(EmployeePostModel empPostModel)
        {
            SqlConnection sqlConnection = new SqlConnection(connetionString);
            try
            {
                using (sqlConnection)
                {
                    sqlConnection.Open();
                    var sql = "insert into table_EmployeeDapper(FirstName,LastName,Address,Mobile) values(@FirstName,@LastName,@Address,@Mobile)";
                    var result = sqlConnection.Execute(sql, empPostModel);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public List<EmployeeGetModel> GetAllEmp()
        {
            List<EmployeeGetModel> listOfUsers = new List<EmployeeGetModel>();
            SqlConnection sqlConnection = new SqlConnection(connetionString);
            try
            {
                using (sqlConnection)
                {
                    sqlConnection.Open();
                    var sql = "select * from table_EmployeeDapper";
                    var result = sqlConnection.Query<EmployeeGetModel>(sql);
                    return result.ToList();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public int UpdateEmployee(int empId, EmployeePostModel empPostModel)
        {
            SqlConnection sqlConnection = new SqlConnection(connetionString);
            try
            {
                using (sqlConnection)
                {
                    sqlConnection.Open();
                    var sql = ("Update table_EmployeeDapper SET FirstName=@FirstName,LastName=@LastName,Address=@Address,Mobile=@Mobile where Id=" + empId).ToString();
                    var result = sqlConnection.Execute(sql, empPostModel);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteEmployee(int empId)
        {
            SqlConnection sqlConnection = new SqlConnection(connetionString);
            try
            {
                using (sqlConnection)
                {
                    sqlConnection.Open();
                    var sql = $"delete from table_EmployeeDapper Where Id={empId}";
                    var result = sqlConnection.Execute(sql);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
