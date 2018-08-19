using DesignPattern.DIContainer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DIContainer
{
    public class AuthenticationService
    {
        public AuthenticationService(IMessageService service)
        {
            service.Send();
        }
        public bool TwoFactorLogin(string userId, string pwd)
        {
            return true;
        }
    }
}
