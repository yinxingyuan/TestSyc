using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TestPsm.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestPsm.Web.Models
{
	public class ProductModel: CommonModel<Product>
	{
		public string Code {get; set;}

		public override void PopulateFrom(Product entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.Code = entity.Code;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(Product entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.Code = this.Code;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
