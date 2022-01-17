using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WE_API.RequestAndResponse;
using WE_Test.Business.Abstract;
using WE_Test.Data.Model;

namespace WE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _repository;

        public EmployeeController(IEmployee repository)
        {
            _repository = repository;
        }
        [HttpPost("Add")]
        public emp_data Add(emp_data emp_Data)
        {
            try
            {
                return _repository.Add(emp_Data);
            }
            catch
            {
                return new emp_data();
            }
        }
        [HttpPut("Edit")]
        public emp_data Edit(emp_data emp_Data)
        {
            try
            {
                return _repository.Update(emp_Data);
            }
            catch
            {
                return new emp_data();
            }
        }
        [HttpDelete("Delete")]
        public void Delete(int Id)
        {
            try
            {
                var Emp = _repository.GetById(Id);
                if (Emp != null)
                {
                    _repository.Delete(Emp);

                }
            }
            catch
            {
            }
        }
        [HttpGet("GetById")]
        public emp_data GetById(int Id)
        {
            try
            {
                var Emp = _repository.GetById(Id);
                return Emp;
            }
            catch
            {
                return new emp_data();
            }
        }

        [HttpGet("GetAll")]
        public GetAllResponse GetAll(string type)
        {
            GetAllResponse response = new GetAllResponse();
            try
            {
                var newEmployees = _repository.GetAll().Where(x => x.Type == "1").ToList().Count();
                var probationaryStaff = _repository.GetAll().Where(x => x.Type == "2").ToList().Count();
                var existingEmployees = _repository.GetAll().Where(x => x.Type == "3").ToList().Count();
                var localEmployeesForPension = _repository.GetAll().Where(x => x.Type == "4").ToList().Count();
                var Employees = _repository.GetAll().Where(x => x.Type == type).ToList();
                response.arr = new Dictionary<string, int>();
                response.arr["newEmployees"] = newEmployees;
                response.arr["probationaryStaff"] = probationaryStaff;
                response.arr["existingEmployees"] = existingEmployees;
                response.arr["localEmployeesForPension"] = localEmployeesForPension;
                response.emp_Datas = Employees;
                return response;
            }
            catch
            {
                return new GetAllResponse();
            }
        }

    }
}
