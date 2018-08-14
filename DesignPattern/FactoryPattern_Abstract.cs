using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class FactoryPattern_Abstract
    {
        public static void Excute()
        {
            Console.WriteLine("Factory Pattern Abstract Factory");

            IFactory factory = new WindowsUserFactory();
            Console.WriteLine(factory.CreateNormalUser("Helga", "Chen").ToString());

            factory = new LinuxUserFactory();
            Console.WriteLine(factory.CreateAdminUser("Master", "Chuang").ToString());
            Console.ReadLine();
        }
    }
    public interface IFactory
    {
        User CreateNormalUser(string firstName, string lastName);

        User CreateAdminUser(string firstName, string lastName);


    }

    public class WindowsUserFactory : IFactory
    {
        public User CreateAdminUser(string firstName, string lastName)
        {
            return new User() { FirstName = firstName, LastName = lastName, IsAdmin = true };
        }

        public User CreateNormalUser(string firstName, string lastName)
        {
            return new User() { FirstName = firstName, LastName = lastName, IsAdmin = false };
        }
    }

    public class LinuxUserFactory : IFactory
    {
        public User CreateAdminUser(string firstName, string lastName)
        {
            return new User() { FirstName = firstName, LastName = lastName, IsAdmin = true };
        }

        public User CreateNormalUser(string firstName, string lastName)
        {
            return new User() { FirstName = firstName, LastName = lastName, IsAdmin = false };
        }
    }
}
