using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HLNews.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string author { get; set; }
        public DateTime publishedAt { get; set; }
    }
}
