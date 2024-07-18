using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.Question03
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient ,string message)
        {
            Console.WriteLine($"Sending Through SMS To {recipient}: {message}");
        }
    }
}
