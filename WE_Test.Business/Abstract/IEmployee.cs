using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WE_Test.Data.Model;
using WE_Test.Repository.Contract;

namespace WE_Test.Business.Abstract
{
    public interface IEmployee : IRepository<emp_data>
    {
    }
}
