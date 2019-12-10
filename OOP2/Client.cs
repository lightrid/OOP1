using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Client : User
    {

       
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }


        public Client()
        {

        }

        public Client(int id, String email, String password, String type, String name)
            : base(id, email, password, type)
        {
            this.name = name;
         
        }
        












/*
        public Item Buy(Item item, int amount)
        {
            if (item.Amount == 0)
            {
                Subscribe(item);
                return item;
            }
            else
            {
                item.Amount -= amount;
                if (item.Amount > 0)
                {
                    Delete(item);
                    return item;
                }
                else
                {
                    Subscribe(item);
                    return item;
                }
            }

        }*/



    }
}
