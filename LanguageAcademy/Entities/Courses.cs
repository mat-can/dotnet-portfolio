using MeniSchool.Entities.Enums;

namespace MeniSchool.Entities
{
    public class Courses
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public SchoolShifts Shifts { get; set; }
        public List<SchoolSubjects> SchoolSubjects { get; set; }
        public List<Students> Students { get; set; }
        public Courses() => (Id) = (Id = Guid.NewGuid().ToString());
    }
}