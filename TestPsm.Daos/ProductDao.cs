using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using TestPsm.Daos.Interfaces;
using TestPsm.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestPsm.Daos
{
	public class ProductDao : CommonObjectDao<Product>, IProductDao
	{
		public class ProductSqlBuilder : ObjectSqlBuilder
		{
			public ProductSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"Product")
			{
				this.SqlInsert = "INSERT INTO Product (Code," + this.SqlBaseFieldInsertFront + ") VALUES (@Code," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE Product SET Code=@Code," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}

		public class ProductResultHandler : CommonObjectResultHandler<Product>
		{
			public override void GetColumnValues(IDataReader reader, Product item)
			{
				base.GetColumnValues(reader, item);
				int ordinalCode = reader.GetOrdinal("Code");
				item.Code = reader.IsDBNull(ordinalCode) ? null : reader.GetString(ordinalCode);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}

			public override void AddInsertParameters(IContext context, IDbCommand command, Product item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command, "Code", item.Code ?? (object) DBNull.Value);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}

		public ProductDao(SqlDialect sqlDialect) : base(new ProductSqlBuilder(sqlDialect), new ProductResultHandler())
		{
		}

		public ProductDao(SqlDialect sqlDialect, string schemaConnectionString) : base(new ProductSqlBuilder(sqlDialect), new ProductResultHandler(), schemaConnectionString)
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
