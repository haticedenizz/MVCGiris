using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _28._022022_MVCGiris.Library
{
    public static class MyExtensions
    {
       public static MvcHtmlString Button(this HtmlHelper helper, string id,ButtonTip tip , string text)
        {
            string buton = string.Format
             ("<button id='{0}' name='{0}' type='{1}'>{2}</button>",id,tip.ToString(),text);
            return MvcHtmlString.Create(buton);
        }

        public enum ButtonTip
        {
            button=0,
            summit=1,
            reset=2
        }
    }
}