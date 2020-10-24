using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HLNews.Helpers
{
    public static class ExternalLinkHelper
    {
       
            public static string ExternalLink(this HtmlHelper helper, string url, string text)
            {
                return String.Format("<a href='http://{0}' target='_blank'>{1}</a>", url, text);
            }
        }
    
}
