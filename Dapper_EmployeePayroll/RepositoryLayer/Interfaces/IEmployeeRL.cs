using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IEmployeeRL
    {
        public int AddEmployee(EmployeePostModel empPostModel);
        public List<EmployeeGetModel> GetAllEmp();
        public int UpdateEmployee(int EmpId, EmployeePostModel empPostModel);
        public int DeleteEmployee(int empId);

    }
}
