using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WE_Test.Data.Model;

namespace WE_Test.Business.Mapper
{
    public class AutoMapperMap:Profile
    {
        public AutoMapperMap()
        {
            //CreateMap<List<emp_data>, List<emp_dataDTO>>().ReverseMap();
        }

    }
}
