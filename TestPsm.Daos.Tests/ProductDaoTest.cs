﻿using System.Collections.Generic;
using NUnit.Framework;
using System;
using TestPsm.Daos.Interfaces;
using TestPsm.Daos.DataSchema;
using TestPsm.TestData;
using TestPsm.Daos.Tests.Common;
using TestPsm.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace TestPsm.Daos.Tests
{
	public class ProductDaoTest : CommonDaoTest<Product, IProductDao, ProductDdlBuilder>
	{
		public ProductDaoTest() : base(ProductTestData.CreateProduct())
		{
		}

		[TestCase]
		public void SelectAllTest()
		{
			Assert.AreEqual(ProductTestData.ProductCount, this.Dao.SelectAll(this.Context).Count);
		}

		[TestCase]
		public void SelectByIdTest()
		{
			Product item = ProductTestData.CreateProduct1();
			Product find = this.Dao.SelectById(this.Context, item);

			Assert.AreEqual(item.Id, find.Id);
			ProductTestData.AssertAreEqual(item, find);
		}

		[TestCase]
		public void InsertTest()
		{
			Product item = new Product
			{
				Code = string.Empty, 
				Description = string.Empty, 
				Name = string.Empty, 
			};
			int affectedRows = this.Dao.Insert(this.Context, item);
			Assert.AreEqual(1, affectedRows);

			Product find = this.Dao.SelectById(this.Context, item);
			ProductTestData.AssertAreEqual(item, find);

			List<Product> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(ProductTestData.ProductCount + 1, items.Count);
		}

		[TestCase]
		public void UpdateTest()
		{
			Product item = ProductTestData.CreateProduct1();
			Product beforeUpdate = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforeUpdate);
			beforeUpdate.Code = string.Empty;

			this.Dao.Update(this.Context, beforeUpdate);

			Product afterUpdate = this.Dao.SelectById(this.Context, beforeUpdate);
			ProductTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}

		[TestCase]
		public void DeleteTest()
		{
			Product item = ProductTestData.CreateProduct1();
			Product beforedelete = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforedelete);

			int affectedRows = this.Dao.Delete(this.Context, beforedelete);
			Assert.AreEqual(1, affectedRows);

			Product afterDelete = this.Dao.SelectById(this.Context, beforedelete);
			Assert.IsNull(afterDelete);

			List<Product> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(ProductTestData.ProductCount - 1, items.Count);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
