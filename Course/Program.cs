﻿using Course.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 90.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));

//Comparison<Product> comp = CompareProducts;

//Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

//list.Sort(CompareProducts);

//list.Sort(comp);

//list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

//list.RemoveAll(p => p.Price >= 100.00);

list.RemoveAll(ProductTest);

foreach (var p in list)
{
    Console.WriteLine(p);
}

//static int CompareProducts(Product p1, Product p2)
//{
//    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
//}


static bool ProductTest(Product p)
{
    return p.Price >= 100.00;
}