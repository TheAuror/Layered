using Castle.Components.DictionaryAdapter;
using FluentAssertions;
using LayeredSolution.BusinessLayer;
using LayeredSolution.DataLayer;
using LayeredSolution.DataLayer.Schema;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSolution.Tests
{
    [TestFixture]
    class ProductServiceTests
    {
        List<Product> productList;
        Mock<ISampleContext> sampleContextMock;
        Mock<DbSet<Product>> productDBSetMock;
        [SetUp]
        public void SettingsBeforeTest()
        {
            productList = new List<Product>
            {
                new Product()
                {
                    Id =1,
                    Name="Asd",
                    ProductNo="123",
                    Price=4231
                },
                new Product()
                {
                    Id =2,
                    Name="Asd2",
                    ProductNo="1232",
                    Price=42312
                },
                new Product()
                {
                    Id =3,
                    Name="Asd3",
                    ProductNo="1233",
                    Price=42313
                },
                new Product()
                {
                    Id =4,
                    Name="Asd4",
                    ProductNo="1234",
                    Price=42314
                }
            };
            sampleContextMock = new Mock<ISampleContext>();
            productDBSetMock = new Mock<DbSet<Product>>();
            productDBSetMock.SetDataSource(productList);
        }
        [Test]
        public void GetAllProducts_OnEmptyString_ShouldReturnAllTheProducts()
        {
            //Arrange           
            sampleContextMock.SetupGet(sampleContext => sampleContext.Products).Returns(productDBSetMock.Object);
            ISampleContext context = sampleContextMock.Object;
            ProductService objectUnderTest = new ProductService(context);
            //Act
            var result = objectUnderTest.GetAllProduct("");
            //Assert
            result.Should().NotBeNull();
            result.Count.Should().Be(productList.Count);
        }

        [Test]
        public void GetAllProduct_OnSearchString12_ShouldFilterProductNoField(string No, string Name)
        {
            //Arrange           
            sampleContextMock.SetupGet(sampleContext => sampleContext.Products).Returns(productDBSetMock.Object);
            ISampleContext context = sampleContextMock.Object;
            ProductService objectUnderTest = new ProductService(context);
            //Act
            var result = objectUnderTest.GetAllProduct(No).Union(objectUnderTest.GetAllProduct(Name));
            //Assert
            
            result.Should().OnlyContain(product => product.ProductNo.Contains(No) && product.Name.Contains(Name));
        }
        [Test]
        public void GetAllProduct_OnSearch_ShouldFilter()
        {
            string[] searchName= {null, "asd", "243", "grasd", "rekt" };
            string[] searchNo = {null, "23", "12" };
            //Arrange           
            Random rand = new Random();
            GetAllProduct_OnSearchString12_ShouldFilterProductNoField(searchName[rand.Next(searchName.Count())], searchNo[rand.Next(searchNo.Count())]); 
        }
    }
}
