using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using Terrasoft.Common;
using Terrasoft.Configuration.SLACalculation;
using Terrasoft.Configuration.Tests;
using Terrasoft.Core;

namespace Terrasoft.Configuration.SLACalculationTest
{
	[TestFixture]
	class ActivitySLACalculationStrategyTest
	{
		protected ActivitySLACalculationStrategy Strategy { get; set; }

		protected UserConnection UserConnection { get; set; }

		[SetUp]
		public void Init()
		{
			UserConnection = TestUtility.CreateTestUserConnection();
			Strategy = new ActivitySLACalculationStrategy(UserConnection);
		}

		[Test]
		public void ReturnCorrectTimeTerm()
		{
			
			var testId = Guid.NewGuid();
			var expectedValue = new TimeTerm
			{
				Value = 480,
				Type = Terrasoft.Configuration.Calendars.TimeUnit.Hour
			};
			var dictionary = new Dictionary<string, object>
			{
				{ "activitySubCategory", testId }
			};
			ISchemaManagerItem activitySubCategory = UserConnection.EntitySchemaManager.AddSchema(
				Guid.NewGuid(), "ActivitySubCategory", LocalizableString.Empty, LocalizableString.Empty, Guid.Empty);
			UserConnection.EntitySchemaManager.InitializeSchema(activitySubCategory,
				Assembly.GetAssembly(typeof(ActivitySubCategory)));


			var actualValue = Strategy.GetDueDateTimeTerm(dictionary);
			Assert.AreEqual(expectedValue, actualValue);

		}
	}
}
