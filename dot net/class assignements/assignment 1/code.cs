using System;
using System.Collections.Generic;

namespace SierraFirstApp
{
    internal class Program
    {
        class Book
        {
            public string bookName { get; set; }
            public string authorName { get; set; }
            public int bookPrice { get; set; }
            public int bookQuantity { get; set; }
        }

        class report
        {
            public string bookName { get; set; }
            public string customerName { get; set; }

            public int quantity { get; set; }

        }
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>();

            List<report> reportList = new List<report>();

            int inputChoice;

            do
            {
                Console.WriteLine("====== BOOK SHOP MENU ====== \n1. Add Book\r\n2. Sell Book\r\n3. View Books\r\n4. View Sales Report\r\n5. Exit\r\n============================");


                inputChoice = Convert.ToInt32(Console.ReadLine());
                switch (inputChoice)
                {
                    case 1:
                        addBooks(ref bookList);
                        break;
                    case 2:
                        sellBoosk(ref bookList, ref reportList);
                        break;
                    case 3:
                        viewBooks(bookList);
                        break;
                    case 4:
                        viewReport(reportList);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (inputChoice != 5);
        }

        static void sellBoosk(ref List<Book> bookList , ref List<report> reportList)
        {
            Console.WriteLine("Enter the book to Sell:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the quantity to Sell");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the customer name");
            string customer  = Console.ReadLine();

            foreach (var book in bookList)
            {
                if (book.bookName == name)
                {
                    book.bookQuantity = book.bookQuantity - quantity;

                }
            }

            report report = new report();
            report.bookName = name;
            report.quantity = quantity;
            report.customerName = customer;

            reportList.Add(report);


        }


        static void addBooks(ref List<Book> booksList)
        {
            Console.WriteLine("Enter the book name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the book author:");
            string authorName = Console.ReadLine();

            Console.WriteLine("Enter the book quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the book price:");
            int price = Convert.ToInt32(Console.ReadLine());

            Book b = new Book
            {
                bookName = name,
                authorName = authorName,
                bookPrice = price,
                bookQuantity = quantity
            };

            booksList.Add(b);

            Console.WriteLine("Book added successfully!");
        }


        static void viewBooks(List<Book> booksList)
        {
            if (booksList.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            Console.WriteLine("\nAvailable Books:");
            foreach (var book in booksList)
            {
                Console.WriteLine($"Name: {book.bookName}, Author: {book.authorName}, Price: {book.bookPrice}, Quantity: {book.bookQuantity}");
            }
        }

        static void viewReport(List<report> reportList)
        {
            if (reportList.Count == 0)
            {
                Console.WriteLine("No report available.");
                return;
            }

            Console.WriteLine("\nSales report");
            foreach (var report in reportList)
            {
                Console.WriteLine($"Name: {report.bookName}, Customer: {report.customerName},  Quantity: {report.quantity}");
            }
        }
    }
}
