using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace _10_GenericTypesCollections.Models
{
    public class Member
    {
        

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        List<Book> BorrowedBooks { get; set; }
       

        public Member(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            BorrowedBooks = new List<Book>();

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Ad: {Name}, Email: {Email}");
        }

        public void BorrowBook(Book book)
        {
            if(BorrowedBooks.Count < 4)
            {

                BorrowedBooks.Add(book);
                Console.WriteLine($"Kitab goturuldu: {book.Title}");
                
            }
            else
            {
                Console.WriteLine("Maksimum 3 kitab götürə bilərsiniz!");
            }
        }

        public void ReturnBook(int  bookId)
        {

            bool found = false;

            foreach (Book book in BorrowedBooks)
            {
                if(book.Id == bookId)
                {
                    BorrowedBooks.Remove(book);
                    Console.WriteLine($"Kitab qaytarildi:[{book.Title}]");
                    found = true;
                    break;
                }

                
            }

            if (found == false)
            {
                Console.WriteLine($"id si {bookId}  olan kitab yoxdur.");
            }
        }

        public void DisplayBorrowedBooks()
        {
            if(BorrowedBooks.Count == 0)
            {
                Console.WriteLine("Borc Kitab yoxdur");
            }
            else
            {
                foreach (Book book in BorrowedBooks)
                {
                    Console.WriteLine(book.Title);
                }
            }


        }





    }
}
