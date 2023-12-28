using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> assort = new List<Product>();
            Product item1 = new Product(100, 1, "Lays");
            Product item2 = new Product(50, 2, "Cola");
            Product item3 = new Bottle(150, 3, "Mineral Water", 101, (float)1.5);
            assort.Add(item1);
            assort.Add(item2);
            assort.Add(item3);

            HotDrink hotDrink1 = new HotDrink(120, 4, "Tea", 80);
            HotDrink hotDrink2 = new HotDrink(150, 5, "Coffee", 90);
            assort.Add(hotDrink1);
            assort.Add(hotDrink2);

            Holder hold1 = new Holder(4, 4);
            CoinDispenser coinDesp = new CoinDispenser(0);
            Display disp = new Display();

            VendingMachine venMachine = new VendingMachine(hold1, coinDesp, assort, disp);

            foreach (Product prod in venMachine.Products)
            {
                Console.WriteLine(prod);
            }

            MainFrame myFrame = new MainFrame();
            myFrame.Initialize();

        }
    }

    public class Product
    {
        public int Price { get; }
        public int Code { get; }
        public string Name { get; }

        public Product(int price, int code, string name)
        {
            Price = price;
            Code = code;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} - ${Price}";
        }
    }
    public class HotDrink : Product
    {
        public int Temperature { get; }

        public HotDrink(int price, int code, string name, int temperature)
            : base(price, code, name)
        {
            Temperature = temperature;
        }

        public override string ToString()
        {
            return $"{Name} - ${Price} (Temperature: {Temperature}°C)";
        }
    }

    public class Bottle : Product
    {
        public int BottleCode { get; }
        public float Volume { get; }

        public Bottle(int price, int code, string name, int bottleCode, float volume)
            : base(price, code, name)
        {
            BottleCode = bottleCode;
            Volume = volume;
        }

        public override string ToString()
        {
            return $"{Name} - ${Price} (Bottle Code: {BottleCode}, Volume: {Volume}L)";
        }
    }

    public class Holder
    {
        public int Capacity { get; }
        public int CurrentQuantity { get; }

        public Holder(int capacity, int currentQuantity)
        {
            Capacity = capacity;
            CurrentQuantity = currentQuantity;
        }
    }

    public class CoinDispenser
    {
        public int InitialAmount { get; }

        public CoinDispenser(int initialAmount)
        {
            InitialAmount = initialAmount;
        }
    }

    public class Display
    {
        // Add any display-related functionality here
    }

    public class VendingMachine
    {
        public Holder Holder { get; }
        public CoinDispenser CoinDispenser { get; }
        public List<Product> Products { get; }
        public Display Display { get; }

        public VendingMachine(Holder holder, CoinDispenser coinDispenser, List<Product> products, Display display)
        {
            Holder = holder;
            CoinDispenser = coinDispenser;
            Products = products;
            Display = display;
        }
    }

    public class MainFrame
    {
        // Add any main frame-related functionality here

        public void Initialize()
        {
            // Initialization logic goes here
        }
    }
}
    

