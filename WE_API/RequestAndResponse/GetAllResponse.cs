using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WE_Test.Data.Model;

namespace WE_API.RequestAndResponse
{
    public class GetAllResponse
    {
        public List<emp_data> emp_Datas { get; set; }
        public Dictionary<string, int> arr  { get; set; }
    }
}
