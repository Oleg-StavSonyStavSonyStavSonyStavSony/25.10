using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace _25._10
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            List<User> userlistSeve = new List<User>{
            new User ( "VAsya", "Vasilevich", 25 ),
            new User("Petya", "Petrovich", 22)};
            user1.SeveListUser(userlistSeve);
            /*Console.WriteLine("Enter FIO");
            Console.WriteLine("Enter FirstName");
            User user = new User();
            user.FirstName = Console.ReadLine();

            Console.WriteLine("Enter LastName");
            user.LastName  = Console.ReadLine();

            Console.WriteLine("Enter Age");
            user.Age = int.Parse(Console.ReadLine());*/
            //File.Delete("text.txt");

            // считать текст в массив строк

            List<User> userlist = new List<User>();
            user1.LoadListUser(userlist);
            foreach (var item in userlist)
            {
                Console.WriteLine(item);
            }
            //File.ReadAllLines("text.txt").ToList().ForEach(Console.WriteLine);

        }
    }
}
