using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class CompositePattern
    {
        public static void Excute()
        {
            IProduct fish = new Fish("鮭魚");
            IProduct meat = new Fish("牛肉");
            IProduct beverage = new Fish("果汁");
            IProduct brush = new DailyNecessity() { Name = "刷子", Price = 10m };
            IProduct cup = new DailyNecessity() { Name = "杯子", Price = 15m };

            Casher casher = new Casher();
            casher.AddCart(fish);
            casher.AddCart(meat);
            casher.AddCart(beverage);
            casher.AddCart(brush);
            casher.AddCart(cup);

            casher.RemoveCart(beverage);
            casher.Caculate();
            Console.ReadLine();
        }
    }

    public class Casher
    {
        List<IProduct> Cart;
        public Casher()
        {
            Cart = new List<IProduct>();
        }

        public void AddCart(IProduct product)
        {
            Console.WriteLine(product.GetName() + "已經被加入購物車");
            Cart.Add(product);
        }

        public void RemoveCart(IProduct product)
        {
            Console.WriteLine(product.GetName() + "已經被移出購物車");
            Cart.Remove(product);
        }

        public void Caculate()
        {
            decimal total = 0;
            Cart.ForEach(p =>
            {
                total += p.GetPrice();
                Console.WriteLine(p.GetName() + "已結帳");
            });
            Console.WriteLine("總金額為:" + total);
        }
    }

    public interface IProduct
    {
        decimal GetPrice();

        string GetName();
    }

    public class Fish : IProduct
    {
        string Name;
        public Fish(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }

        public decimal GetPrice()
        {
            return 100m;
        }
    }

    public class Meat : IProduct
    {
        string Name;
        public Meat(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }

        public decimal GetPrice()
        {
            return 90m;
        }
    }

    public class Beverage : IProduct
    {
        string Name;
        public Beverage(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }

        public decimal GetPrice()
        {
            return 30m;
        }
    }

    public class DailyNecessity : IProduct
    {
        public string Name;

        public decimal Price;

        public string GetName()
        {
            return Name;
        }

        public decimal GetPrice()
        {
            return Price;

        }
    }
}