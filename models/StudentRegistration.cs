using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class StudentRegistration
    {
       

        [Key]
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollDate { get; set; }
        public bool sPaymentComplete { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }
    }
}
