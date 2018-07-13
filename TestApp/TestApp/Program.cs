using System;
using System.Collections.Generic;
using System.Linq;
using Terrasoft.Configuration.Calendars;
using Terrasoft.Core;

namespace Terrasoft.Configuration.SLACalculation
{

	public class Program
	{
		

		public static void Main()
		{
			AppConnection ac = new AppConnection();
			UserConnection uc = new UserConnection(ac);


			Console.WriteLine(typeof(ActivitySubCategory).Assembly);
			Console.ReadKey();

		}
	}

}
