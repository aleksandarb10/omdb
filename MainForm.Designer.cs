namespace OMDB_API
{
    partial class OMDb
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
            this.components = new System.ComponentModel.Container();
            this.Tab_Control = new System.Windows.Forms.TabControl();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.groupBoxDeatails = new System.Windows.Forms.GroupBox();
            this.labelMovieYear = new System.Windows.Forms.Label();
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.buttonMoreDetails = new System.Windows.Forms.Button();
            this.labelMoreDetails = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.labelPage = new System.Windows.Forms.Label();
            this.buttonPrevPage = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.listBoxSearchResults = new System.Windows.Forms.ListBox();
            this.contextMenuStripOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sORT1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sORT2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToFavoritesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabFavorites = new System.Windows.Forms.TabPage();
            this.listBoxFavorites = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressBarAddingMovies = new System.Windows.Forms.ProgressBar();
            this.buttonDownloadPoster = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.listBoxWatchedMovies = new System.Windows.Forms.ListBox();
            this.sORT1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sORT2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab_Control.SuspendLayout();
            this.tabMovies.SuspendLayout();
            this.groupBoxDeatails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            this.groupBoxResults.SuspendLayout();
            this.contextMenuStripOption.SuspendLayout();
            this.groupSearch.SuspendLayout();
            this.tabFavorites.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Control
            // 
            this.Tab_Control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Control.Controls.Add(this.tabMovies);
            this.Tab_Control.Controls.Add(this.tabFavorites);
            this.Tab_Control.Controls.Add(this.tabPage1);
            this.Tab_Control.Location = new System.Drawing.Point(0, 0);
            this.Tab_Control.Name = "Tab_Control";
            this.Tab_Control.SelectedIndex = 0;
            this.Tab_Control.Size = new System.Drawing.Size(656, 514);
            this.Tab_Control.TabIndex = 0;
            this.Tab_Control.SelectedIndexChanged += new System.EventHandler(this.tabControl1_Selecting);
            // 
            // tabMovies
            // 
            this.tabMovies.Controls.Add(this.groupBoxDeatails);
            this.tabMovies.Controls.Add(this.groupBoxResults);
            this.tabMovies.Controls.Add(this.groupSearch);
            this.tabMovies.Location = new System.Drawing.Point(4, 22);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovies.Size = new System.Drawing.Size(648, 488);
            this.tabMovies.TabIndex = 0;
            this.tabMovies.Text = "Movies";
            this.tabMovies.UseVisualStyleBackColor = true;
            // 
            // groupBoxDeatails
            // 
            this.groupBoxDeatails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDeatails.Controls.Add(this.labelMovieYear);
            this.groupBoxDeatails.Controls.Add(this.labelMovieTitle);
            this.groupBoxDeatails.Controls.Add(this.buttonMoreDetails);
            this.groupBoxDeatails.Controls.Add(this.labelMoreDetails);
            this.groupBoxDeatails.Controls.Add(this.labelYear);
            this.groupBoxDeatails.Controls.Add(this.labelTitle);
            this.groupBoxDeatails.Controls.Add(this.pictureBoxPoster);
            this.groupBoxDeatails.Location = new System.Drawing.Point(204, 68);
            this.groupBoxDeatails.Name = "groupBoxDeatails";
            this.groupBoxDeatails.Size = new System.Drawing.Size(426, 414);
            this.groupBoxDeatails.TabIndex = 2;
            this.groupBoxDeatails.TabStop = false;
            this.groupBoxDeatails.Text = "Deatails";
            // 
            // labelMovieYear
            // 
            this.labelMovieYear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMovieYear.AutoSize = true;
            this.labelMovieYear.Location = new System.Drawing.Point(104, 344);
            this.labelMovieYear.Name = "labelMovieYear";
            this.labelMovieYear.Size = new System.Drawing.Size(58, 13);
            this.labelMovieYear.TabIndex = 13;
            this.labelMovieYear.Text = "MovieYear";
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMovieTitle.AutoSize = true;
            this.labelMovieTitle.Location = new System.Drawing.Point(104, 315);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(56, 13);
            this.labelMovieTitle.TabIndex = 12;
            this.labelMovieTitle.Text = "MovieTitle";
            // 
            // buttonMoreDetails
            // 
            this.buttonMoreDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonMoreDetails.Enabled = false;
            this.buttonMoreDetails.Location = new System.Drawing.Point(142, 368);
            this.buttonMoreDetails.Name = "buttonMoreDetails";
            this.buttonMoreDetails.Size = new System.Drawing.Size(44, 23);
            this.buttonMoreDetails.TabIndex = 7;
            this.buttonMoreDetails.Text = "...";
            this.buttonMoreDetails.UseVisualStyleBackColor = true;
            this.buttonMoreDetails.Click += new System.EventHandler(this.buttonMoreDetails_Click);
            // 
            // labelMoreDetails
            // 
            this.labelMoreDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMoreDetails.AutoSize = true;
            this.labelMoreDetails.Location = new System.Drawing.Point(55, 373);
            this.labelMoreDetails.Name = "labelMoreDetails";
            this.labelMoreDetails.Size = new System.Drawing.Size(67, 13);
            this.labelMoreDetails.TabIndex = 6;
            this.labelMoreDetails.Text = "More datails:";
            // 
            // labelYear
            // 
            this.labelYear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(68, 344);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 13);
            this.labelYear.TabIndex = 5;
            this.labelYear.Text = "Year:";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(68, 315);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Title:";
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPoster.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(408, 282);
            this.pictureBoxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPoster.TabIndex = 3;
            this.pictureBoxPoster.TabStop = false;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResults.Controls.Add(this.labelPage);
            this.groupBoxResults.Controls.Add(this.buttonPrevPage);
            this.groupBoxResults.Controls.Add(this.buttonNextPage);
            this.groupBoxResults.Controls.Add(this.listBoxSearchResults);
            this.groupBoxResults.Location = new System.Drawing.Point(8, 68);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(190, 414);
            this.groupBoxResults.TabIndex = 1;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // labelPage
            // 
            this.labelPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPage.AutoSize = true;
            this.labelPage.Location = new System.Drawing.Point(82, 379);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(0, 13);
            this.labelPage.TabIndex = 14;
            // 
            // buttonPrevPage
            // 
            this.buttonPrevPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPrevPage.Enabled = false;
            this.buttonPrevPage.Location = new System.Drawing.Point(6, 374);
            this.buttonPrevPage.Name = "buttonPrevPage";
            this.buttonPrevPage.Size = new System.Drawing.Size(43, 23);
            this.buttonPrevPage.TabIndex = 11;
            this.buttonPrevPage.Text = "<<";
            this.buttonPrevPage.UseVisualStyleBackColor = true;
            this.buttonPrevPage.Click += new System.EventHandler(this.buttonPrevPage_Click);
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNextPage.Enabled = false;
            this.buttonNextPage.Location = new System.Drawing.Point(141, 374);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(43, 23);
            this.buttonNextPage.TabIndex = 10;
            this.buttonNextPage.Text = ">>";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // listBoxSearchResults
            // 
            this.listBoxSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSearchResults.ContextMenuStrip = this.contextMenuStripOption;
            this.listBoxSearchResults.DisplayMember = "Text";
            this.listBoxSearchResults.FormattingEnabled = true;
            this.listBoxSearchResults.HorizontalScrollbar = true;
            this.listBoxSearchResults.Location = new System.Drawing.Point(6, 19);
            this.listBoxSearchResults.Name = "listBoxSearchResults";
            this.listBoxSearchResults.Size = new System.Drawing.Size(178, 329);
            this.listBoxSearchResults.TabIndex = 8;
            this.listBoxSearchResults.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStripOption
            // 
            this.contextMenuStripOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sORT1ToolStripMenuItem1,
            this.sORT2ToolStripMenuItem1,
            this.toolStripSeparator1,
            this.addToFavoritesToolStripMenuItem1});
            this.contextMenuStripOption.Name = "contextMenuStripOption";
            this.contextMenuStripOption.Size = new System.Drawing.Size(159, 80);
            // 
            // sORT1ToolStripMenuItem1
            // 
            this.sORT1ToolStripMenuItem1.CheckOnClick = true;
            this.sORT1ToolStripMenuItem1.Name = "sORT1ToolStripMenuItem1";
            this.sORT1ToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.sORT1ToolStripMenuItem1.Text = "SORT 1";
            this.sORT1ToolStripMenuItem1.Click += new System.EventHandler(this.sORT1ToolStripMenuItem1_Click);
            // 
            // sORT2ToolStripMenuItem1
            // 
            this.sORT2ToolStripMenuItem1.CheckOnClick = true;
            this.sORT2ToolStripMenuItem1.Name = "sORT2ToolStripMenuItem1";
            this.sORT2ToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.sORT2ToolStripMenuItem1.Text = "SORT 2";
            this.sORT2ToolStripMenuItem1.Click += new System.EventHandler(this.sORT2ToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // addToFavoritesToolStripMenuItem1
            // 
            this.addToFavoritesToolStripMenuItem1.Name = "addToFavoritesToolStripMenuItem1";
            this.addToFavoritesToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.addToFavoritesToolStripMenuItem1.Size = new System.Drawing.Size(158, 26);
            this.addToFavoritesToolStripMenuItem1.Text = "Add to favorites";
            this.addToFavoritesToolStripMenuItem1.Click += new System.EventHandler(this.addToFavoritesToolStripMenuItem1_Click);
            // 
            // groupSearch
            // 
            this.groupSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSearch.Controls.Add(this.textBoxSearch);
            this.groupSearch.Controls.Add(this.btnSearch);
            this.groupSearch.Location = new System.Drawing.Point(8, 8);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(622, 42);
            this.groupSearch.TabIndex = 0;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(6, 15);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(511, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(535, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Enter += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabFavorites
            // 
            this.tabFavorites.Controls.Add(this.listBoxFavorites);
            this.tabFavorites.Location = new System.Drawing.Point(4, 22);
            this.tabFavorites.Name = "tabFavorites";
            this.tabFavorites.Padding = new System.Windows.Forms.Padding(3);
            this.tabFavorites.Size = new System.Drawing.Size(648, 488);
            this.tabFavorites.TabIndex = 1;
            this.tabFavorites.Text = "Favorites";
            this.tabFavorites.UseVisualStyleBackColor = true;
            // 
            // listBoxFavorites
            // 
            this.listBoxFavorites.DisplayMember = "Text";
            this.listBoxFavorites.FormattingEnabled = true;
            this.listBoxFavorites.Location = new System.Drawing.Point(8, 6);
            this.listBoxFavorites.Name = "listBoxFavorites";
            this.listBoxFavorites.Size = new System.Drawing.Size(637, 472);
            this.listBoxFavorites.TabIndex = 0;
            this.listBoxFavorites.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFavorites_SelectedDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.progressBarAddingMovies);
            this.tabPage1.Controls.Add(this.buttonDownloadPoster);
            this.tabPage1.Controls.Add(this.buttonBrowse);
            this.tabPage1.Controls.Add(this.listBoxWatchedMovies);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(648, 488);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Watched Movies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // progressBarAddingMovies
            // 
            this.progressBarAddingMovies.Location = new System.Drawing.Point(8, 451);
            this.progressBarAddingMovies.Name = "progressBarAddingMovies";
            this.progressBarAddingMovies.Size = new System.Drawing.Size(637, 23);
            this.progressBarAddingMovies.TabIndex = 3;
            // 
            // buttonDownloadPoster
            // 
            this.buttonDownloadPoster.Enabled = false;
            this.buttonDownloadPoster.Location = new System.Drawing.Point(499, 392);
            this.buttonDownloadPoster.Name = "buttonDownloadPoster";
            this.buttonDownloadPoster.Size = new System.Drawing.Size(125, 23);
            this.buttonDownloadPoster.TabIndex = 2;
            this.buttonDownloadPoster.Text = "Download Poster";
            this.buttonDownloadPoster.UseVisualStyleBackColor = true;
            this.buttonDownloadPoster.Click += new System.EventHandler(this.buttonDownloadPoster_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(499, 349);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(125, 23);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // listBoxWatchedMovies
            // 
            this.listBoxWatchedMovies.FormattingEnabled = true;
            this.listBoxWatchedMovies.Location = new System.Drawing.Point(8, 12);
            this.listBoxWatchedMovies.Name = "listBoxWatchedMovies";
            this.listBoxWatchedMovies.Size = new System.Drawing.Size(462, 433);
            this.listBoxWatchedMovies.TabIndex = 0;
            this.listBoxWatchedMovies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ShowDetail);
            // 
            // sORT1ToolStripMenuItem
            // 
            this.sORT1ToolStripMenuItem.Name = "sORT1ToolStripMenuItem";
            this.sORT1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sORT1ToolStripMenuItem.Text = "SORT 1";
            // 
            // sORT2ToolStripMenuItem
            // 
            this.sORT2ToolStripMenuItem.Name = "sORT2ToolStripMenuItem";
            this.sORT2ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 5, 0, 1);
            this.sORT2ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.sORT2ToolStripMenuItem.Text = "SORT 2";
            // 
            // addToFavoritesToolStripMenuItem
            // 
            this.addToFavoritesToolStripMenuItem.Name = "addToFavoritesToolStripMenuItem";
            this.addToFavoritesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToFavoritesToolStripMenuItem.Text = "Add to favorites";
            // 
            // OMDb
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 526);
            this.Controls.Add(this.Tab_Control);
            this.Name = "OMDb";
            this.Text = "OmdbAPI";
            this.Tab_Control.ResumeLayout(false);
            this.tabMovies.ResumeLayout(false);
            this.groupBoxDeatails.ResumeLayout(false);
            this.groupBoxDeatails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.contextMenuStripOption.ResumeLayout(false);
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            this.tabFavorites.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_Control;
        private System.Windows.Forms.TabPage tabMovies;
        private System.Windows.Forms.TabPage tabFavorites;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.GroupBox groupBoxDeatails;
        private System.Windows.Forms.Label labelMoreDetails;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxPoster;
        private System.Windows.Forms.Button buttonMoreDetails;
        private System.Windows.Forms.Button buttonPrevPage;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Label labelMovieYear;
        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.Label labelPage;
        public System.Windows.Forms.ListBox listBoxSearchResults;
        private System.Windows.Forms.ListBox listBoxFavorites;
        private System.Windows.Forms.ToolStripMenuItem sORT1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sORT2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToFavoritesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOption;
        private System.Windows.Forms.ToolStripMenuItem sORT1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sORT2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToFavoritesToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonDownloadPoster;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.ListBox listBoxWatchedMovies;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ProgressBar progressBarAddingMovies;
    }
}

