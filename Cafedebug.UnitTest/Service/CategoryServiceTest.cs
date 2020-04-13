using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Business.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Cafedebug.UnitTest.Service
{
    [TestClass]
    public class CategoryServiceTest
    {
        private Mock<ICategoryRepository> _categoryRepositoryMock;
        private Mock<INotifier> _notifierMock;
        private CategoryService _categoryService;

        [TestMethod]
        public void Save_Category_IsSuccessFull()
        {

            _categoryRepositoryMock = new Mock<ICategoryRepository>();
            _notifierMock = new Mock<INotifier>();
            _categoryService = new CategoryService(_categoryRepositoryMock.Object, _notifierMock.Object);

            var categoryObjectExpected = new Category
            {
                Id = 1,
                Code = Guid.NewGuid(),
                Name = "Tecnologia"
            };

            var categoryActual = new Category
            {
                Id = 1,
                Code = Guid.NewGuid(),
                Name = "Banco de dados"
            };

            // _categoryRepositoryMock.Setup(c => c.Save(It.IsAny<Category>())).Returns(categoryObjectExpected);

            _categoryService.Save(categoryActual);

            _categoryRepositoryMock.Verify(c => c.Save(It.IsAny<Category>()), Times.Once());
        }

        //    [TestMethod]
        //    public void Get_Category_ById()
        //    {
        //        _categoryRepositoryMock = new Mock<ICategoryRepository>();
        //        _notifierMock = new Mock<INotifier>();
        //        _categoryService = new CategoryService(_categoryRepositoryMock.Object, _notifierMock.Object);


        //        var category = new Category
        //        {
        //            Id = 1,
        //            Code = Guid.NewGuid(),
        //            Name = "Tecnologia"
        //        };

        //        _categoryRepositoryMock.Setup(c => c.GetById(It.IsAny<int>())).Returns(category);

        //        var categoryReturn = _categoryService.GetById(It.IsAny<int>());

        //        Assert.AreEqual(category, categoryReturn);
        //    }
        //}
    }
}
