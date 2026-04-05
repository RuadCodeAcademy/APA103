using _10_GenericTypesCollections.Models;

namespace _10_GenericTypesCollections
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Book book1 = new(1, "martin Eden", "Jack London", 1909, 400);
            Book book2 = new(2, "1984", "George Orwel", 1949, 328);
            Book book3 = new(3, "animal Farm", "George Orwel", 1945, 112);
            Book book4 = new(4, "ag gemi", "Cingiz Aytmatov", 1970, 200);
            Book book5 = new(5, "Qiriq budaq", "Elçin", 1998, 350);

            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
            book4.DisplayInfo();
            book5.DisplayInfo();

            Library<Book> books = new Library<Book>("Milli Kitabxana");

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);

            Console.WriteLine("Kitab sayi");

            Console.WriteLine(books.Count());

          

            var b1 = books.FindByIndex(0);

            Console.WriteLine($"{ b1.Id} - {b1.Title} - {b1.Author} - {b1.Year} - {b1.PageCount} ");

            var b2 = books.FindByIndex(2);

            Console.WriteLine($"{b2.Id} - {b2.Title} - {b2.Author} - {b2.Year} - {b2.PageCount} ");

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();


            foreach (var book in books.GetAll())
            {
                book.DisplayInfo();
            }


            List<Member> members = new List<Member>();

            Member membetr1 = new(1, "Ali Memmedov", "ali@mail.com");
            Member membetr2 = new(2, "Leyla Hesenova", "leyla@mail.com");
            Member membetr3 = new(3, "Vuqar Aliyev", "vugar@mail.com");

            members.Add(membetr1);
            members.Add(membetr2);
            members.Add(membetr3);

            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            Console.WriteLine(" 2 kitab goturdu");

            Console.WriteLine();

            membetr1.BorrowBook(book1);
            membetr1.BorrowBook(book2);

            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            Console.WriteLine("borc kitablar");

            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            membetr1.DisplayBorrowedBooks();

            Console.WriteLine("  1 kitab qaytarsin");

            membetr1.ReturnBook(1);

            Console.WriteLine("borc kitablar");

            membetr1.DisplayBorrowedBooks();

            Console.WriteLine("3 kitab gotursun");

            membetr1.BorrowBook(book3);
            membetr1.BorrowBook(book4);
            membetr1.BorrowBook(book5);
            membetr1.BorrowBook(book1);
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            BookManager bookManager = new BookManager();

            Console.WriteLine();
            Console.WriteLine("5 kitab elave et");
            Console.WriteLine();

            bookManager.AddBook(book1);
            bookManager.AddBook(book2);
            bookManager.AddBook(book3);
            bookManager.AddBook(book4); 
            bookManager.AddBook(book5);

            Console.WriteLine();
            Console.WriteLine("George Orwell lin kitablari");
            Console.WriteLine();

            List<Book> george =  bookManager.GetBooksByAuthor("George Orwel");

            foreach (Book book in george)
            {
                book.DisplayInfo();

              
            }
           

            Console.WriteLine();
            Console.WriteLine("Cingiz Aytmatov n kitablari");
            Console.WriteLine();

           List<Book> cingiz = bookManager.GetBooksByAuthor("Cingiz Aytmatov");


            foreach (Book book in cingiz)
            {
                book.DisplayInfo();
                
                
            }

            Console.WriteLine();
            Console.WriteLine("Jack London  un kitablari");
            Console.WriteLine();

            List<Book> Jack = bookManager.GetBooksByAuthor("Jack London");

            foreach(Book book in Jack)
            {
                book.DisplayInfo();
            }

            Console.WriteLine();
            Console.WriteLine("Dostoyevski nin kitablari");
            Console.WriteLine();

            List<Book> basqa = bookManager.GetBooksByAuthor("Dostoyevski");

            foreach (Book book in basqa)
            {
                book.DisplayInfo();
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine("novbeye 3 neferi elave et");


            bookManager.AddToWaitingQueue("Nigar" );
            bookManager.AddToWaitingQueue("Resad");
            bookManager.AddToWaitingQueue("Sebine");


            Console.WriteLine();
            Console.WriteLine("novbedeki adam sayi");
            Console.WriteLine();


            int novbesayi = bookManager.WaitingQueue.Count();

            Console.WriteLine($"Novbede {novbesayi} adam var" ) ;

            

            string xidmet = bookManager.ServeNextInQueue();

            Console.WriteLine();

            Console.WriteLine($"Xidmet edilir:{xidmet}");

            Console.WriteLine();

            int novbesayi1 = bookManager.WaitingQueue.Count();

            Console.WriteLine($"Novbede {novbesayi1} adam var");

            Console.WriteLine();

            string xidmet1 = bookManager.ServeNextInQueue();

            Console.WriteLine($"Xidmet edilir:{xidmet1}");

            Console.WriteLine();

            int novbesayi2 = bookManager.WaitingQueue.Count();

            Console.WriteLine($"Novbede {novbesayi2} adam var");

            Console.WriteLine();

            string xidmet2 = bookManager.ServeNextInQueue();

            Console.WriteLine($"Xidmet edilir:{xidmet2}");

            Console.WriteLine();

            int novbesayi3 = bookManager.WaitingQueue.Count();

            Console.WriteLine($"Novbede {novbesayi3} adam var");


            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine("3 kitabı stack-ə əlavə edin");
            Console.WriteLine();

            bookManager.ReturnBook(book1);
            bookManager.ReturnBook(book2);
            bookManager.ReturnBook(book3);

            Console.WriteLine();

            int kitab = bookManager.RecentlyReturned.Count();

            Console.WriteLine($"stackda {kitab} kitab  var");


             Book last =  bookManager.GetLastReturnedBook();

            if ( last != null)
            {
                last.DisplayInfo();
            }


            bookManager.RecentlyReturned.Pop();
           int kitab1 =  bookManager.RecentlyReturned.Count();
            Console.WriteLine($"stackda {kitab1} kitab  var");

            Book last1 = bookManager.GetLastReturnedBook();

            if (last1 != null)
            {
                last1.DisplayInfo();    
               
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Axtarış testi:");
            Console.WriteLine();

            Book find1 = bookManager.SearchByTitle("1984");

            if (find1 != null)
            {
                find1.DisplayInfo();
            }

            Book find2 = bookManager.SearchByTitle("Harry Potter");

            if (find2 != null)
            {
                find2.DisplayInfo();

               
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("hec bir kitab yoxdur");
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            Console.WriteLine($"Ümumi kitab sayı: {books.Count()}");
            Console.WriteLine($"Ümumi üzv sayı:{members.Count()}");
            Console.WriteLine($"Növbədə nəfər sayı: {bookManager.WaitingQueue.Count()}");
            Console.WriteLine($"Stack-da kitab sayı:{bookManager.RecentlyReturned.Count()}");

            Console.WriteLine();

           
           

            int min = 1998;

            foreach( var book in bookManager.Books)
            {
                if(book.Year < min)
                {
                    min = book.Year;
                }
            }
            Console.WriteLine($"En köhne kitabın ili: {min}");


            Console.WriteLine();

            int max = 1909;


            foreach (var book in bookManager.Books)
            {
                if (book.Year > max)
                {
                    max = book.Year;
                }

            }
            Console.WriteLine($"en yeni kitabin ili: {max}");






















        }
    }
}
