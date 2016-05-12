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
    public partial class ShowHistory : Form
    {
        private List<History> historyList;

        public ShowHistory()
        {
            InitializeComponent();
        }

        public ShowHistory(List<History> historyList)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.historyList = historyList;
            foreach (History history in historyList)
            {
                listBox1.Items.Add(history);
            }
        }


    }
}
