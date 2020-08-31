using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using TestPsm.Entities;
using MetaShare.Common.Core.Services;
using TestPsm.Daos.Interfaces;
using TestPsm.Services.Interfaces;

/*add customized code between this region*/
/*add customized code between this region*/

namespace TestPsm.Services
{
	public class ProductService : Service<Product>, IProductService
	{
		public ProductService() : base(typeof (IProductDao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
