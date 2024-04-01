using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211Lab9
{
    public class CourseManager
    {
        private SQLiteConnection database;

        public CourseManager()
        {
            this.database = new SQLiteConnection(Constants.DatabasePath);

            this.database.CreateTable<Course>();
        }

        public void AddCourse(Course course)
        {
            this.database.Insert(course);
        }

        public void AddCourse(string courseId, string name, int credit)
        {
            this.database.Insert(new Course(courseId, name, credit));
        }

        public void DeleteCourse(string courseId)
        {
            this.database.Delete<Course>(courseId);
        }

        public List<Course> GetAllCourses()
        {
            return this.database.Table<Course>().ToList();
        }

        public Course GetCourseById(string courseId)
        {
            return this.database.Table<Course>().Where(s => s.CourseId == courseId).FirstOrDefault();
        }

        public void UpdateCourse(Course course)
        {
            this.database.Update(course);
        }

        public void UpdateCourse(string courseId, string name, int credit)
        {
            this.database.Update(new Course(courseId, name, credit));
        }
    }
}
