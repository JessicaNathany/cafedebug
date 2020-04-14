using Cafedebug.Business.Interfaces;
using Cafedebug.Business.Models;
using Cafedebug.Business.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace Cafedebug.UnitTest.Service.Categories
{
    [TestClass]
    public class CategoryServiceTest
    {
        private Mock<ICategoryRepository> _categoryRepositoryMock;
        private Mock<INotifier> _notifierMock;
        private CategoryService _categoryService;


        public CategoryServiceTest()
        {
            _categoryRepositoryMock = new Mock<ICategoryRepository>();
            _notifierMock = new Mock<INotifier>();
            _categoryService = new CategoryService(_categoryRepositoryMock.Object, _notifierMock.Object);
        }

        [TestMethod]
        public void Save_Category_IsValid_ShouldCallRepository()
        {
            var category = new Category
            {
                Id = 1,
                Code = Guid.NewGuid(),
                Name = "Banco de dados"
            };

            _categoryService.Save(category);

            _categoryRepositoryMock.Verify(c => c.Save(category), Times.Once());
        }

        [TestMethod]
        public void Save_Category_IsNotValid_NotShouldCallRepository()
        {
            var category = new Category
            {
                Id = 1,
                Code = Guid.NewGuid(),
                Name = ""
            };

            _categoryService.Save(category);

            _categoryRepositoryMock.Verify(c => c.Save(category), Times.Never());
        }

        
        [TestMethod]
        public void GetAll_ShouldCallRepository_AndReturnPagedResultCategory()
        {
            var page = new PageRequest();

            var categoriesExpected = new PageResult<Category>
            {
                Items = new List<Category> { 
                    new Category {Id = 1, Code = Guid.NewGuid(), Name = "Banco de Dados"},
                    new Category {Id = 2, Code = Guid.NewGuid(), Name = "Inclusão Digital"},
                    new Category {Id = 3, Code = Guid.NewGuid(), Name = "Programação Funcional"},
                    new Category {Id = 4, Code = Guid.NewGuid(), Name = "Microservices"},
                    new Category {Id = 5, Code = Guid.NewGuid(), Name = "Elasticsearch"},
                },
                ItemsPerPage = 10,
                TotalItems = 5,
                TotalPages = 1
            };

            _categoryRepositoryMock.Setup(c => c.GetPaged(It.Is<PageRequest>(p => p.Page == 1 && p.ItemsPerPage == 10 && p.SortBy == "Id" && p.SortDirection == SortDirection.ASC)))
                                                                                                                                                                        .Returns(categoriesExpected);

            var result = _categoryService.GetPaged(page);

            Assert.AreEqual(categoriesExpected, result);
        }
    }
}
