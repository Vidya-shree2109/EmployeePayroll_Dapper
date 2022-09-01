using BusinessLayer.Interfaces;
using CommonLayer.Model;
using RepositoryLayer.Interfaces;
using RepositoryLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class EmployeeBL : IEmployeeBL
    {
        IEmployeeRL employeeRL;
        public EmployeeBL(IEmployeeRL employeeRL)
        {
            this.employeeRL = employeeRL;
        }

        public int AddEmployee(EmployeePostModel empPostModel)
        {
            try
            {
                return employeeRL.AddEmployee(empPostModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EmployeeGetModel> GetAllEmp()
        {
            try
            {
                return employeeRL.GetAllEmp();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public int UpdateEmployee(int EmpId, EmployeePostModel empPostModel)
        {
            try
            {
                return employeeRL.UpdateEmployee(EmpId, empPostModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteEmployee(int empId)
        {
            try
            {
                return employeeRL.DeleteEmployee(empId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
