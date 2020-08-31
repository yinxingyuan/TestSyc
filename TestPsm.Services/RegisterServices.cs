using MetaShare.Common.Core.CommonService;
using TestPsm.Services.Interfaces;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestPsm.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}

		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(IProductService), new ProductService(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
