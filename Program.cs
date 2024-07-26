using System.Globalization;
using sale.Entities;

namespace sale{
    class Program{
        static void Main(string[] args){

            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++){
            Console.WriteLine($"Product #{i} data:");
            Console.Write("Common, used or imported (c/u/i)? ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            if (ch == 'i'){
                Console.Write("Costums fee: ");
                double costumsFee = double.Parse(Console.ReadLine());
                list.Add(new ImportedProduct(name, price, costumsFee));
            }
            else if (ch == 'u'){
                Console.Write("Manufacture date (DD/MM/YYY)");
                DateTime date = DateTime.Parse(Console.ReadLine());
                list.Add(new UsedProduct(name, price, date));
            }
            else{
                list.Add(new Product(name, price));
            }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach(Product p in list){
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}