using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask11._3
{
    internal class Library
    {
        public Book[] books;



        int j = 0;
        public Book[] AddBook(Book book)
        {
            books[j++] = book;
            return books;
        }
        public Book[] GetFilteredBooks(string genre)
        {
            int count = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Genre == genre)
                {
                    count++;
                }
            }
            Book[] books2 = new Book[count];
            int count2 = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Genre == genre)
                {
                    books2[count2] = books[i];
                    count2++;
                }
            }
            return books2;
        }

        public Book[] GetFilteredPrice(double MinPrice, double MaxPrice)
        {
            int count3 = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Price > MinPrice && books[i].Price < MaxPrice)
                {
                    count3++;
                }
            }
            Book[] books3 = new Book[count3];
            int j = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Price > MinPrice && books[i].Price < MaxPrice)
                {
                    books3[count3] = books[i];
                    count3++;
                }
            }
            return books3;
        }

        public void GetInfo(Book[] book)
        {
            foreach (var item in book)
            {
                Console.WriteLine($"Name:{item.Name} Genre:{item.Genre} No:{item.No} Price:{item.Price} Count:{item.Count}");
            }
        }
    }
}
