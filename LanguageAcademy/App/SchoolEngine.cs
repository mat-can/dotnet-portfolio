using MeniSchool.Entities;
using MeniSchool.Entities.Enums;

namespace MeniSchool
{
    public class SchoolEngine
    {
        public School School { get; set; }
        public SchoolEngine()
        {
        }
        /// <summary>
        /// Initializes all values inside the program.
        /// </summary>
        public void Initialize()
        {
            School = new School("Meni Academy", 2022, SchoolTypes.Primary, city: "Aviles", country: "Spain");

            CreateCourses();
            CreateSubjects();
            //CreateEvaluations();
        }

        private void CreateEvaluations()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method that creates courses of the school.
        /// </summary>
        private void CreateCourses()
        {
            School.Courses = new List<Courses>(){
                new Courses() { Name = "101 - Spanish",  Shifts = SchoolShifts.Morning },
                new Courses() { Name = "201 - Japanese",  Shifts = SchoolShifts.Morning },
                new Courses() { Name = "301 - Corean",  Shifts = SchoolShifts.Morning },
                new Courses() { Name = "401 - German",  Shifts = SchoolShifts.Afternoon },
                new Courses() { Name = "501 - French ",  Shifts = SchoolShifts.Afternoon }
            };

            Random rnd = new Random();
            foreach(var c in School.Courses)
            {
                int randomCant = rnd.Next(5,20);
                c.Students = CreateRandomStudents(randomCant);
            };
        }
        /// <summary>
        /// Method that creates students of the school.
        /// </summary>
        private List<Students> CreateRandomStudents(int cant)
        {
            string[] firstNameF = { "Manuel", "Felipe", "Mario", "Claudio", "Carlos", "Alvaro", "Nicolás" };
            string[] lastName = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] firstNameM = { "Freddy", "Anabel", "Rick", "Morty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var studentsListF = from nF in firstNameF
                               from a in lastName
                               select new Students{ Name = $"{nF} {a}" };
            var studentsListM = from nF in firstNameF
                               from a in lastName
                               select new Students{ Name = $"{nF} {a}" };

            List<Students> studentsList = new List<Students>();
            studentsList.AddRange(studentsListF);
            studentsList.AddRange(studentsListM);

            var result = studentsListF.OrderBy((stu)=>stu.Id).Take(cant).ToList();
            return result;
        }
        /// <summary>
        /// Method that creates subjects of the school.
        /// </summary>
        private void CreateSubjects()
        {
            foreach(var course in School.Courses)
            {
                List<SchoolSubjects> Subjects = new List<SchoolSubjects>(){
                    new SchoolSubjects { Name = "Math" },
                    new SchoolSubjects { Name = "Physical Ed" },
                    new SchoolSubjects { Name = "English" },
                    new SchoolSubjects { Name = "Science" }
                };
                course.SchoolSubjects = Subjects;
            }
        }
    }
}