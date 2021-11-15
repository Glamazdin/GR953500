using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GR953500.Controllers;
using GR953500.Data;
using GR953500.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Xunit;

namespace TestProject1
{
    public class BooksControllerTests
    {
        private readonly DbContextOptions<ApplicationDbContext> _options;
        
        public BooksControllerTests()
        {
            _options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("inmemdb")
                .Options;  
        }

        [Fact]
        public async Task IndexReturnsView()
        {
            using (var context = new ApplicationDbContext(_options))
            {
                PopulateDb(context);

                var controller = new BooksController(context);
                var result = await controller.Index();
                Assert.IsType<ViewResult>(result);
                context.Database.EnsureDeleted();
            }            
        }

        [Fact]
        public async Task IndexReturnsCorrectModel()
        {
            using (var context = new ApplicationDbContext(_options))
            { 
                var controller = new BooksController(context);
                var result = await controller.Index();

                var viewResult = Assert.IsType<ViewResult>(result);
                var model = Assert.IsType<List<Book>>(viewResult.Model);
                Assert.Equal(2, model.Count());
            }
        }

        private void PopulateDb(ApplicationDbContext context)
        {
            context.Books.AddRange(new List<Book>()
            {
                new Book{Name="Book1", Author="Author1" },
                new Book{Name="Book2", Author="Author2"}
            });
            context.SaveChanges();
        }
    }
}
