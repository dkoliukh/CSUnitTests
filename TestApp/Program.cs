using System;
using Terrasoft.Core;

namespace Terrasoft.Configuration.SLACalculation
{

	public class Program
	{
		public static void Main()
		{
			AppConnection ac = new AppConnection();
			UserConnection uc = new UserConnection(ac);
			Console.WriteLine(Type.GetType("Terrasoft.Configuration.SLACalculation.Program").AssemblyQualifiedName);
			Console.ReadKey();
		}
	}

}
