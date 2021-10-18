using System;

namespace P3_Zad2
{
    class Product
    {
        private static int _nrOfInstances = 1;
        public string ProductName;
        public int Value;
        public int _id;
        public Product()
        {
            ProductName = "";
            Value = 0;
            _id = _nrOfInstances++;
        }
        public Product(string Name, int ValueOfProduct)
        {
            ProductName = Name;
            Value = 5;
            _id = _nrOfInstances++;
        }
        public override string ToString()
        {
            return $"Product: {ProductName} | Value: {Value} | ID: {_id} ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product mask = new Product();
            Product mask1 = new Product("Maska", 2);
            Product mask2 = new Product("Maska", 5);
            Console.WriteLine(mask.ToString());
            Console.WriteLine(mask1.ToString());
            Console.WriteLine(mask2.ToString());
        }
    }
}
