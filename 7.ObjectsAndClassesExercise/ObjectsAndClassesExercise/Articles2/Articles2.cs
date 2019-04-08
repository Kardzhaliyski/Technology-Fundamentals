using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2
{
    class Articles2
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var articles = new List<Article>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string title = input[0];
                string content = input[1];
                string author = input[2];
                Article article = new Article(title,content,author);
                articles.Add(article);
            }

            string sortBy = Console.ReadLine();

            if (sortBy == "title")
            {
                articles = articles
                    .OrderBy(x => x.Title)
                    .ToList();
            }
            else if (sortBy == "content")
            {
                articles = articles
                    .OrderBy(x => x.Content)
                    .ToList();
            }
            else if (sortBy == "author")
            {
                articles = articles
                    .OrderBy(x => x.Author)
                    .ToList();
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }

        }
    }

    class Article
    {

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
