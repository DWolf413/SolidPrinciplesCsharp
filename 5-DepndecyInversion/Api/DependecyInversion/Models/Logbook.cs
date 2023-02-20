using System.Text;

namespace DependecyInversion.Models
{
    public class Logbook
    {
        public void Add(string description)
        {
            File.AppendAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logbook.txt"), $"{description}\n", Encoding.Unicode);
        }
    }
}
