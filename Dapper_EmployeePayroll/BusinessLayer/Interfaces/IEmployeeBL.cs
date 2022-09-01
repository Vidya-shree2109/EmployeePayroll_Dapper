using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IEmployeeBL
    {
        public int AddEmployee(EmployeePostModel empPostModel);
        public List<EmployeeGetModel> GetAllEmp();

    }
}
