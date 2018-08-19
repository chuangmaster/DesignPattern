using DesignPattern.DIContainer;
using DesignPattern.DIContainer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class DIContainerSampleV2
    {
        public static void Excute()
        {
            DIContainerV2.Register<IMessageService, EmailService>();
            var service = (IMessageService)DIContainerV2.Resolve<IMessageService>();
            var auth = new AuthenticationService(service);
            Console.ReadLine();
        }
    }

    public class DIContainerV2
    {
        static readonly Dictionary<Type, Type> _TypeMap = new Dictionary<Type, Type>();

        public static void Register<TypeToResolve, ConcreteType>()
        {
            _TypeMap.Add(typeof(TypeToResolve), typeof(ConcreteType));
        }

        public static object Resolve<TypeToResolve>()
        {
            var concreteType = _TypeMap[typeof(TypeToResolve)];
            object instance = Activator.CreateInstance(concreteType);
            return instance;
        }
    }
}
