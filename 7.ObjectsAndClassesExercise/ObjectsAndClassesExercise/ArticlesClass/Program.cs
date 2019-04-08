using System;
using System.Collections.Generic;

namespace ArticlesClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            int count = int.Parse(Console.ReadLine());

            var article = new Article(inputArr[0], inputArr[1], inputArr[2]);
            

            for (int i = 0; i < count; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Edit")
                {
                    article.Edit(tokens[1]);
                }
                
                else if (tokens[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(tokens[1]);
                }

                else if (tokens[0] == "Rename")
                {
                    article.Rename(tokens[1]);
                }

                //else if (tokens[0] == "ToString")
                //{
                //    Console.WriteLine(article);
                //}
                
            }

            article.Print();

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
}
