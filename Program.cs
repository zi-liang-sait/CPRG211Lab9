// See https://aka.ms/new-console-template for more information

//CPRG 211 F Lab 9 - Using Databases
//Michael (Zi) Liang 000921925
//Apr 1, 2024

//Methods to CRUD Courses in the database are part of the CourseManager class.
//Program.cs only shows AddCourse(), GetAllCourses(), and DeleteCourse().

using CPRG211Lab9;

CourseManager courseManager = new CourseManager();

courseManager.AddCourse("1001", "Fundamentals of Web Development", 3);
courseManager.AddCourse("1002", "Introduction to Full Stack Programming", 3);
courseManager.AddCourse("1003", "Databases", 3);
courseManager.AddCourse("1004", "Principles of Software Design and Analysis", 4);
courseManager.AddCourse("1005", "Objected-Oriented Programming", 4);

List<Course> courseList = courseManager.GetAllCourses();

foreach (Course course in courseList)
{
    Console.WriteLine(course);
}

//delete courses so database is empty for next test run
courseManager.DeleteCourse("1001");
courseManager.DeleteCourse("1002");
courseManager.DeleteCourse("1003");
courseManager.DeleteCourse("1004");
courseManager.DeleteCourse("1005");