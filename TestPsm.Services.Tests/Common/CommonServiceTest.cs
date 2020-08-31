using MetaShare.Common.Core.Services;
using MetaShare.Common.Core.Daos;
using MetaShare.Common.Core.Entities;
using TestPsm.Daos.Mocks;
using NUnit.Framework;
using ServiceFactory = MetaShare.Common.Core.CommonService.ServiceFactory;
/*add customized code between this region*/
/*add customized code between this region*/
namespace TestPsm.Services.Tests.Common
{
	public class CommonServiceTest<TEntity, TService>
	where TEntity : MetaShare.Common.Core.Entities.Common
	where TService : IPagingService<TEntity>
	{
		protected TService Service;

		[SetUp]
		public void BasicSetUp()
		{
			DaoFactory.Instance.ConnectionStringBuilder = null;
			RegisterDaoMocks.RegisterAll();
			RegisterServices.RegisterAll();

			this.Service = ServiceFactory.Instance.GetService<TService>();
		}

		[TearDown]
		public void BasicTearDown()
		{
			RegisterServices.UnRegisterAll();
			RegisterDaoMocks.UnRegisterAll();
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
