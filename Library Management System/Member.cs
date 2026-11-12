using System;
using System.Collections.Generic; 
using System.Text;

namespace Library_Management_System
{
    public class Member
    {
        public int MemberId { get; private set; }
        public string Name { get; private set; }
        public List<Book> BorrowBooks { get; private set; }

        public Member(int memberId,string name) {
            MemberId = memberId;
            Name = name;
            BorrowBooks = new List<Book>(); 
        }

        public void BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                book.Borrow();
                BorrowBooks.Add(book);
                Console.WriteLine($"Book {book.Title} borrowed by {Name}.");
            }
            else
            {
                Console.WriteLine($"Sorry, Book {book.Title} is UnAvailable Now");
            }
        }
        public void ReturnBook(Book book)
        {
            if(BorrowBooks.Contains(book))
            {
                book.ReturnBook();
                BorrowBooks.Remove(book);
                Console.WriteLine($"Book {book.Title} returned by {Name}.");
            }
            else
            {
                Console.WriteLine($"Book {book.Title} is not borrowed by {Name}.");
            }
        }
        public void DisplayMemberInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Borrowed Books:");
            foreach (var book in BorrowBooks)
            {
                Console.WriteLine($" - {book.Title} by {book.Author}");
            }
        }
    }
}

        
    

