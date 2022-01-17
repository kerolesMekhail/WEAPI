using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WE_Test.Data.Model
{
    public class emp_data
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Emp_id { get; set; }
        [MaxLength(100)]
        public string Type { get; set; }
        [MaxLength(200)]
        public string Emp_name { get; set; }
        [MaxLength(200)]
        public string Emp_job { get; set; }
    }
}
