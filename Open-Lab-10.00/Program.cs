using System;
using System.Collections.Generic;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            Book LOTR2 = new Book();
            Book LOTR3 = new Book();
            Book HOBIT = new Book();

            LOTR.Title = "Lord of the rings";
            LOTR.Pages = 304;
            LOTR.Category = "Fantasy";
            LOTR.Author = "Tolkien";
            LOTR.ReleaseDate = 2002;
            LOTR.returning();
            Console.WriteLine();

            LOTR2.returning();
            Console.WriteLine();

            LOTR3.Title = "Lord of the rings 3";
            LOTR3.Pages = 360;
            LOTR3.returning();
            Console.WriteLine();

            HOBIT.Title = "Hobit";
            HOBIT.Pages = 255;
            HOBIT.Category = Book.categoryList[4];
            HOBIT.Author = "Tolkien";
            HOBIT.ReleaseDate = 2004;
            HOBIT.returning();


        }
    }
    class Book
    {   
        /// <summary>
        /// string list of categories
        /// </summary>
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

        public void returning()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Pages);
            Console.WriteLine(Category);
            Console.WriteLine(Author);
            Console.WriteLine(ReleaseDate);
        }
        
    }
}
                    

    

