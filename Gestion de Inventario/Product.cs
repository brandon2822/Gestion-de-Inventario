using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Inventario
{
    class Product
    {
        //Atributos
        private string name;
        private double price;
        private int stock;

        //Constructores
        public Product()
        {
            name = "";
            price = 0;
            stock = 0;
        }

        public Product(string name, double price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        // Metodos
        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public double getPrice()
        {

            return price;

        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getStock()
        {
            return stock;
        }

        public void setStock(int stock)
        {
            this.stock = stock;
        }

        public void getProductInfo()
        {
            Console.WriteLine($"Name: {this.name} \n Price: c{this.price} \n Stock: {this.stock}");
        }

    }
}