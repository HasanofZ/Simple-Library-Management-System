using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Library_Management_System
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book {book.Title} added to the library.");
        }

        public void RegisterMember(Member member)
        {
            members.Add(member);
            Console.WriteLine($"Member {member.Name} registered successfully.");
        }

        public void DisplayBooks()
        {
            Console.WriteLine(" Books In The Library :");
            if (books.Count == 0)
                Console.WriteLine("No books available in the library.");
            else
            {
                foreach (var book in books)

                {
                    book.DisplayInfo();
                }


            }
        }
        public void DisplayMembers()
        {
            Console.WriteLine("Registered Members:");
            if (members.Count == 0)
                Console.WriteLine("No members registered in the library.");
            else
            {
                foreach (var member in members)
                {
                    member.DisplayMemberInfo();
                }
            }
        }
        public Book FindBookById(int bookId)
        {
            return books.Find(b => b.Id == bookId);
        }
        public Member FindMemberById(int memberId)
        {
            return members.Find(m =>m.MemberId == memberId);
        }
    }
}