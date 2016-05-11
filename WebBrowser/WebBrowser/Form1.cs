using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public System.Windows.Forms.WebBrowser web = new System.Windows.Forms.WebBrowser();
        int i = 0;
        public String Home = "http://google.com";
        AddBookmarks AddBookmark = new AddBookmarks();
        List<Bookmark> bookmarks = new List<Bookmark>();
        ShowList showList { get; set; }
        ShowHistory showHistory { get; set; }
        History History { get; set; }
        List<History> historyList = new List<History>();
        TabPage settings = new TabPage();
        bool incognito = false;

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((System.Windows.Forms.WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            ((System.Windows.Forms.WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!tabControl1.SelectedTab.Equals(settings))
            ((System.Windows.Forms.WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Equals(settings))
            {
                tabControl1.TabPages.Remove(settings);
                i--;
                
                DodadiNovTab(Home);
            }
            else
                ((System.Windows.Forms.WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Home);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Equals(settings))
            {
                tabControl1.TabPages.Remove(settings);
                i--;
                DodadiNovTab(txtAdress.Text);
            }
            else
                ((System.Windows.Forms.WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(txtAdress.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStrip1.ImageScalingSize = new Size(30, 30);
            txtAdress.Size = new Size(btnBookmakrs.Bounds.Left - 5 - btnHome.Bounds.Right, 40);
            tabControl1.SelectedTab.Text = "Settings";
            settings = tabControl1.SelectedTab;
            tabControl1.TabPages.Remove(settings);
            //i--;
            DodadiNovTab(Home);
        }
        void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            btnRefresh.Enabled = true;
            btnHome.Enabled = true;
            btnBack.Enabled = true;
            btnGo.Enabled = true;
            btnForward.Enabled = true;
            btnAddTab.Enabled = true;
            txtAdress.Text = ((System.Windows.Forms.WebBrowser)tabControl1.SelectedTab.Controls[0]).Url.ToString();
            
            String Url =  e.Url.ToString().Substring(0,NthOccurence(e.Url.ToString(),'/'));
            String last = txtAdress.Text;
            //MessageBox.Show(Url);
            History = new History(((System.Windows.Forms.WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle, txtAdress.Text);
            lbStatus.Text = String.Format("Done. Navigated to URL: {0}",txtAdress.Text);

            if (!incognito)
            {
                if (historyList.Count == 0)
                {
                    historyList.Add(History);
                }
                else if (!historyList[historyList.Count - 1].Url.Equals(last))
                {
                    historyList.Add(History);
                }
            }
            tabControl1.SelectedTab.Text = web.DocumentTitle;
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
            txtAdress.Size = new Size(btnBookmakrs.Bounds.Left - 5 - btnHome.Bounds.Right, 40);
        }

        

        private void txtAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (tabControl1.SelectedTab.Equals(settings))
                {
                    tabControl1.TabPages.Remove(settings);
                    i--;
                    DodadiNovTab(txtAdress.Text);
                }
                else
                    ((System.Windows.Forms.WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(txtAdress.Text.ToString());
            }
        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            DodadiNovTab(Home);
        }

        private void btnRemoveTab_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count - 1 > 0)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i--;
            }
        }

        

        private void btnBookmakrs_Click(object sender, EventArgs e)
        {
            AddBookmark = new AddBookmarks(((System.Windows.Forms.WebBrowser)tabControl1.SelectedTab.Controls[0]).Url.ToString());
            AddBookmark.ShowDialog();
            if (AddBookmark.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                bookmarks.Add(AddBookmark.bookmark);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(settings))
            {
                tabControl1.TabPages.Add(settings);
                tabControl1.SelectTab(settings);
                txtHomePage.Text = Home;
                i++;
                txtAdress.Text = "Settings";
                lbStatus.Text = "Settings!";
            }
            else
                tabControl1.SelectTab(settings);

        }
        int NthOccurence(string s, char c)
        {

            int r = 1;
            if (s.IndexOf(c, 8) > 0)
                r = s.IndexOf(c, 8);
            return r;
        }

        private void btnSetHomePage_Click(object sender, EventArgs e)
        {
            Home = txtHomePage.Text;
            if (!Home.Substring(0,3).Equals("http")) {
                Home = String.Format("http://{0}",Home);
            }
            MessageBox.Show(String.Format("The Homepage is set to: {0}",Home));
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            showHistory = new ShowHistory(historyList);
            showHistory.ShowDialog();
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            historyList.Clear();
        }

        private void btnShowBookmarks_Click(object sender, EventArgs e)
        {
            showList = new ShowList(bookmarks);
            showList.ShowDialog();
        }

        private void btnClearBookmarks_Click(object sender, EventArgs e)
        {
            bookmarks.Clear();
        }

        private void DodadiNovTab(String Url)
        {
            web = new System.Windows.Forms.WebBrowser();
            web.DocumentCompleted += web_DocumentCompleted;
            web.Navigating += web_Navigating;
            web.ProgressChanged += web_ProgressChanged;
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            tabControl1.TabPages.Add("New Tab");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i++;
            ((System.Windows.Forms.WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(Url);
        }

        void web_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int) e.MaximumProgress;
            if (e.CurrentProgress > 0 && e.CurrentProgress <= 100)
                progressBar1.Value = (int) e.CurrentProgress;
        }

        void web_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            lbStatus.Text = "Navigating...";
            btnRefresh.Enabled = false;
            btnHome.Enabled = false;
            btnBack.Enabled = false;
            btnForward.Enabled = false;
            btnGo.Enabled = false;
            btnAddTab.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                incognito = true;
                tabControl1.TabPages.Clear();
                i = 0;
                DodadiNovTab(Home);
            }
            else
            {
                incognito = false;
                tabControl1.TabPages.Clear();
                i = 0;
                DodadiNovTab(Home);
            }
        }

        private void txtHomePage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSetHomePage_Click(sender, e);
            }
        }
    }
}
