using System.Configuration;
using Terrasoft.Core;
using NSubstitute;
using Terrasoft.Core.Entities;

namespace Terrasoft.Configuration.SLACalculation
{
	public class TestUtility
	{

		public static UserConnection CreateTestUserConnection()
		{
			AppConnection appConnection = Substitute.For<AppConnection>();
			TestUserConnection userConnection = new TestUserConnection(appConnection);
			appConnection.Workspace = new Core.Configuration.SysWorkspace(userConnection);
			return userConnection;
		}
	}
}
