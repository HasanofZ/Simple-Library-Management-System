using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
namespace Library_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Library myLibrary = new Library();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine(" ----------------Library Management System --------------");
                Console.WriteLine("1. Add New Book ");
                Console.WriteLine("2. Rigester New Member ");
                Console.WriteLine("3. Show All Books ");
                Console.WriteLine("4. Show All Members ");
                Console.WriteLine("5. Borrow A Book ");
                Console.WriteLine("6. Return A Book ");
                Console.WriteLine("7. Exit ");
                Console.WriteLine(" /nChoose A Number Of [1-7]/n");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    // case 1 //-------------------------------------------------------------------------------------
                    case "1":
                        Console.WriteLine(" Enter Book ID :");
                        int bookId = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Enter Book Title :");
                        string title = Console.ReadLine();
                        Console.WriteLine(" Enter The Name Of Author :");
                        string author = Console.ReadLine();

                        Book book = new Book(bookId, title, author);
                        myLibrary.AddBook(book);
                        break;
                        //case 2//-------------------------------------------------------------------------------------

                    case "2":
                        Console.WriteLine(" Enter Member Id : ");
                        int memberId = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Enter Member Name : ");
                        string name = Console.ReadLine();
                        Member newMember = new Member(memberId, name);
                        myLibrary.RegisterMember(newMember);
                        break;
                    //case 3//-------------------------------------------------------------------------------------
                    case "3":
                        myLibrary.DisplayBooks();
                        break;
                    //case 4//-------------------------------------------------------------------------------------
                    case "4":
                        myLibrary.DisplayMembers();
                        break;
                    //case 5//-------------------------------------------------------------------------------------
                    case "5":
                        Console.WriteLine(" Enter Member Id : ");
                        int borrowMemberId = int.Parse(Console.ReadLine());
                        Member borrowMember = myLibrary.FindMemberById(borrowMemberId);
                        if (borrowMember != null)
                        {
                            Console.WriteLine("Enter The BookId You Want To Borrow: ");
                            int targetBookId = int.Parse(Console.ReadLine());
                            Book bookToBorrow = myLibrary.FindBookById(targetBookId);
                            if (bookToBorrow != null)
                            {
                                borrowMember.BorrowBook(bookToBorrow);

                            }
                            else
                            {
                                Console.WriteLine($"Book with ID {targetBookId} not found.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Member with ID {borrowMemberId} not found.");
                        }
                        break;
                    //case 6//-------------------------------------------------------------------------------------
                    case "6":
                            Console.Write("Enter MemberId Who Wants to Return a Book: ");
                            int returningMemberId = int.Parse(Console.ReadLine());
                            Member returner = myLibrary.FindMemberById(returningMemberId);

                            if (returner != null)
                            {
                                Console.Write(" Enter BookId You Want to Return: ");
                                int targetBookId = int.Parse(Console.ReadLine());
                                Book bookToReturn = returner.BorrowBooks.Find(b => b.Id == targetBookId);

                                if (bookToReturn != null)
                                {
                                    returner.ReturnBook(bookToReturn);
                                }
                                else
                                {
                                    Console.WriteLine("This Member Does Not Have This Book Borrowed!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Member not found!");
                            }
                            break;
                    //case 7//-------------------------------------------------------------------------------------
                    case "7":
                            exit = true;
                            Console.WriteLine("Thank you for using the Library Management System!");
                            break;

                        default:
                            Console.WriteLine("Incorrect Choice, You Must Choose a Valid Option!");
                            break;
                    }                   



                }
            } 
        }
    }
    




 