using static System.Console;

namespace MeniSchool.Util
{
    public static class Printer
    {
        /// <summary>
        /// Print Lines.
        /// </summary>
        /// <param name="cant"></param>
        public static void WriteLines(int cant = 15)
        {
            var line = "".PadLeft(cant, '-');
            WriteLine(line);
        }
        /// <summary>
        /// Print Title.
        /// </summary>
        /// <param name="cant"></param>
        public static void WriteTitle(string title)
        {
            WriteLines(title.Length + 4);
            WriteLine($"| {title} |");
            WriteLines(title.Length + 4);
        }
    }
}