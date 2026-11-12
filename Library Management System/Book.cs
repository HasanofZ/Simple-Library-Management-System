using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    public class Book
    {
        public int Id { get;private set;}
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool IsAvailable { get; private set; } = true;
    
    public Book(int id,string title,string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"Book {Title} borrowed successfully.");
            }
            else
            {
                Console.WriteLine($"Book {Title} is not available for borrowing now.");
            }
        }
        public void ReturnBook()
        {
            IsAvailable = true;
            Console.WriteLine($"Book {Title} returned successfully.");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Book ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Not Available")}");
        }

    }
}
