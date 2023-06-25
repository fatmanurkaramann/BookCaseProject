using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCaseProject
{
    public class Book
    {
        public enum BookType
        {
            Turk=1,
            Yabancı
        }
        private string bookName;
        private string author;
        private int price;
        private BookType bookType;

        public string BookName { get => bookName; set => bookName = value; }
        public string Author { get => author; set => author = value; }
        public int Price { get => price; set => price = value; }
        public BookType BookType1 { get => bookType; set => bookType = value; }

        public Book() { }
        public Book(string bookName, string author, int price, BookType bookType)
        {
            BookName = bookName;
            Author = author;
            Price = price;
            BookType1 = bookType;
        }
    }
}
