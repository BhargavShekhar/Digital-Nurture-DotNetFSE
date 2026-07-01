using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;

using var db = new AppDbContext();

if (!db.Categories.Any())
{
    var electronics = new Category { Name = "Electronics" };
    var grocery = new Category { Name = "Grocery" };

    db.Categories.AddRange(electronics, grocery);
    db.SaveChanges();

    db.Products.AddRange(
        new Product
        {
            Name = "Laptop",
            Price = 75000,
            CategoryId = electronics.Id
        },
        new Product
        {
            Name = "Mouse",
            Price = 1200,
            CategoryId = electronics.Id
        },
        new Product
        {
            Name = "Rice",
            Price = 60,
            CategoryId = grocery.Id
        });

    db.SaveChanges();
}

Console.WriteLine("Products:");

var products = db.Products
    .Include(p => p.Category)
    .ToList();

foreach (var product in products)
{
    Console.WriteLine(
        $"{product.Id} | {product.Name} | ₹{product.Price} | {product.Category?.Name}");
}

Console.WriteLine("\nUpdating Mouse price...");

var mouse = db.Products.FirstOrDefault(p => p.Name == "Mouse");

if (mouse != null)
{
    mouse.Price = 1500;
    db.SaveChanges();
}

Console.WriteLine("Deleting Rice...");

var rice = db.Products.FirstOrDefault(p => p.Name == "Rice");

if (rice != null)
{
    db.Products.Remove(rice);
    db.SaveChanges();
}

Console.WriteLine("\nFinal Products:");

foreach (var product in db.Products.Include(p => p.Category))
{
    Console.WriteLine(
        $"{product.Id} | {product.Name} | ₹{product.Price} | {product.Category?.Name}");
}