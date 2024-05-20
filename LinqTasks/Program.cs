using LinqTasks.Models;

namespace LinqTasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadanie 8");

        IEnumerable<Emp> result = Tasks.Task12();

        foreach (Emp emp in result)
        {
            Console.WriteLine(emp);
        }
    }
}