using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LibraryManagementSystem
{
    public class BookRepo
    {
        public static List<Book> Booklist = new List<Book>()
        {
            new Book(){Name = "Fault in our Stars" , BookId = 101, Price = 150 , Writer = "John Green"},
            new Book(){Name = "Thousand Splendid Suns" , BookId = 200, Price = 150 , Writer = "Khalid Hosseni"},
            new Book(){Name = "Kite Runner" , BookId = 103, Price = 250 , Writer = "Khalid Hosseni"},
            new Book(){Name = "As Long as the Lemon Trees Grow" , BookId = 104, Price = 250 , Writer = "Nadia Hashmi"},
            new Book(){Name = "Silent Patient" , BookId = 105, Price = 350 , Writer = "Alex"},
            new Book(){Name = "House Without Windows" , BookId = 106, Price = 150 , Writer = "Cooleen Hoover"},
            new Book(){Name = "Tuesdays With Morrie" , BookId = 107, Price = 200 , Writer = "Michael"},
            new Book(){Name = "Forest of Enchantments" , BookId = 108, Price = 250 , Writer = "Chitra Banerjee"},
            new Book(){Name = "Palace of Illusions" , BookId = 109, Price = 150 , Writer = "Chitra Banerjee"},
            new Book(){Name = "The Last Queen" , BookId = 110, Price = 100 , Writer = "Chitra Banerjee"},
            new Book(){Name = "Twisted Hate" , BookId = 111, Price = 350 , Writer = "Ana Huang"},
            new Book(){Name = "Twisted Love" , BookId = 112, Price = 200 , Writer = "Ana Huang"},
            new Book(){Name = "Karna's Wife" , BookId = 113, Price = 450 , Writer = "Urvi"},
            new Book(){Name = "Stationary Shop of Tehran" , BookId = 114, Price = 250 , Writer = "Nadia Hashmi"},
            new Book(){Name = "It Ends with Us" , BookId = 115, Price = 150 ,Writer = "Cooleen Hoover"},
            new Book(){Name = "It Starts with Us" , BookId = 116, Price = 100 , Writer = "Cooleen Hoover"},
            new Book(){Name = "Kafka of the Shore" , BookId = 117, Price = 250 , Writer = "Haruki Murakami"},
            new Book(){Name = "King of Wrath" , BookId = 118, Price = 350 , Writer = "Ana Huang"},
            new Book(){Name = "Looking for Alaska" , BookId = 119, Price = 400 , Writer = "John Green"},
            new Book(){Name = "And The Mountains Echoed" , BookId = 120, Price = 400 , Writer = "Khalid Hosseni"},
            new Book(){Name = "Archer's Voice" , BookId = 121, Price = 300 , Writer = "Archer"},
            new Book(){Name = "Letters to Milena" , BookId = 122, Price = 300 , Writer = "Franz Kafka"},
            new Book(){Name = "Twisted Games" , BookId = 123, Price = 150 , Writer = "Ana Huang"},
            new Book(){Name = "Twisted Lies" , BookId = 124, Price = 200 , Writer = "Ana Huang"}
        };

        public void AddBook(Book book)
        {
            Booklist.Add(book);
            Console.WriteLine("Book is Added to the List");
        }

        public void UpdateBook(int bookid , int bookPrice , string title , string publisher)
        {
            var book = Booklist.FirstOrDefault(b => b.BookId == bookid);

            if (book == null)
            {
                Console.WriteLine("Book not found");
                return;
            }

            book.Price = bookPrice;
            book.Name = title;
            book.Writer = publisher;

            Console.WriteLine("Record Updated Successfully !!");

        }

        public void DeleteBook(int bookid)
        {

            Booklist.RemoveAll(s => s.BookId ==  bookid);
            Console.WriteLine("Record Deleted Successfully !!");
            
        }

        public void ViewAllBooks()
        {
            Console.WriteLine("Here is the List of all the Books -- ");
            foreach(Book book in Booklist)
            {
                Console.WriteLine($"BookID: {book.BookId} |  Title: {book.Name} |  Writer: {book.Writer} |  Price: {book.Price}");
            }
        }

        public void SearchBookByName(string name)
        {
            var lis = from b in Booklist
                      where b.Name == name
                      select b;
            foreach(Book book in lis)
            {
                Console.WriteLine($"BookID: {book.BookId} |  Title: {book.Name} |  Writer: {book.Writer} |  Price: {book.Price}");
            }
        }

        public void SearchBookByPublisher(string publisher)
        {
            var lis = from b in Booklist
                      where b.Writer == publisher
                      select b;
            foreach (Book book in lis)
            {
                Console.WriteLine($"BookID: {book.BookId} |  Title: {book.Name} |  Writer: {book.Writer} |  Price: {book.Price}");
            }
        }

        public void MaxPriceBook()
        {
            int maxprice = Booklist.Select(b => b.Price).Max();
            Console.WriteLine($"Max Price Book Available in Store is {maxprice}");

            var lis = from b in Booklist
                      where b.Price == maxprice
                      select b;
            foreach (Book book in lis)
            {
                Console.WriteLine($"BookID: {book.BookId} |  Title: {book.Name} |  Writer: {book.Writer} |  Price: {book.Price}");
            }

        }

        public void MinPriceBook()
        {
            int minprice = Booklist.Select(b => b.Price).Min();
            Console.WriteLine($"Min Price Book Available in Store is {minprice}");

            var lis = from b in Booklist
                      where b.Price == minprice
                      select b;
            foreach (Book book in lis)
            {
                Console.WriteLine($"BookID: {book.BookId} |  Title: {book.Name} |  Writer: {book.Writer} |  Price: {book.Price}");
            }

        }

    }
}
