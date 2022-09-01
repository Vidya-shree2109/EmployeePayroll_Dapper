using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Dapper_EmployeePayroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeBL employeeBL;

        public EmployeeController(IEmployeeBL empBL)
        {
            employeeBL = empBL;
        }

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee(EmployeePostModel empPostModel)
        {
            try
            {
                var result = employeeBL.AddEmployee(empPostModel);
                if (result == 0)
                {
                    return this.BadRequest(new { sucess = false, Message = "Something went wrong while adding Employee!!" });
                }
                return this.Ok(new { sucess = true, Message = "Employee Added Sucessfully..." });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet("GetAllEmployee")]
        public IActionResult GetAllEmployee()
        {
            try
            {
                List<EmployeeGetModel> empList = new List<EmployeeGetModel>();
                var EmpList = employeeBL.GetAllEmp();
                return Ok(new { sucess = true, Message = "Employee's data fetched Successfully...", data = EmpList });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
