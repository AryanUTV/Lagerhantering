namespace Lagerhantering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Lagerhantering====");
            Console.WriteLine();
            Console.WriteLine("1. Visa produkter");
            Console.WriteLine("2. Lägg till produkt");
            Console.WriteLine("3. Ta bort produkt");
            Console.WriteLine("4. Sök efter produkt");
            Console.WriteLine("5. Uppdatera lager");
            Console.WriteLine("6. Avsluta");

            List<Product> products = new List<Product>();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("====Lagerhantering====");
                Console.WriteLine();
                Console.WriteLine("1. Visa produkter");
                Console.WriteLine("2. Lägg till produkt");
                Console.WriteLine("3. Ta bort produkt");
                Console.WriteLine("4. Sök efter produkt");
                Console.WriteLine("5. Uppdatera lager");
                Console.WriteLine("6. Avsluta");
                Console.WriteLine();
                Console.Write("Välj: ");
                string input = Console.ReadLine();
                int choice;

                if(int.TryParse(input, out choice))
                {
                    if(choice == 1)
                    {
                        foreach(Product product in products)
                        {
                            Console.WriteLine("Produkt: " + product.Name);
                            Console.WriteLine("Pris: " + product.Price);
                            Console.WriteLine("Antal: " + product.Quantity);
                            Console.WriteLine();
                            
                        }
                        Console.WriteLine("Tryck på enter för att fortsätta...");
                        Console.ReadLine();

                    }
                    else if (choice == 2)
                    {
                        Console.Write("Produktnamn: ");
                        string name = Console.ReadLine();

                        Console.Write("Pris: ");
                        double price;

                        while (!double.TryParse(Console.ReadLine(), out price))
                        {
                            Console.Write("Felaktigt pris! Skriv ett nummer: ");
                        }

                        Console.Write("Antal: ");
                        int quantity;

                        while (!int.TryParse(Console.ReadLine(), out quantity))
                        {
                            Console.Write("Felaktigt antal! Skriv ett heltal: ");
                        }

                        Product product = new Product();

                        product.Name = name;
                        product.Price = price;
                        product.Quantity = quantity;

                        products.Add(product);

                        Console.WriteLine();
                        Console.WriteLine(product.Name + " har lagts till!");
                        Console.WriteLine("Tryck på Enter för att fortsätta...");
                        Console.ReadLine();
                    }
                    else if (choice == 3)
                    {
                        Console.Write("Vilken produkt vill du ta bort?: ");
                        string name = Console.ReadLine();

                        Product productToRemove = null;

                        foreach (Product product in products)
                        {
                            if (product.Name == name)
                            {
                                productToRemove = product;
                            }
                            
                        }
                        if (productToRemove != null)
                        {
                            products.Remove(productToRemove);
                            Console.WriteLine(productToRemove.Name + ": har tagits bort! ");
                        }
                        else
                        {
                            Console.WriteLine("Den produkten finns inte!");
                        }
                        Console.WriteLine("Tryck på Enter för att fortsätta...");
                        Console.ReadLine();
                    }
                    else if (choice == 4)
                    {
                        Console.Write("Sök efter produkt: ");
                        string name = Console.ReadLine();

                        bool found = false;
                        foreach(Product product in products)
                        {
                            if (product.Name.Replace(" ", "").ToLower() == name.Replace(" ", "").ToLower())
                            {
                                Console.WriteLine("Produkt hittad!");
                                Console.WriteLine();
                                Console.WriteLine("Namn: " + product.Name);
                                Console.WriteLine("Pris: " + product.Price + " kr");
                                Console.WriteLine("Antal: " + product.Quantity);

                                found = true;
                            }
                        }
                        if(!found)
                        {
                            Console.WriteLine("Den produkten finns inte!");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Tryck på Enter för att fortsätta...");
                        Console.ReadLine();
                    }
                    else if (choice == 5)
                    {
                        Console.Write("Vilken produkt vill du uppdatera: ");
                        string name = Console.ReadLine();

                        bool found = false;
                        foreach(Product product in products)
                        {
                            if (product.Name.Replace(" ", "").ToLower() == name.Replace(" ", "").ToLower())
                            {
                                Console.Write("Nytt antal: ");
                                int newQuantity = int.Parse(Console.ReadLine());
                                product.Quantity = newQuantity;
                                Console.WriteLine();
                                Console.WriteLine(product.Name + " har nu: " + newQuantity + " i lager!");

                                found = true;
                            }
                        }
                        if(!found)
                        {
                            Console.WriteLine("Den produkten finns inte!");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Tryck på Enter för att fortsätta...");
                        Console.ReadLine();
                    }
                    else if (choice == 6)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Du måste välja ett nummer från 1 - 6");
                        Console.WriteLine("Tryck på Enter för att fortsätta...");
                        Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("Du måste skriva in ett nummer");
                    Console.WriteLine("Tryck på Enter för att fortsätta...");
                    Console.ReadLine();
                }
            }
        }
    }
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}


                    

                            
