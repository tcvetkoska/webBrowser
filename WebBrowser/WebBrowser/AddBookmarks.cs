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
    public partial class AddBookmarks : Form
    {
        public Bookmark bookmark { get; set; }
        public AddBookmarks()
        {
            InitializeComponent();
        }

        public AddBookmarks(string Url)
        {
            InitializeComponent();
            txtUrl.Text = Url.ToString();
            txtTitle.Focus();
        }

        private void AddBookmarks_Load(object sender, EventArgs e)
        {
            txtTitle.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bookmark = new Bookmark(txtUrl.Text, txtTitle.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void txtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }
    }
}
