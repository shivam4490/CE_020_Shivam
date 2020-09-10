using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers nums = new Numbers();
            nums.First_Question_Answers();

            Humans name = new Humans();
            name.Second_Question_Answers();
        }
    }
}

public class Numbers
{
    public void First_Question_Answers()
    {
        List<int> numbers = new List<int>();
        for (int i = 1; i <= 100; i++)
        {
            numbers.Add(i);
        }
        var output1 = numbers.Where(n => (n % 2 == 0));
        Console.WriteLine("Even numbers in list are : ");
        foreach (int n in output1)
        {
            Console.Write(n + "\t");
        }
        Console.WriteLine("\n\n");

        var output2 = numbers.Where(n => (n % 2 != 0));
        Console.WriteLine("Odd numbers in list are : ");
        foreach (int n in output2)
        {
            Console.Write(n + "\t");
        }
        Console.WriteLine("\n\n");

        var output3 = numbers.Select(n => n);
        Console.WriteLine("Odd numbers in list are : ");
        foreach (int n in output3)
        {
            Console.Write(n + "\t");
        }
        Console.WriteLine("\n\n");

        var output4 = numbers.Select(n => n).Max();
        Console.WriteLine("Maximum number in list is : " + output4 + "\n\n");

        var output5 = numbers.Select(n => n).Min();
        Console.WriteLine("Minimum number in list is : " + output5 + "\n\n");

        var output6 = numbers.Select(n => n).Average();
        Console.WriteLine("Average of numbers in list is : " + output6 + "\n\n");
        Console.ReadKey();
    }
}

public class Humans
{
    public void Second_Question_Answers()
    {
        List<string> names = new List<string>();
        names.Add("Suresh");
        names.Add("Dhoni");
        names.Add("Virat");
        names.Add("Shikhar");
        names.Add("Rohit");
        names.Add("Sarabh");
        names.Add("Mahendra");
        names.Add("Jasprit");
        names.Add("Deepak");
        names.Add("Saini");

        var output1 = names.Where(n => n.StartsWith("K"));
        Console.WriteLine("The names which start with K are : ");
        foreach (string name in output1)
        {
            Console.WriteLine(name);
        }
        Console.Write("\n\n");

        var output2 = names.Where(n => (n.Length < 4));
        Console.WriteLine("The names whose length is less than 4 are : ");
        foreach (string name in output2)
        {
            Console.WriteLine(name);
        }
        Console.Write("\n\n");

        var output3 = names.Where(n => (n.Length == 3));
        Console.WriteLine("The names whose length is equal to 3 are : ");
        foreach (string name in output3)
        {
            Console.WriteLine(name);
        }
        Console.Write("\n\n");

        var output4 = names.OrderBy(n => n);
        Console.WriteLine("The names in ascending order are : ");
        foreach (string name in output4)
        {
            Console.WriteLine(name);
        }
        Console.Write("\n\n");
    }
}
