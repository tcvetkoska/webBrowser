namespace WebBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnNewTab = new System.Windows.Forms.Button();
            this.btnClearBookmarks = new System.Windows.Forms.Button();
            this.btnShowBookmarks = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.btnShowHistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHomePage = new System.Windows.Forms.TextBox();
            this.btnSetHomePage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnForward = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveTab = new System.Windows.Forms.ToolStripButton();
            this.btnAddTab = new System.Windows.Forms.ToolStripButton();
            this.btnGo = new System.Windows.Forms.ToolStripButton();
            this.btnBookmakrs = new System.Windows.Forms.ToolStripButton();
            this.txtAdress = new System.Windows.Forms.ToolStripComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1060, 522);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.btnNewTab);
            this.tabPage1.Controls.Add(this.btnClearBookmarks);
            this.tabPage1.Controls.Add(this.btnShowBookmarks);
            this.tabPage1.Controls.Add(this.btnClearHistory);
            this.tabPage1.Controls.Add(this.btnShowHistory);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtHomePage);
            this.tabPage1.Controls.Add(this.btnSetHomePage);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1052, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Incognito?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnNewTab
            // 
            this.btnNewTab.Location = new System.Drawing.Point(641, 85);
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(75, 23);
            this.btnNewTab.TabIndex = 7;
            this.btnNewTab.Text = "Open New Tab";
            this.btnNewTab.UseVisualStyleBackColor = true;
            this.btnNewTab.Click += new System.EventHandler(this.btnAddTab_Click);
            // 
            // btnClearBookmarks
            // 
            this.btnClearBookmarks.Location = new System.Drawing.Point(477, 85);
            this.btnClearBookmarks.Name = "btnClearBookmarks";
            this.btnClearBookmarks.Size = new System.Drawing.Size(101, 23);
            this.btnClearBookmarks.TabIndex = 6;
            this.btnClearBookmarks.Text = "Clear Bookmarks";
            this.btnClearBookmarks.UseVisualStyleBackColor = true;
            this.btnClearBookmarks.Click += new System.EventHandler(this.btnClearBookmarks_Click);
            // 
            // btnShowBookmarks
            // 
            this.btnShowBookmarks.Location = new System.Drawing.Point(310, 85);
            this.btnShowBookmarks.Name = "btnShowBookmarks";
            this.btnShowBookmarks.Size = new System.Drawing.Size(104, 23);
            this.btnShowBookmarks.TabIndex = 5;
            this.btnShowBookmarks.Text = "Show Bookmarks";
            this.btnShowBookmarks.UseVisualStyleBackColor = true;
            this.btnShowBookmarks.Click += new System.EventHandler(this.btnShowBookmarks_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(172, 85);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(75, 23);
            this.btnClearHistory.TabIndex = 4;
            this.btnClearHistory.Text = "Delete History";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // btnShowHistory
            // 
            this.btnShowHistory.Location = new System.Drawing.Point(27, 85);
            this.btnShowHistory.Name = "btnShowHistory";
            this.btnShowHistory.Size = new System.Drawing.Size(82, 23);
            this.btnShowHistory.TabIndex = 3;
            this.btnShowHistory.Text = "Show History";
            this.btnShowHistory.UseVisualStyleBackColor = true;
            this.btnShowHistory.Click += new System.EventHandler(this.btnShowHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Home Page:";
            // 
            // txtHomePage
            // 
            this.txtHomePage.Location = new System.Drawing.Point(96, 29);
            this.txtHomePage.Name = "txtHomePage";
            this.txtHomePage.Size = new System.Drawing.Size(520, 20);
            this.txtHomePage.TabIndex = 1;
            this.txtHomePage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHomePage_KeyDown);
            // 
            // btnSetHomePage
            // 
            this.btnSetHomePage.Location = new System.Drawing.Point(627, 27);
            this.btnSetHomePage.Name = "btnSetHomePage";
            this.btnSetHomePage.Size = new System.Drawing.Size(94, 23);
            this.btnSetHomePage.TabIndex = 0;
            this.btnSetHomePage.Text = "Set Home Page";
            this.btnSetHomePage.UseVisualStyleBackColor = true;
            this.btnSetHomePage.Click += new System.EventHandler(this.btnSetHomePage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 44);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnForward,
            this.btnRefresh,
            this.btnHome,
            this.btnSettings,
            this.btnRemoveTab,
            this.btnAddTab,
            this.btnGo,
            this.btnBookmakrs,
            this.txtAdress});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1060, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 34);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.AutoSize = false;
            this.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(34, 34);
            this.btnForward.Text = "Forward";
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 34);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = false;
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(34, 34);
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSettings.AutoSize = false;
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(34, 34);
            this.btnSettings.Text = "Setings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRemoveTab
            // 
            this.btnRemoveTab.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRemoveTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveTab.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveTab.Image")));
            this.btnRemoveTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveTab.Name = "btnRemoveTab";
            this.btnRemoveTab.Size = new System.Drawing.Size(34, 34);
            this.btnRemoveTab.Text = "Delete tab";
            this.btnRemoveTab.Click += new System.EventHandler(this.btnRemoveTab_Click);
            // 
            // btnAddTab
            // 
            this.btnAddTab.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAddTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddTab.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTab.Image")));
            this.btnAddTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(34, 34);
            this.btnAddTab.Text = "Add new tab";
            this.btnAddTab.Click += new System.EventHandler(this.btnAddTab_Click);
            // 
            // btnGo
            // 
            this.btnGo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnGo.AutoSize = false;
            this.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(34, 34);
            this.btnGo.Text = "Search";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnBookmakrs
            // 
            this.btnBookmakrs.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnBookmakrs.AutoSize = false;
            this.btnBookmakrs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBookmakrs.Image = ((System.Drawing.Image)(resources.GetObject("btnBookmakrs.Image")));
            this.btnBookmakrs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBookmakrs.Name = "btnBookmakrs";
            this.btnBookmakrs.Size = new System.Drawing.Size(34, 34);
            this.btnBookmakrs.Text = "Bookmark";
            this.btnBookmakrs.Click += new System.EventHandler(this.btnBookmakrs_Click);
            // 
            // txtAdress
            // 
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(121, 37);
            this.txtAdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdress_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 522);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Controls.Add(this.lbStatus);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 566);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1060, 30);
            this.panel4.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.progressBar1.Location = new System.Drawing.Point(841, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(219, 30);
            this.progressBar1.TabIndex = 9;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(12, 8);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1076, 635);
            this.Name = "Form1";
            this.Text = "Web Browser";
            this.MaximizedBoundsChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.MaximumSizeChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.MinimumSizeChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.SizeChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.Resize += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnForward;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripButton btnGo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripButton btnBookmakrs;
        private System.Windows.Forms.ToolStripButton btnRemoveTab;
        private System.Windows.Forms.ToolStripButton btnAddTab;
        private System.Windows.Forms.ToolStripComboBox txtAdress;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHomePage;
        private System.Windows.Forms.Button btnSetHomePage;
        private System.Windows.Forms.Button btnNewTab;
        private System.Windows.Forms.Button btnClearBookmarks;
        private System.Windows.Forms.Button btnShowBookmarks;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Button btnShowHistory;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}

