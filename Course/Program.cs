using Course.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 90.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));
list.Add(new Product("HD Case", 80.90));

#region exercicios delegates lambda
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
#endregion

List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

foreach (var p in result)
{
    Console.WriteLine(p);
}

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