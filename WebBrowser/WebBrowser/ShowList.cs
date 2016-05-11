using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class ShowList : Form
    {
        private List<Bookmark> bookmarks;

  

        public ShowList(List<Bookmark> bookmarks)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.bookmarks = bookmarks;
            foreach (Bookmark bookmark in bookmarks)
            {
                listBox1.Items.Add(bookmark);
            }
        }

        private void ShowList_Load(object sender, EventArgs e)
        {

        }
    }
}
