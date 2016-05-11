using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    public class Bookmark
    {
        public String Url { get; set; }
        public String Title { get; set; }

        public Bookmark (String Url, String Title)
        {
            this.Url = Url;
            this.Title = Title;
        }

        public override string ToString()
        {
            return String.Format("Title: {0}, URL: {1}",Title,Url);
        }
    }
}
