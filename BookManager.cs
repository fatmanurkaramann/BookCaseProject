using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseProject
{
    public class BookManager
    {
        List<User> User = new List<User>();
        List<Book> Books = new List<Book>();

        public BookManager()
        {
            Book book1 = new Book("Çalıkuşu", "Reşat Nuri Güntekin", 20,Book.BookType.Turk);
            Book book2 = new Book("Satranç", "Stefan Zweig", 25,Book.BookType.Yabancı);

            Books.Add(book1);
            Books.Add(book2);

        }
        public void newUser()
        {
            Console.WriteLine("İsim giriniz");
            string name=Console.ReadLine();
            Console.WriteLine("Soyisim giriniz");
            string lastname = Console.ReadLine();
            Console.WriteLine("Universite giriniz");
            string university = Console.ReadLine();
            User users = new(name, lastname, university);
            User.Add(users);
            Console.WriteLine("Kayıt olundu.");
        }
        public void bookList()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book.BookName+" / "+book.Author);

            }
        }
        public void inquaryPrice()
        {
            Console.WriteLine("Lütfen fiyatını öğrenmek istediğiniz kitabın adını girin");
            string name;
            name = Console.ReadLine();

            Book priceBook = Books.Find(p => p.BookName == name);
            Console.WriteLine(priceBook.Price+" TL");
        }
        public void buyBook(ref int total)
        {
                Console.WriteLine("Alacağınız kitabın adını girin");
                string name;
                name = Console.ReadLine();
                Book priceBook = Books.Find(p => p.BookName.ToUpper() == name.ToUpper());
                if (priceBook != null)
                {
                    total += priceBook.Price;
                    Console.WriteLine("Toplam tutar: " + total);
                }
                else
                {
                    Console.WriteLine("Kitap bulunamadı.");
                }

            while (true)
            {
                Console.WriteLine("Başka bir kitap almak ister misiniz? (E/H)");
                string choice = Console.ReadLine();
                if (choice.ToUpper() == "E")
                {
                    buyBook(ref total);
                    break;
                }
                else if (choice.ToUpper() == "H")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçenek. Lütfen 'E' veya 'H' girin.");
                }

            }


        }
    }
}
