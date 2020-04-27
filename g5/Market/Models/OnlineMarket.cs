using System;
using System.Collections.Generic;

namespace Models
{
    public class OnlineMarket
    {
        public string Name { get; set; }
        public List<Article> Articles { get; set; }

        public OnlineMarket(string name)
        {
            Name = name;
            Articles = new List<Article>();
        }

        public void AddArticle(Article article)
        {
            foreach (var art in Articles)
            {
                if (article.Name == art.Name)
                    return;
            }

            Articles.Add(article);
        }

        public string GetAvailableArticles()
        {
            string info = "Articles: \n";
            for (int i = 0; i < Articles.Count; i++)
            {
                info += $"{i + 1}. {Articles[i].Name} x {Articles[i].Stock}\n";
            }

            return info;
        }
    }
}
