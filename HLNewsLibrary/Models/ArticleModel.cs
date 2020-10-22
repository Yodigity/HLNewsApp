using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HLNews.Models
{
    public class ArticleModel
    {
        public string sourceId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string imageURL { get; set; }
        public string author { get; set; }
        public DateTime publishedAt { get; set; }
    }
}
