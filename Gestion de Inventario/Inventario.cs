using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Inventario
{
    class Inventario
    {
        //Atributos
        List<Product> products;

        //Constructor
        public Inventario(List<Product> products)
        {
            this.products = products;
        }

        //Metodos
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void GetProducts()
        {
            int contador_productos = 1;
            foreach (Product product in products)
            {
                Console.WriteLine($"{contador_productos}: {product.getName()}");
                contador_productos++;
            }
        }

        public void Search(string productName)
        {
            foreach (Product product in products)
            {
                if (productName == product.getName())
                {
                    product.getProductInfo();
                }
            }

        }

    }
}