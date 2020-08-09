using System;
using System.Reflection;

[assembly: AssemblyVersion("1.0.0.0")]
namespace math
{
    public class calc
    {
        public int multiplication(int a,int b)
		{
			Console.WriteLine("In a new Vesrion of dll");
			return a*b;
		}
		public int addition(int a,int b)
		{
			Console.WriteLine("In a new Vesrion of dll");
			return a+b;
		}
    }
}