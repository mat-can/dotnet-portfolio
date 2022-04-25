using MeniSchool.Entities.Enums;

namespace MeniSchool.Entities
{
    public class School
    {
        string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public int CreationYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolTypes  SchoolTypes { get; set; }
        public List<Courses> Courses { get; set; }
        public School(string name, int creationYear) => (Name, CreationYear) = (name, creationYear);
        public School(string name, int creationYear, SchoolTypes schoolTypes, string country = "", string city = "")
        {
            this.name = name;
            this.CreationYear = creationYear;
            this.Country = country;
            this.City = city;
        }
        public override string ToString()
        {
            string newLine = System.Environment.NewLine;
            return $"Name: {Name}, {newLine} Type: {SchoolTypes}, {newLine} Country: {Country}, {newLine} City: {City}";
        }
    }
}