using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WE_Test.Business.Abstract;
using WE_Test.Data.Model;
using WE_Test.Repository.Contract;

namespace WE_Test.Business.BL
{
    public class EmployeeServices : IEmployee
    {
        private readonly IRepository<emp_data> _repository;

        public EmployeeServices(IRepository<emp_data> repository)
        {
            _repository = repository;
        }
        public emp_data Add(emp_data entity)
        {
            try
            {
                _repository.Add(entity);
                return entity;
            }
            catch (Exception ex)
            {
                return new emp_data();
            }
        }

        public void Delete(emp_data entity)
        {
            _repository.Delete(entity);
        }

        public IEnumerable<emp_data> GetAll()
        {
            return _repository.GetAll();
        } 
        public IQueryable<emp_data> GetAllEmps()
        {
            return _repository.GetAllEmps();
        }

        public emp_data GetById(int id)
        {
            var Entity = _repository.GetById(id);
            return Entity;
        }

        public emp_data Update(emp_data entity)
        {
           _repository.Update(entity);
           return entity;
        }
    }

}
