using System;
using System.Collections.Generic;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book("Lord of the rings", 304, "Fantasy", "Tolkien", 2002);
            Book LOTR2 = new Book();
            Book LOTR3 = new Book("Lord of the rings 3", 360);
            Book HOBIT = new Book("Hobit", 255, Book.categoryList[4], "Tolkien", 2004);
            Console.WriteLine(LOTR);



        }
    }
    class Book
    {

        public static List<string> categoryList = new List<string>
        {
            "detské", "romantické", "náučné", "sci-fi", "dobrodružné"
        };



        public Book()
        {
            Title = "-1";
            Pages = -1;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }
        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
            Category = "-1";
            Author = "-1";
            ReleaseDate = -1;
        }
        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            Title = title;
            Pages = pages;
            Category = category;
            Author = author;
            ReleaseDate = releaseDate;
        }


        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                if (value > 0)
                {
                    pages = value;
                }
                else
                {
                    pages = 1;
                }
            }
        }
        public string Category
        {
            private get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public int ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                if (value <= 2021 && value >= 1450)
                {
                    releaseDate = value;
                }
                else
                {
                    releaseDate = -1;
                }
            }
        }



        public override string ToString()
        {
            return Title + "\n" + Pages + "\n" + Category + "\n" + Author  + "\n" + releaseDate;

        }


        // Console.WriteLine(Title);
        // Console.WriteLine(Pages);
        // Console.WriteLine(Category);
        // Console.WriteLine(Author);
        // Console.WriteLine(ReleaseDate);
    }

}