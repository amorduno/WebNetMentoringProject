
using System;
using ClientWebNetMentoringAPI;

var client = new Client("https://localhost:7004", new System.Net.Http.HttpClient());

//--------------------------------------------------------------------------------//
//---------------------------------CREATE-----------------------------------------//
//--------------------------------------------------------------------------------//
Console.WriteLine("---------------");
Console.WriteLine("Create Category");
Console.WriteLine("---------------");

var createCategory = new CategoryDto() { Name = "Shoes", Description = "Nike predator" };
var category = client.CategoryPOSTAsync(createCategory);

Console.WriteLine();
Console.WriteLine("New category was created successfully");
Console.WriteLine();

//--------------------------------------------------------------------------------//
//-----------------------------------GET------------------------------------------//
//--------------------------------------------------------------------------------//
Console.WriteLine("---------------");
Console.WriteLine("Get all Categories");
Console.WriteLine("---------------");

var getCategories = await client.CategoryAllAsync();
int c = 0;

foreach (var item in getCategories)
{    
    Console.WriteLine("CATEGORY " + ++c + ":");
    Console.WriteLine("Id: " + item.Id);
    Console.WriteLine("Name: " + item.Name);
    Console.WriteLine("Description: " + item.Description);
    Console.WriteLine();    
}

Console.ReadLine();
