using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Terrasoft.Configuration.Tests;
using Terrasoft.Core;

namespace Terrasoft.Configuration.EdenLab.UnitTests
{
	#region Class : BaseUnitTest
	public class BaseUnitTest
	{
		#region Properties : Public
		public AppConnection AppConnection { get; set; }

		public UserConnection UserConnection { get; set; }
		#endregion

		#region Methods : Public
		[SetUp]
		public virtual void Init()
		{

		}
		#endregion

		#region Methods : Protected
		protected void CreateAppConnection()
		{
			AppConnection = new TestAppConnection();
		}

		protected void CreateUserConnection()
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
