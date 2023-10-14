using Week_5.Context;
using Week_5.Entities;

ShopifyDbContext _context = new ();

Product product1 = new Product("Zippo Gold Lighter", 0.02m, 2000m);
_context.Products.Add(product1);

List<Product> products = new List<Product>()
{
    new Product("Zippo Silver Lighter", 0.02m, 1500m),
    new Product("Zippo Black Lighter", 0.02m, 1000m),
    new Product("Zippo White Lighter", 0.02m, 500m),
    new Product("Zippo Red Lighter", 0.02m, 250m),
    new Product("Zippo Blue Lighter", 0.02m, 125m),
    new Product("Zippo Green Lighter", 0.02m, 75m),
    new Product("Zippo Yellow Lighter", 0.02m, 50m),
    new Product("Zippo Pink Lighter", 0.02m, 25m),
    new Product("Zippo Purple Lighter", 0.02m, 10m),
    new Product("Zippo Orange Lighter", 0.02m, 5m),
};

_context.Products.AddRange(products);
_context.SaveChanges();

List<Product> products = _context.Products.ToList();
foreach (Product product in products)
{
    Console.WriteLine(product.Title);
}

_context.Products.Where(p => p.Price > 1000).ToList().ForEach(p => Console.WriteLine(p.Title));
