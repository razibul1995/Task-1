using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Course> course { get; set; }
        public Department department { get; set; }
        
        
    }
}
