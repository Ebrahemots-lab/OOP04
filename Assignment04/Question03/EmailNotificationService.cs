using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.Question03
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient,string message)
        {
            Console.WriteLine($"Sending Using Email To {recipient}: {message}");
        }
    }
}
