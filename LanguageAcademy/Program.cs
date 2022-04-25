// See https://aka.ms/new-console-template for more information
using MeniSchool;
using MeniSchool.Entities;
using MeniSchool.Entities.Enums;
using MeniSchool.Util;

var engine = new SchoolEngine();
engine.Initialize();
Printer.WriteTitle("WELCOME TO MENI LANGUAGE ACADEMY");

SeeSchool(engine.School);
Printer.WriteLines(20);

void SeeSchool(School school)
{
    Printer.WriteTitle("Enter a number to see options for: ");
    Console.WriteLine("\n 1 - Courses \n 2 - Students \n 3 - Shifts \n 4 - Evaluations");
    Printer.WriteLines();

    int num = 0;
    string entry = Console.ReadLine();
    bool isNum = int.TryParse(entry, out num);
    if (isNum)
    {
        switch(int.Parse(entry))
        {
            case 1:
                Printer.WriteTitle("Here are the courses this year: ");
                if (school?.Courses == null)
                {
                    return;
                }
                DisplayCourses(school.Courses);
                GoBack();
                break;
            case 2:
                Printer.WriteTitle("This is the list of students: ");
                if (school?.Courses == null)
                {
                    return;
                }
                DisplayStudents(school.Courses);
                GoBack();
                break;
            case 3:
                Printer.WriteTitle("Here are the shifts this year: ");
                DisplayShifts();
                GoBack();
                break;
            case 4:
                Printer.WriteTitle("Select the number of the class to see the students evaluations: ");
                if (school?.Courses == null)
                {
                    return;
                }
                DisplayCourses(school.Courses);
                Printer.WriteLines();

                string entry1 = Console.ReadLine();
                bool isNum1 = int.TryParse(entry, out num);
                if (isNum1)
                {
                    if (school?.Courses == null)
                    {
                        return;
                    }
                    DisplayEvaluations(school.Courses, int.Parse(entry1));
                    GoBack();
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                break;
            default:
                Console.WriteLine("Please enter a valid number.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
}

void GoBack()
{
    Printer.WriteLines();
    Console.WriteLine("Press F to go back - Press any number to close.");
    Printer.WriteLines();
    string go = Console.ReadLine();
    if (go.ToUpper() == "F")
    {
        SeeSchool(engine.School);
    }
    else
    {
        Environment.Exit(0);
    }
}

/// <summary>
/// Display a list of the courses.
/// </summary>
/// <param name="arrayCourses"></param>
static void DisplayCourses(List<Courses> arrayCourses)
{
    for (int i = 0; i < arrayCourses.Count; i++)
    {
        Console.WriteLine(arrayCourses[i].Name);
    }
}
/// <summary>
/// Display a list of the courses.
/// </summary>
static void DisplayShifts()
{
    List<SchoolShifts> shifts = new List<SchoolShifts>();

    foreach (SchoolShifts s in Enum.GetValues(typeof(SchoolShifts)))
    {
        Console.WriteLine(s);
    }
}
/// <summary>
/// Display a list of the courses.
/// </summary>
/// /// <param name="arrayCourses"></param>
static void DisplayStudents(List<Courses> arrayCourses)
{
    for(int i = 0; i < arrayCourses.Count; i++)
    {
        foreach(var c in arrayCourses[i].Students)
        {
            Console.WriteLine(c.Name);
        }
    };
}
/// <summary>
/// Display a list of the evaluations.
/// </summary>
/// /// <param name="arrayCourses"></param>
static void DisplayEvaluations(List<Courses> arrayCourses, int course)
{
    int numC = 0;
    switch (course)
    {
        case 101:
            numC = 0;
            break;
        case 201:
            numC = 1;
            break;
        case 301:
            numC = 2;
            break;
        case 401:
            numC = 3;
            break;
        case 501:
            numC = 4;
            break;
        default:
            Console.WriteLine("Enter a valid class.");
            break;
    }
    Random r = new Random();
    foreach (var c in arrayCourses[numC].Students)
    {
        float randomCant = (float)(5 * r.NextDouble());
        string result = randomCant.ToString().Substring(0,3);
        Console.WriteLine(c.Name + " - Note: " + result);
    }
}




