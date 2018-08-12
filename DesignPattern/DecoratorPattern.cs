using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class DecoratorPattern
    {
        public static void Excute()
        {
            Console.WriteLine("----Decorator Pattern (餐廳範例)-----");
            //點魚堡+A附餐
            IMeal order1 = new SideDishA(new FishBurger());
            Console.WriteLine("你點了: " + order1.GetName());
            Console.WriteLine("總金額: " + order1.GetPrice());
            Console.WriteLine("---------");
            //點牛肉堡+B附餐
            IMeal order2 = new SideDishB(new BeffBurger());
            Console.WriteLine("你點了: " + order2.GetName());
            Console.WriteLine("總金額: " + order2.GetPrice());
            Console.ReadLine();
        }
    }

    public interface IMeal
    {
        decimal GetPrice();

        string GetName();

    }

    public class BeffBurger : IMeal
    {
        public string GetName()
        {
            return "牛肉堡";
        }

        public decimal GetPrice()
        {
            return 80m;
        }
    }

    public class FishBurger : IMeal
    {
        public string GetName()
        {
            return "魚堡";
        }

        public decimal GetPrice()
        {
            return 100m;
        }
    }

    public class SideDishA : IMeal
    {
        public IMeal _MainMeal { get; set; }
        public SideDishA(IMeal mainMeal)
        {
            _MainMeal = mainMeal;
        }
        public string GetName()
        {
            return _MainMeal.GetName() + "附餐A 薯條 | 可樂";
        }

        public decimal GetPrice()
        {
            return _MainMeal.GetPrice() + 50m;
        }
    }

    public class SideDishB : IMeal
    {
        public IMeal _MainMeal { get; set; }
        public SideDishB(IMeal mainMeal)
        {
            _MainMeal = mainMeal;
        }

        public string GetName()
        {
            return _MainMeal.GetName() + "附餐B 雞塊 | 可樂";
        }

        public decimal GetPrice()
        {
            return _MainMeal.GetPrice() + 50m;
        }
    }
}
