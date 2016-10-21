using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Ares.Infrastructure.MvcExtensions
{
    public class MetaInfoAttribute:ActionFilterAttribute
    {
        public string Keywords { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public string Copyright { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //filterContext.Controller.ViewBag.Meta = Meta();
            filterContext.Controller.ViewBag.Keywords = Keywords;
            filterContext.Controller.ViewBag.Descption = Description;
            filterContext.Controller.ViewBag.Author = Author;
            filterContext.Controller.ViewBag.Copyright = Copyright;
        }

        private string Meta(string copyright, string keywords, string description, string author)
        {
            StringBuilder s = new StringBuilder();
            string MetaTemplate = @"<meta name = ""Copyright"" content=""#copyright#"" /> <meta name=""keywords"" content=""#keywords#"" /> <meta name=""description"" content=""#description#"" /> <meta name=""author"" content=""#author#"" />";
            return MetaTemplate
                .Replace("#copyright#", copyright)
                .Replace("#keywords#", keywords)
                .Replace("#description#", description)
                .Replace("#author#", author);
        }

        private string Meta()
        {
            string copyright = string.Empty;
            string keywords = string.Empty;
            string description = string.Empty;
            string author = string.Empty;
            return Meta(copyright, keywords, description, author);
        }
    }
}
