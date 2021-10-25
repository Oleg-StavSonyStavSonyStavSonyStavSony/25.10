using System;
using System.IO;
using System.Linq;

namespace _25._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter FIO");
            Console.WriteLine("Enter FirstName");
            User user = new User();
            user.FirstName = Console.ReadLine();

            Console.WriteLine("Enter LastName");
            user.LastName  = Console.ReadLine();

            Console.WriteLine("Enter Age");
            user.Age = int.Parse(Console.ReadLine());
            //File.Delete("text.txt");

            File.AppendAllText("text.txt", $"Name : {user.FirstName}\nLName : {user.LastName}\nAge : {user.Age}\n");
            File.AppendAllText("text.txt",  "--------------------------------------------------------\n");
            // File.ReadAllLines("text.txt").ToList().ForEach(Console.WriteLine);
           
            // считать текст в массив строк
            User user1 = new User();
           // File.ReadAllLines("text.txt").ToList().ForEach(Console.WriteLine);
            string[] arr = File.ReadAllLines("text.txt");

            //Console.WriteLine($"{arr[0].Split(":")[1]}");

            for (int i = 0; i < arr.Length; i+=4)
            {
                //if ((i%3 == i + 3) )
              //  {
               //     continue;
              //  }
                arr[i].Split(":");
                user1.FirstName = arr[i].Split(":")[i];
                arr[i].Split(":");
                user1.LastName = arr[i+1].Split(":")[i+1];
                arr[i].Split(":");
                user1.Age = int.Parse(arr[i+2].Split(":")[i+1]);
                Console.WriteLine(user1);
            }

          


        }
    }
}
