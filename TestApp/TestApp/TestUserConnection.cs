using System;
using System.Reflection;
using System.Runtime.Serialization;
using Terrasoft.Common;
using Terrasoft.Core;
using Terrasoft.Core.Entities;

namespace Terrasoft.Configuration.SLACalculation
{
	public sealed class TestUserConnection : UserConnection
	{
		private TestUserConnection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		public TestUserConnection(AppConnection appConnection) : base(appConnection)
		{
			this.DBExecutorType = typeof(TestDBExecutor);
			this.EntitySchemaManager = new TestEntitySchemaManager(appConnection);
			ManagerProvider provider = this.UserManagerProvider.AppConnection.AppManagerProvider;
			EntitySchemaManager.Initialize(this.UserManagerProvider, null);
		}
	}
}
