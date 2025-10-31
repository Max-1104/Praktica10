using System;

// Zadanie 1

namespace PR10
{
    class Book
    {
        private string title;
        private int pages;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Pages
        {
            get { return pages; }
            set
            {
                if (value >= 1 && value <= 5000)
                {
                    pages = value;
                }

                else
                {
                    Console.WriteLine("Страниц должно быть от 1 до 5000!");

                    if (value > 5000)
                    {
                        pages = 5000;
                    }

                    else
                    {
                        pages = 1;
                    }

                }
            }
        }

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }

        public Book(string title) : this(title, 100)
        {
        }

        public Book() : this("Без названия", 1)
        {
        }

        public void Read()
        {
            Console.WriteLine($"Читаю книгу \"{title}\", страниц: {pages}.");
        }
    }
            class Program
            {
               static void Main(string[] args)
               {
                  Book book1 = new Book("Архипилаг ГУЛАГ", 1472);
                  Book book2 = new Book("Погребённый великан");
                  Book book3 = new Book();

                   book1.Read();
                   book2.Read();
                   book3.Read();

                   book1.Pages = 0;
                   book1.Read();

                   Console.ReadLine();
               }
            }
        
}

