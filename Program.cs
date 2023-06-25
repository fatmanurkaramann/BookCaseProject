using BookCaseProject;

internal class Program
{
    private static void Main(string[] args)
    {
        int totalAmount = 0;
        BookManager bookManager = new BookManager();
        Console.WriteLine("**********************************");
        Console.WriteLine("****Türkçe kitaplar**************Yabancı kitaplar");

        while (true)
        {
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1. Fiyat Sorgu");
            Console.WriteLine("2. Yeni okur kaydı");
            Console.WriteLine("3. Kitap Listele");
            Console.WriteLine("4. Yeni kitap al");
            Console.WriteLine("5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
              case 1:
                    bookManager.inquaryPrice();
                    break;

             case 2:
                    bookManager.newUser();
                    break;
          
             case 3:
                    bookManager.bookList();
                    break;
             case 4:
                    bookManager.buyBook(ref totalAmount);
                    break;
                case 5:
                    return;
            }
        }

    }
}