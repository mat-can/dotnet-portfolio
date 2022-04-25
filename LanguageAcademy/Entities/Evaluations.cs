namespace MeniSchool.Entities
{
    public class Evaluations
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public Students Students { get; set; }
        public SchoolSubjects SchoolSubjects { get; set; }
        public double Note { get; set; }
        public Evaluations() => (Id) = (Id = Guid.NewGuid().ToString());
    }
}