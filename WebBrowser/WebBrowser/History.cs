using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    public class History
    {
        public String Title { get; set; }
        public String Url { get; set; }
        public String Time { get; set; }

        public History(String Title, String Url)
        {
            this.Title = Title;
            this.Url = Url;
            this.Time = String.Format("{0}:{1}",System.DateTime.Now.Hour.ToString(), System.DateTime.Now.Minute.ToString());
        }

        public override string ToString()
        {
            return String.Format("Title: {0}, URL: {1}, Time: {2}", Title, Url, Time);
        }
    }
}
