using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211Lab9
{
    public class Course
    {
        [Required]
        [PrimaryKey]
        public string? CourseId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int? Credit { get; set; }

        public Course()
        {
            CourseId = null;
            Name = null;
            Credit = null;
        }

        public Course(string courseId, string name, int credit)
        {
            CourseId = courseId;
            Name = name;
            Credit = credit;
        }

        public override string ToString()
        {
            return $"Course ID: {CourseId}    Course Name: {Name}    Credits: {Credit}";
        }
    }
}
