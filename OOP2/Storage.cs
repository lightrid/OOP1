using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Storage
    {
        private List<Item> items;
        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }
        private Item item;

        private List<Client> clients;
        public List<Client> Clients
        {
            get { return clients; }
            set { clients = value; }
        }
        private Item client;
        public Storage()
        {
            items = new List<Item>();
            clients = new List<Client>();
        }
       
        public void DeleteItem(Item item)
        {
            Items.Remove(item);
        }
        public void AddNewItem(Item item)
        {
            items.Add(item);
        }
        public void AddNewClient(Client client)
        {
            clients.Add(client);
        }

        public void Add(int id, int amount)
        {
            Items[id].Amount = +amount;
        }
        public void ShowItems()
        {
            foreach (Item i in Items)
            {
                i.Print();
            }
        }
        public void Buy(Item item, Client client, int amount)
        {
            if (items[item.Id].Amount == 0)
            {
                item.Subscribe(client.Email);
                
            }
            else
            {
                items[item.Id].Amount -= amount;
                if (items[item.Id].Amount >= 0)
                {
                    item.Delete(client.Email);
                }
                else
                {
                    item.Subscribe(client.Email);
                    items[item.Id].Amount = 0;
                }
            }

        }
    }
}
