using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal GPA { get; set; }
        public List<Courses> Courses { get; set; }
    }

    public class Courses
    {
        public string Name { get; set; }
        public int Credit { get; set; }
    }
}
