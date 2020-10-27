using HLNews.Models;
using System.Collections.Generic;

namespace HLNewsLibrary.API
{
    public interface INewsEndpoint
    {
        List<ArticleModel> Get(string searchString = "Apple", string country = "us");
    }
}