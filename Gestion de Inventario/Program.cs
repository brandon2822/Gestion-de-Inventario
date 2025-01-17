using System;
using System.Collections.Generic;

namespace Gestion_Inventario
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Telefono", 250.000, 10);
            Product product2 = new Product("PS5", 300.000, 5);
            Product product3 = new Product("HeadSet", 75.000, 15);
            Product product4 = new Product("Laptop", 325.000, 6);
            List<Product> products = new List<Product> { product1, product2, product3, product4 };

            Inventario inventario = new Inventario(products);
            string menu = "\n 1-Agregar producto.\n 2-Listar productos. \n 3-Buscar producto. \n 4-Salir. \n";
            string option;

            do
            {
                Console.WriteLine(menu);
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("ingrese el nombre del producto: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("ingrese el precio del producto: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el stock del producto: ");
                        int stock = Int32.Parse(Console.ReadLine());

                        Product newProduct = new Product(name, price, stock);
                        inventario.AddProduct(newProduct);
                        Console.WriteLine($"El producto {newProduct.getName()} ha sido añadido.");
                        break;
                    case "2":
                        inventario.GetProducts();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el nombre del producto que desea buscar: ");
                        string product_name = Console.ReadLine();

                        inventario.Search(product_name);
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opcion Invalida...");
                        break;

                }
            } while (option != "4");


        }
    }
}