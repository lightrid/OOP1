
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage();
            storage.AddNewItem(new Item(0, "Телефон", 10));
            storage.AddNewItem(new Item(1, "Камера", 5));
            storage.AddNewItem(new Item(2, "Телевізор", 6));
            storage.AddNewItem(new Item(3, "Холодильник", 7));
            
            storage.AddNewClient(new Client(0, "lightrid@gmail.com", "1qwerty2", "Shop", "Univermag"));
            storage.AddNewClient(new Client(1, "ariana.ua57@gmail.com", "1qwerty2", "Shop", "Magazyn"));
            storage.AddNewClient(new Client(2, "lightrid2@gmail.com", "1qwerty2", "Shop", "Allo"));
            storage.AddNewClient(new Client(3, "lightrid3@gmail.com", "1qwerty2", "Shop", "Foxtrot"));
          
            Console.WriteLine("Доступні товари:");
            storage.ShowItems();
            Console.WriteLine("Видача 11 одиниць Телефонів:");
            storage.Buy(storage.Items[0], storage.Clients[0],11);
            storage.ShowItems();
            Console.WriteLine("Додавання відсутніх позицій");
            storage.Items[0].AddAmount(99);
            storage.ShowItems();


            Console.ReadLine();
        }
    }
}
