using Terrasoft.Core;

namespace Terrasoft.Configuration.Tests
{
	class TestAppConnection : AppConnection
	{
		public TestAppConnection() : base()
		{
			AppManagerProvider = new TestManagerProvider(this);
		}
	}
}
