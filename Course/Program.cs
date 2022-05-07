using Course.Entities;

static void Print<T>(string message, IEnumerable<T> collection)
{
    Console.WriteLine(message);

    foreach (var item in collection)
    {
        Console.WriteLine(item);
        
    }
    Console.WriteLine();
}

Category c1 = new Category() {Id = 1,Name = "Tools", Tier = 2};
Category c2 = new Category() {Id = 3, Name = "Computers", Tier = 1};
Category c3 = new Category() {Id = 3, Name = "Eletronics", Tier = 1};

List<Product> products = new List<Product>() { 
    new Product() {Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
    new Product() {Id = 2, Name = "Hammer", Price = 90.0, Category= c1 },
    new Product() {Id = 3, Name = "TV", Price = 1300.0, Category = c3},
    new Product() {Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
    new Product() {Id = 4, Name = "Saw", Price = 80.0, Category = c1 },
    new Product() {Id = 4, Name = "Tablet", Price = 700.0, Category = c2 },
    new Product() {Id = 4, Name = "Camera", Price = 700.0, Category = c3 },
    new Product() {Id = 4, Name = "Printer", Price = 350.0, Category = c3 },
    new Product() {Id = 4, Name = "Macbook", Price = 1800.0, Category = c2 },
    new Product() {Id = 4, Name = "Sound Bar", Price = 700.0, Category = c3 },
    new Product() {Id = 4, Name = "Level", Price = 70.0, Category = c1 }
};

var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
Print("TIER 1 AND PRICE < 900:", r1);

var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
Print("NAMES OF PRODUCTS FROM TOLLS", r2);

var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name});
Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT:", r3);

var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
Print("TIER 1 ORDER BY PRICE THEN BY NAME:", r4);

var r5 = r4.Skip(2).Take(4);
Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4:", r5);

var r6 = products.First();
Console.WriteLine("First test1: " + r6);
var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
Console.WriteLine("First or defaul test2: " + r7);
Console.WriteLine();

var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
Console.WriteLine("Single or default test1: " + r8);

var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
Console.WriteLine("Single or default test2: " + r9);
Console.WriteLine();

var r10 = products.Max(p => p.Price);
Console.WriteLine("Max price: " + r10);
var r11 = products.Min(p => p.Price);
Console.WriteLine("Min price: " + r11);
var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
Console.WriteLine("Category 1 Sum prices: " + r12);
var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
Console.WriteLine("Category 1 Average prices: " + r13);
var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine("Category 5 Average prices: " + r14);
//var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
//Console.WriteLine("Category 1 aggregate sum: " + r15);
var r15 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
Console.WriteLine("Category 1 aggregate sum: " + r15);
Console.WriteLine();

var r16 = products.GroupBy(p => p.Category);
foreach(var group in r16)
{
    Console.WriteLine("Category" + group.Key.Name + ":");
    foreach (var item in group)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();
}

#region exercicios delegates lambda
//List<Product> list = new List<Product>();

//list.Add(new Product("TV", 90.00));
//list.Add(new Product("Notebook", 1200.00));
//list.Add(new Product("Tablet", 450.00));
//list.Add(new Product("HD Case", 80.90));

//Comparison<Product> comp = CompareProducts;
//Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
//list.Sort(CompareProducts);
//list.Sort(comp); //Comparison<T>
//list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
//list.RemoveAll(p => p.Price >= 100.00); //delegate Predicate
//list.RemoveAll(ProductTest);
//list.ForEach(UpdatePrice);
//Action<Product> act = UpdatePrice;
//Action<Product> act = p => { p.Price += p.Price * 0.1; };
//list.ForEach(act);
//list.ForEach(p => { p.Price += p.Price * 0.1; });
//Func<Product, string> func = NameUpper;
//Func<Product, string> func = p => p.Name.ToUpper();

//List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

//foreach (var p in result)
//{
//    Console.WriteLine(p);
//}
#endregion

/* List<string> result = products.Select(p => p.Name.ToUpper()).ToList();

foreach (var p in result)
{
    Console.WriteLine(p);
} */

//static string NameUpper(Product p)
//{
//    return p.Name.ToUpper();
//}

//static int CompareProducts(Product p1, Product p2)
//{
//    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
//}


//static bool ProductTest(Product p)
//{
//    return p.Price >= 100.00;
//}

//static void UpdatePrice(Product p)
//{
//    p.Price += p.Price * 0.1;
//}