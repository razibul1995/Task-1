using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class Department
    {

        public int Id { get; set; }
        public string DeptName { get; set; }
        public List<Student> student { get; set; }
        public List<Course> course { get; set; }



    }
}
