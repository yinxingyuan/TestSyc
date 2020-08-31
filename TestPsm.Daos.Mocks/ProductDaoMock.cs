using MetaShare.Common.Core.Daos;
using TestPsm.Entities;
using TestPsm.Daos.Interfaces;
using TestPsm.TestData;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestPsm.Daos.Mocks
{
	public class ProductDaoMock : MockDao<Product>, IProductDao
	{
		public ProductDaoMock() : base(ProductTestData.CreateProduct())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
