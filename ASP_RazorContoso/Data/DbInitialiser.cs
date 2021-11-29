using ASP_RazorContoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_RazorContoso.Data
{
    public class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            AddStudents(context);

            AddCourse(context);

            AddEnrollments(context);

            AddModules(context);
        }

        public static void AddStudents(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }

        private static void AddCourse(ApplicationDbContext context)
        {
            if (context.Courses.Any())
            {
                return;
            }

            var courses = new Course[]
            {
                new Course{CourseID=1050,CourseCode="BT1CTG1",Title="Web Applications",Credits=3},
                new Course{CourseID=4022,CourseCode="BT1CWD1",Title="Real Time Systems",Credits=3},
                new Course{CourseID=4041,CourseCode="BB1DSC1",Title="Object Oriented Programming",Credits=3},
                new Course{CourseID=1045,CourseCode="BT1SFT1",Title="Mobile Apps",Credits=4},
                new Course{CourseID=3141,CourseCode="BB1ARI1",Title="Database Design",Credits=4},
                new Course{CourseID=2021,CourseCode="MT1CYS1",Title="Object Oriented Design and Analysis",Credits=3},
                new Course{CourseID=2042,CourseCode="BT1GDV1",Title="Software Engineering",Credits=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();
        }

        private static void AddEnrollments(ApplicationDbContext context)
        {
            if (context.Enrollments.Any())
            {
                return;
            }

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grades.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grades.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grades.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grades.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grades.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grades.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grades.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }

        private static void AddModules(ApplicationDbContext context)
        {
            if (context.Modules.Any())
            {
                return;
            }

            Module co550 = new Module
            {
                ModuleID = "CO550",
                Title = "Web Applications"
            };

            Module co588 = new Module
            {
                ModuleID = "CO558",
                Title = "Database Design"
            };

            Module co567 = new Module
            {
                ModuleID = "CO567",
                Title = "OO Systems Development"
            };

            Module co566 = new Module
            {
                ModuleID = "CO566",
                Title = "Mobile Systems"
            };

            var modules = new Module[]
            {
                co550,
                co566,
                co588,
                co567
            };

            context.Modules.AddRange(modules);
            context.SaveChanges(true);

        }
    }
}
