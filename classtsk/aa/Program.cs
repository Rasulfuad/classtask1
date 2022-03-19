using aa.Models;
using System;

namespace aa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Say daxil edin");
            int count =Convert.ToInt32(Console.ReadLine());
            Book[] books = new Book[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Genre daxil et");
                string genre = Console.ReadLine();

                Console.WriteLine("Nomreni daxil edin");
                int no = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Adi daxil edin");
                string name=Console.ReadLine();

                Console.WriteLine("Price daxil edin");
                int price=Convert.ToInt32(Console.ReadLine());

                Book book=new Book(genre,no,name,price);
                books[i] = book;
            }
            Console.WriteLine(books.Length);
            





        }
    }
}
