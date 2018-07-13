using NUnit.Framework;
using System.Reflection;
using Terrasoft.Configuration.Tests;
using Terrasoft.Core;

namespace Terrasoft.Configuration.EdenLab.UnitTests
{
	#region Class : BaseUnitTest
	public class BaseUnitTest
	{
		#region Properties : Public
		public virtual AppConnection AppConnection { get; set; }

		public virtual UserConnection UserConnection { get; set; }
		#endregion

		#region Methods : Public
		[SetUp]
		public void Init()
		{
			CreateAppConnection();
			CreateUserConnection();
		}

		protected virtual void CreateAppConnection()
		{
			AppConnection = new TestAppConnection();
		}

		protected virtual void CreateUserConnection()
		{
			UserConnection = new TestUserConnection(AppConnection);
			var workspace = new Core.Configuration.SysWorkspace(UserConnection)
			{
				WorkspaceAssembly = Assembly.GetAssembly(typeof(BaseEntity))
			};
			AppConnection.Workspace = workspace;
		}
		#endregion
	}
	#endregion
}