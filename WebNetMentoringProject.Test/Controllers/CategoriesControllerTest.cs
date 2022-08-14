using Microsoft.AspNetCore.Mvc;
using WebNetMentoringProject.Controllers;
using WebNetMentoringProject.Models;
using Microsoft.EntityFrameworkCore;


namespace WebNetMentoringProject.Test.Controllers
{
    public class CategoriesControllerTest
    {
        //[Fact]
        //public async void VerifyModelWhenIndex()
        //{
        //    var context = await GetDBContext();
        //    var controller = new CategoriesController(context);

        //    var result = controller.Index();
        //    var model = ((ViewResult)result.Result).Model;

        //    Assert.NotNull(model);
        //    Assert.Equal(1, ((List<Category>)model)[0].Id);
        //    Assert.Equal("Software", ((List<Category>)model)[0].Name);
        //    Assert.Equal(".Net", ((List<Category>)model)[0].Description);
        //    Assert.Equal(2, ((List<Category>)model)[1].Id);
        //    Assert.Equal("Books", ((List<Category>)model)[1].Name);
        //    Assert.Equal("best seller", ((List<Category>)model)[1].Description);
        //    Assert.Equal(3, ((List<Category>)model)[2].Id);
        //    Assert.Equal("Movies", ((List<Category>)model)[2].Name);
        //    Assert.Equal("top ten", ((List<Category>)model)[2].Description);
        //}

        //[Fact]
        //public async void VerifyModelWhenDetails()
        //{
        //    var context = await GetDBContext();
        //    var controller = new CategoriesController(context);

        //    var result = controller.Details(1);
        //    var model = ((ViewResult)result.Result).Model;

        //    Assert.NotNull(model);
        //    Assert.Equal(1, ((Category)model).Id);
        //    Assert.Equal("Software", ((Category)model).Name);
        //    Assert.Equal(".Net", ((Category)model).Description);
        //}

        //[Fact]
        //public async void VerifyIndexActionWhenCreate()
        //{
        //    var category = new Category()
        //    {
        //        Name = "Software",
        //        Description = ".Net"
        //    };
        //    var context = await GetDBContext();
        //    var controller = new CategoriesController(context);

        //    var result = controller.Create(category);
        //    var viewResult = ((RedirectToActionResult)result.Result).ActionName;

        //    Assert.NotNull(viewResult);
        //    Assert.Equal("Index", viewResult);
        //}

        //[Fact]
        //public async void VerifyWhenEdit()
        //{
        //    var category = new Category()
        //    {
        //        Id = 2,
        //        Name = "Books",
        //        Description = "Paramo", 
        //        Picture = null,
        //        Product = null
        //    };
        //    var context = await GetDBContext();
        //    var controller = new CategoriesController(context);

        //    var result = controller.Edit(2, category);
        //    var model = ((ViewResult)result.Result).Model;

        //    Assert.NotNull(model);
        //    Assert.Equal(1, ((Category)model).Id);
        //    Assert.Equal("Computers", ((Category)model).Name);
        //    Assert.Equal("HP ZBook", ((Category)model).Description);
        //}

        //[Fact]
        //public async void VerifyWhenDelete()
        //{
        //    var context = await GetDBContext();
        //    var controller = new CategoriesController(context);

        //    Assert.Equal(3, context.Categories.Count());

        //    var result = controller.DeleteConfirmed(1);
        //    var viewResult = ((RedirectToActionResult)result.Result).ActionName;

        //    Assert.Equal(2, context.Categories.Count());            

        //    Assert.NotNull(viewResult);
        //    Assert.Equal("Index", viewResult);
        //}

        //private async Task<DBShopContext> GetDBContext()
        //{
        //    var options = new DbContextOptionsBuilder<DBShopContext>()
        //        .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
        //        .Options;
        //    var context = new DBShopContext(options);
        //    context.Database.EnsureCreated();


        //    var softwareCategory = new Category { Name = "Software", Description = ".Net" };
        //    var booksCategory = new Category { Name = "Books", Description = "best seller" };
        //    var moviesCategory = new Category { Name = "Movies", Description = "top ten" };
        //    context.Categories.Add(softwareCategory);
        //    context.Categories.Add(booksCategory);
        //    context.Categories.Add(moviesCategory);

        //    await context.SaveChangesAsync();

        //    return context;
        //}
    }
}
