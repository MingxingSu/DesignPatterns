using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Observer
{
    //Abstract Subject
    public class BaseMessage
    {
        public BaseMessage(string messageType, string messageContent)
        {
            MessageType = messageType;
            MessageContent = messageContent;
            Clients = new List<Client>(10);
        }
        public string MessageType { get; set; }
        public string MessageContent { get; set; }
        public List<Client> Clients { get; set; }

        //Notify method
        public virtual void SendMessage()
        {
            foreach (var c in Clients)
            {
               c.CheckMessage();
            }
        }

        //Register observer
        public virtual bool AddClient(Client client)
        {
            if (client == null)
                throw new ArgumentNullException();

            if (Clients.Contains(client) == false)
            {
                Clients.Add(client);
                return true;
            }
            throw new Exception("Client already exists!");
        }

        //Un-register observer
        public virtual bool RemoveClient(Client client)
        {
            if (client == null)
                throw new ArgumentNullException();

            if (Clients.Contains(client))
            {
                Clients.Remove(client);
                return true;
            }
            throw new Exception("Client not exists!");
        }
    }
}
