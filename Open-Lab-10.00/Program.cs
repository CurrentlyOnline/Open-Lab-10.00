using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Title("Lord of the rings");
            LOTR.Author("Tolkien");
            LOTR.Category("Fantasy");
            LOTR.Pages(304);
            LOTR.RealeaseDate(2002);
            LOTR.returning();
        }
    }
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private double releaseDate;

        public void Title(string setTitle)
        {
           title = setTitle;
        }
        public void Pages(int setPages)
        {
            pages = setPages;
        }
        public void Category(string setCategory)
        {
           category = setCategory;
        }
        public void Author(string setAuthor)
        {
           author = setAuthor;
        }
        public void RealeaseDate(int setreleaseDate)
        {
            releaseDate = setreleaseDate;
        }

        public void returning()
        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
            Console.WriteLine(category);
            Console.WriteLine(author);
            Console.WriteLine(releaseDate);
        }
        
    }
}
                    

    

