using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    /// <summary>
    /// class FactoryPattern_Sample
    /// </summary>
    public class FactoryPattern_Sample
    {
        public static void Excute()
        {
            Console.WriteLine("Factory Pattern Sample Factory");

            Console.WriteLine(UserFactory.CreateUser("Helga", "Chen").ToString());

            Console.WriteLine(UserFactory.CreateAdmin("Master", "Chuang").ToString());

            Console.ReadLine();
        }
    }

    public static class UserFactory
    {
        public static User CreateUser(string firstName, string lastName)
        {
            return new User() { FirstName = firstName, LastName = lastName, IsAdmin = false };
        }

        public static User CreateAdmin(string firstName, string lastName)
        {
            return new User() { FirstName = firstName, LastName = lastName, IsAdmin = true };
        }

    }

    public class User
    {
        public bool IsAdmin { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} is {(!IsAdmin ? "a nomarl user" : "an admininstrator")}";
        }
    }
}
