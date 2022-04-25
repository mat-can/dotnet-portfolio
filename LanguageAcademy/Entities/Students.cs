namespace MeniSchool.Entities
{
    public class Students
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public Students() => (Id) = (Id = Guid.NewGuid().ToString());
    }
}