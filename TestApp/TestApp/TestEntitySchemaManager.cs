using System.Globalization;
using System.Reflection;
using Terrasoft.Core;
using Terrasoft.Core.Entities;

namespace Terrasoft.Configuration.SLACalculation
{
	public class TestEntitySchemaManager : EntitySchemaManager
	{
		private AppConnection _appConnection;

		public TestEntitySchemaManager(AppConnection appConnection) : base()
		{
			DataValueTypeManager = new DataValueTypeManager();
			_appConnection = appConnection;
		}

		public override AppConnection AppConnection
		{
			get
			{
				return this._appConnection;
			}
		}

	}
}