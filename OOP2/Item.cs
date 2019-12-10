using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Item
    {

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private HashSet<String> clientsEmail;
        public HashSet<String> ClientsEmail
        {
            get { return clientsEmail; }
            set { clientsEmail = value; }
        }
    

        public Item(int id, String name, int amount)
        {
            this.id = id;
            this.name = name;
            this.amount = amount;
            this.clientsEmail = new HashSet<String>();

        }

        
        public void AddAmount( int amount)
        {
             Amount += amount;
            foreach (string i in ClientsEmail)
                {
                
                Email email = new Email();
                email.ItemsAdded(Id,Name,Amount,i);

            }
            ClientsEmail.Clear();
        }
        public void Subscribe(String email)
        {
            clientsEmail.Add(email);
        }
        public void Delete(String email)
        {
            clientsEmail.Remove(email);
        }
        public void Print()
        {
            Console.WriteLine("ID:" + Id.ToString() + " Назва: " + Name + " Кількість:" + Amount.ToString()); 
        }
    }
}
