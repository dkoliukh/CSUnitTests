using System;
using System.Collections.ObjectModel;
using System.Reflection;
using Terrasoft.Common;
using Terrasoft.Core;
using Terrasoft.Core.Entities;

namespace Terrasoft.Configuration.Tests
{
	public class TestEntitySchemaManager : EntitySchemaManager
	{
		private readonly AppConnection _appConnection;

		public TestEntitySchemaManager(AppConnection appConnection) : base()
		{
			_appConnection = appConnection;
		}


		public override AppConnection AppConnection => this._appConnection;

		protected override bool InitializeItems(Guid itemUId)
		{
			return true;
		}

		protected override void InitializeEntitySchemaRights()
		{
		}

		protected override void InitializeEntitySchemaColumnRights()
		{

		}

		protected override void InitializeEvents()
		{
		}

		public override IManagerItemInstance InitializeSchema(ISchemaManagerItem schemaManagerItem, Assembly assembly)
		{
			string typeName = schemaManagerItem.TypeName;
			EntitySchema schemaInstance = this.CreateSchemaInstance(schemaManagerItem, assembly);
			if ((object) schemaInstance == null)
				throw new NullOrEmptyException(
					string.Format((string) new LocalizableString("Terrasoft.Core", "SchemaManager.Exception.SchemaInstanceIsNull"),
						(object) typeName), typeName);
			schemaInstance.InitializeLocalizableValues();
			return (IManagerItemInstance) schemaInstance;
		}
	}
}