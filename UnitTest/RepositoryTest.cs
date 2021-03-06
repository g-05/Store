﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Store.Domain.Domains;
using Store.Domain.Interfaces;
using Store.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
   [TestClass]
   public class RepositoryTest : BaseTest {
      //gauketot DI repositorebs
      //[TestMethod]
      //public void UserRepositoryTest() {
      //    int result = 2 + 2;
      //    Assert.AreEqual(4, result, "Arithmetic Operation Failed.");
      //    result = 2 + 2;
      //    Assert.AreEqual(5, result, "Arithmetic Operation Failed.");
      //}
      [TestMethod]
      public void CategoryRepositoryTest() {
         Category category = new Category() {
            Name = "Test3.",
            Description = "TestDescription"
         };
         //StoreDbContext sdc = new StoreDbContext();
         //CategoryRepository c = new CategoryRepository(sdc);
         //c.Save(category);
         //sdc.SaveChanges();
         Assert.AreEqual(7, category.ID, "Such category doesn't exist");

         Mock<IBaseRepository<Category>> mock = new Mock<IBaseRepository<Category>>();
         mock.Setup(x => x.Save(category));

      }
   }
}
