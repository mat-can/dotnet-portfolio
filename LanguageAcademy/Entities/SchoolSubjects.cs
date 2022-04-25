namespace MeniSchool.Entities
{
    public class SchoolSubjects
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public SchoolSubjects() => (Id) = (Id = Guid.NewGuid().ToString());
    }
}