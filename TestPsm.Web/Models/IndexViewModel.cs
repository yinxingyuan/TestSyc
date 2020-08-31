using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Presentation;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestPsm.Web.Models
{
	public class IndexViewModel<TEntity> where TEntity : MetaShare.Common.Core.Entities.Common
	{
		public SearchModel SearchModel { get; set; }
		public TargetPager<TEntity> TargetPager { get; set; }
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
