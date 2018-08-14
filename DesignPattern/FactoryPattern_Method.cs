using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class FactoryPattern_Method
    {
        public static void Excute()
        {
            Console.WriteLine("Factory Pattern Method Factory");

            UserFactory_Method factory1 = new NormalUserFactory();
            Console.WriteLine(factory1.CreateUser("Helga","Chen").ToString());

            UserFactory_Method factory2 = new AdminUserFactory();
            Console.WriteLine(factory2.CreateUser("Master", "Chuang").ToString());

            Console.ReadLine();
        }
    }

    public abstract class UserFactory_Method
    {
        public abstract User CreateUser(string firstName, string lastName);
    }

    public class NormalUserFactory : UserFactory_Method
    {
        public override User CreateUser(string firstName, string lastName)
        {
            return new User() { FirstName = firstName, LastName = lastName, IsAdmin = false };
        }
    }
    public class AdminUserFactory : UserFactory_Method
    {
        public override User CreateUser(string firstName, string lastName)
        {
            return new User() { FirstName = firstName, LastName = lastName, IsAdmin = true };
        }
    }
}
