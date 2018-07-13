using System.Configuration;
using System.Reflection;
using Terrasoft.Core;
using NSubstitute;
using Terrasoft.Core.Entities;

namespace Terrasoft.Configuration.Tests
{
	public class TestUtility
	{

		public static UserConnection CreateTestUserConnection()
		{
			AppConnection appConnection = new TestAppConnection();
			TestUserConnection userConnection = new TestUserConnection(appConnection);
			var workspace = new Core.Configuration.SysWorkspace(userConnection);
			workspace.WorkspaceAssembly = Assembly.GetAssembly(typeof(BaseEntity));
			appConnection.Workspace = workspace;
			return userConnection;
		}
	}
}
