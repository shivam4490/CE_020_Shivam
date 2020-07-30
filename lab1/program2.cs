using System;

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
			Console.WriteLine("Ans is {0}",n1+n2);
			Console.ReadKey();
		}
	}
}