using EntityFrameworkYTdotnet.Models;
using EntityFrameworkYTdotnet.Data;

using ContosPizzaContext context = new ContosPizzaContext();
// To create product on database:

// to work with Entity Framework you need 3 packaages: 1. Entity Framework Core,
// 2. Entity Framework core sqlserver
// 3. Entity Framework core Tools

//Product veggieSpecial = new Product()
//{
//    name= "Veggie Special Pizza",
//    price = 9.99M
//};
//context.Products.Add(veggieSpecial);

//Product deluxeMeat = new Product()
//{
//    name="Deluxe Meat Pizza",
//    price= 12.99M
//};
//context.Add(deluxeMeat);
//context.SaveChanges();  


var veggieSpecial= context.Products.Where(p=> p.name=="Veggie Special Pizza").FirstOrDefault();

if (veggieSpecial is Product)
{
    veggieSpecial.price = 10.99M;

}
// To remove:

if (veggieSpecial is Product)
{ 

    context.Remove(veggieSpecial);

}


context.SaveChanges();

var products= from product in context.Products
              where product.price>10.00M
              orderby product.name
              select product;

foreach (Product p in products)
{
    Console.WriteLine($"Id: {p.Id}");
    Console.WriteLine($"Name: {p.name}");
    Console.WriteLine($"Price: {p.price}");
    Console.WriteLine(new string('-', 20));

}