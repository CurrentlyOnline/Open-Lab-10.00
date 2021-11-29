using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Title = "Lord of the rings";
            LOTR.Pages = 304;
            LOTR.Category = "Fantasy";
            LOTR.Author = "Tolkien";
            LOTR.ReleaseDate = 2002;
            LOTR.returning();
        }
    }
    class Book
    {
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
            get
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
                    

    

