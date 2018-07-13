using System;
using System.Reflection;
using System.Runtime.Serialization;
using Terrasoft.Common;
using Terrasoft.Core;
using Terrasoft.Core.Entities;

namespace Terrasoft.Configuration.Tests
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
			var schemaMangerProvider = new SchemaManagerProvider(appConnection);
			EntitySchemaManager.Initialize(schemaMangerProvider, null);
		}

		public override ManagerProvider AppManagerProvider => this.AppConnection.AppManagerProvider;

		
	}
}
