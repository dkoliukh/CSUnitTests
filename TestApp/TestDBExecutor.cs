using System.Collections.Generic;
using System.Data.Common;
using Terrasoft.Common;
using Terrasoft.Core;
using Terrasoft.Core.DB;

namespace Terrasoft.Configuration.Tests
{
	public class TestDBExecutor : DBExecutor
	{
		public TestDBExecutor(UserConnection userConnection) : base(userConnection)
		{
		}

		public TestDBExecutor(UserConnection userConnection, QueryKind queryKind) : base(userConnection, queryKind)
		{
		}

		protected override string BuildConnectionString(string userName, string password)
		{
			throw new System.NotImplementedException();
		}

		protected override DbConnection NewConnection()
		{
			throw new System.NotImplementedException();
		}

		protected override DbCommand NewCommand()
		{
			throw new System.NotImplementedException();
		}

		protected override void QueryParametersToDBParameters(QueryParameterCollection queryParameters, DbParameterCollection dbParameters)
		{
			throw new System.NotImplementedException();
		}

		protected override void InitilizeConnectionAfterOpen(DbConnection dbConnection)
		{
			throw new System.NotImplementedException();
		}

		protected override void DBParametersToQueryParameters(DbParameterCollection dbParameters, QueryParameterCollection queryParameters)
		{
			throw new System.NotImplementedException();
		}

		protected override IEnumerable<string> SplitBatches(string sqlText)
		{
			throw new System.NotImplementedException();
		}

		protected override bool ValidateBatches(DbCommand command, string sqlText, out string message)
		{
			throw new System.NotImplementedException();
		}
	}
}
