using System;
using addition;

namespace driver
{
	class driver
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Enter First number : ");
			string num1=Console.ReadLine();
            Console.WriteLine("Enter Seccond number : ");
            string num2=Console.ReadLine();
			int n1=Int32.Parse(num1);
			int n2=Int32.Parse(num2);
			Class1 c1=new Class1();
			Console.WriteLine("Ans is {0} ", c1.add(n1,n2));
			Console.ReadKey();
		}
	}
}