using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> list = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");

                Article myArticle = new Article(tokens[0], tokens[1], tokens[2]);
                list.Add(myArticle);

            }
            string criteria = Console.ReadLine();
            List<Article> sortedArticle = new List<Article>();
            if (criteria == "title")
            {
                sortedArticle = list.OrderBy(x => x.Title).ToList();
            }
            else if (criteria == "author")
            {
                sortedArticle = list.OrderBy(x => x.Author).ToList();
            }
            else
            {
                sortedArticle = list.OrderBy(x => x.Content).ToList();
            }

            sortedArticle.ForEach(x =>Console.WriteLine(x));
        }

        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }
            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }
    }
}
