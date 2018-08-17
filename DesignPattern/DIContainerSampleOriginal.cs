using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class DIContainerSampleOriginal
    {
        public static void Excute()
        {
            new DIContainerSampleOriginal().Login("Master", "123", "EmailService");
        }
        public void Login(string userId, string pwd, string messageServiceType)
        {
            IMessageService msgService = null;
            // 用字串比對的方式來決定該建立哪一種訊息服務物件。
            switch (messageServiceType)
            {
                case "EmailService":
                    msgService = new EmailService();
                    break;
                case "ShortMessageService":
                    msgService = new ShortMessageService();
                    break;
                default:
                    throw new ArgumentException(" 無效的訊息服務型別!");
            }
            var authService = new AuthenticationService(msgService); // 注入相依物件。
            if (authService.TwoFactorLogin(userId, pwd))
            {
                // 與主題無關，故省略。
            }
            Console.ReadLine();
        }
    }
    public interface IMessageService
    {
        void Send();
    }
    public class ShortMessageService : IMessageService
    {
        public void Send()
        {
            Console.WriteLine("Send Short Message...");
        }
    }
    public class EmailService : IMessageService
    {
        public void Send()
        {
            Console.WriteLine("Send Email...");

        }
    }
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
