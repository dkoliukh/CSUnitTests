using Terrasoft.Core;

namespace Terrasoft.Configuration.Tests
{
	class TestManagerProvider : ManagerProvider
	{
		public TestManagerProvider(AppConnection appConnection) : base(appConnection)
		{
			Managers.Add("DataValueTypeManager", new DataValueTypeManager());
			Managers.Add("SystemValueManager", new SystemValueManager());
		}
	}
}
