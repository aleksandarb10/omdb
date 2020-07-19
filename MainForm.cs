using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OMDB_API.Callers;
using OMDB_API.Models;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Drawing.Imaging;
using System.Net;

namespace OMDB_API
{


    public partial class OMDb : Form
    {

        private int PageNumber { get; set; }
        private int NumberOfPages { get; set; }
        public string PathToFolder { get; set; }

        DetailedView detailedView;


        public OMDb()
        {

            InitializeComponent();

            PageNumber = 1;
            if (OMDB_API.Properties.Settings.Default.Search != string.Empty)
            {
                textBoxSearch.Text = OMDB_API.Properties.Settings.Default.Search;
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie newItem = (Movie)listBoxSearchResults.SelectedItem;
            SelectedItemID = newItem.imdbID;
            labelMovieTitle.Text = newItem.Title;
            labelMovieYear.Text = newItem.Year;
            pictureBoxPoster.ImageLocation = newItem.Poster;
            if (detailedView!=null)
            { passMovieDetails(SelectedItemID); }
            
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            PageNumber = 1;
            GetMoviesSearch(PageNumber);
            OMDB_API.Properties.Settings.Default.Search = textBoxSearch.Text;
            OMDB_API.Properties.Settings.Default.Save();
            
        }

        private void buttonMoreDetails_Click(object sender, EventArgs e)
        {
           detailedView = new DetailedView();

            passMovieDetails(SelectedItemID);

            detailedView.Show();

        }
        public string SelectedItemID { get; set; }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            PageNumber++;
            GetMoviesSearch(PageNumber);

        }
        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            PageNumber--;
            GetMoviesSearch(PageNumber);
        }

        private void GetMoviesSearch(int page)
        {
            var caller = new RestSharpCaller("http://www.omdbapi.com/?apikey=5d4834e7&");
            var movies = caller.GetMovies(textBoxSearch.Text, page);

            if (movies.Response == "True")
            {

                listBoxSearchResults.Items.Clear();
                foreach (var movie in movies.Search)
                {
                    movie.Text = movie.Title + " (" + movie.Year + ")";
                    listBoxSearchResults.Items.Add(movie);
                }

                listBoxSearchResults.SelectedIndex = 0;
                buttonMoreDetails.Enabled = true;

                Movie newItem = (Movie)listBoxSearchResults.SelectedItem;

                SelectedItemID = newItem.imdbID;

                NumberOfPages = (Convert.ToInt16(movies.totalResults) / 10);

                if ((Convert.ToInt16(movies.totalResults) % 10) != 0)
                {
                    NumberOfPages = NumberOfPages + 1;
                }


                labelPage.Text = PageNumber + "/" + NumberOfPages;

                if (PageNumber == 1)
                {
                    buttonPrevPage.Enabled = false;
                }
                else
                {
                    buttonPrevPage.Enabled = true;
                }

                if (PageNumber == NumberOfPages)
                {
                    buttonNextPage.Enabled = false;
                }
                else
                {
                    buttonNextPage.Enabled = true;
                }


                labelMovieTitle.Text = newItem.Title;
                labelMovieYear.Text = newItem.Year;
                pictureBoxPoster.ImageLocation = newItem.Poster;
            }

            else
            {
                MessageBox.Show("Search failed.\n Error: " + movies.Error);

            }


        }
        public void SortNameYear()
        {


            if (!contextMenuStripOption.Items[0].Selected)
            {

                ((ToolStripMenuItem)contextMenuStripOption.Items[0]).Checked = true;
                List<Movie> movies = listBoxSearchResults.Items.Cast<Movie>().OrderBy(i => i.Year).Cast<Movie>().ToList();

                listBoxSearchResults.Items.Clear();

                foreach (Movie movie in movies)
                {
                    listBoxSearchResults.Items.Add(movie);
                }
            }
            else if (!contextMenuStripOption.Items[1].Selected)
            {
                List<Movie> movies = listBoxSearchResults.Items.Cast<Movie>().OrderBy(i => i.Title).Cast<Movie>().ToList();


                listBoxSearchResults.Items.Clear();

                foreach (Movie movie in movies)
                {
                    listBoxSearchResults.Items.Add(movie);
                }
            }
        }

        public void SortNameType()
        {
            ((ToolStripMenuItem)contextMenuStripOption.Items[1]).Checked = true;
            if (!contextMenuStripOption.Items[1].Selected)
            {

                List<Movie> movies = listBoxSearchResults.Items.Cast<Movie>().OrderBy(i => i.Type).Cast<Movie>().ToList();
                listBoxSearchResults.Items.Clear();

                foreach (Movie movie in movies)
                {
                    listBoxSearchResults.Items.Add(movie);
                }

            }
            else if (!contextMenuStripOption.Items[0].Selected)
            {
                List<Movie> movies = listBoxSearchResults.Items.Cast<Movie>().OrderBy(i => i.Title).Cast<Movie>().ToList();


                listBoxSearchResults.Items.Clear();

                foreach (Movie movie in movies)
                {
                    listBoxSearchResults.Items.Add(movie);
                }
            }
        }

        private void sORT1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SortNameYear();
        }

        private void sORT2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SortNameType();
        }

        private void addToFavoritesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBoxSearchResults.SelectedItem != null)
            { 

            Movie newItem = (Movie)listBoxSearchResults.SelectedItem;
            TextWriter txt = new StreamWriter("..\\..\\Data\\Data.txt", true);
            txt.Write(newItem.imdbID + ";" + newItem.Text + "\n");
            txt.Close();
        }


        }

        void tabControl1_Selecting(object sender, EventArgs e)
        {
            if (Tab_Control.SelectedTab.Text == "Favorites")
            {
                listBoxFavorites.Items.Clear();
                TextReader txt = new StreamReader("..\\..\\Data\\Data.txt");

                string line;

                while ((line = txt.ReadLine()) != null)
                {
                    Movie movie = new Movie();
                    string[] both = line.Split(';');

                    movie.imdbID = both[0];

                    movie.Text = both[1];

                    listBoxFavorites.Items.Add(movie);
                }

                txt.Close();
            }
        }

        private void listBoxFavorites_SelectedDoubleClick(object sender, MouseEventArgs e)
        {
            Movie movie = (Movie)listBoxFavorites.SelectedItem;
            SelectedItemID = movie.imdbID;
            detailedView = new DetailedView();
            passMovieDetails(SelectedItemID);

            detailedView.Show();
        }

        void passMovieDetails(string imdMovie)
        {
                 var caller = new RestSharpCaller("http://www.omdbapi.com/?apikey=5d4834e7&");
                 var movies = caller.GetMovie(imdMovie);

                detailedView.textBoxTitleYear.Text = movies.Title + " (" + movies.Year + ")" ;
                detailedView.textBoxGenre.Text =  movies.Genre + "  |  " + movies.Runtime + "  |  " + movies.Released + "  |  " + movies.Rated;
                detailedView.textBoxAwards.Text = "Awards: " + movies.Awards;
                detailedView.textBoxLanguage.Text = "Language: " + movies.Language;
                detailedView.textBoxCountry.Text = "Country: " + movies.Country;
                detailedView.textBoxMetascore.Text = "Metascore: " + movies.Metascore;
                detailedView.textBoxType.Text = movies.Type;
                detailedView.richTextBoxInfo.Text = "Director: " + movies.Director + "\n\nWriter: " + movies.Writer + "\n\nActors: " + movies.Actors + "\n\nProduction: " + movies.Production;
                detailedView.textBoxRating.Text = "IMDb rating: " + movies.imdbRating + "/" + movies.imdbVotes + " votes";
                detailedView.textBoxDVD.Text = "DVD: " + movies.DVD;
                detailedView.textBoxBoxOffice.Text = "BoxOffice: " + movies.BoxOffice;
                detailedView.textBoxWebsite.Text = "Website: " + movies.Website;
                detailedView.richTextBoxPlot.Text = movies.Plot;

                foreach(var rating in movies.Ratings)
                    {

                    detailedView.richTextBoxRatings.Text += "Source: "+ rating.Source + "Rating:" + rating.Value + "\n";
                }

                detailedView.pictureBoxDetailed.ImageLocation = movies.Poster;

}

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            progressBarAddingMovies.Value = 0;
            string folderPath = "";
            var regex ="([\\w\\s]+) \\((\\w+)[\\)]$";
           


            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                int i = 0;
                folderPath = folderBrowserDialog1.SelectedPath;

                PathToFolder = folderPath;


                string[] fileArray = Directory.GetDirectories (folderPath);
                string ignored = " ";
                progressBarAddingMovies.Maximum = fileArray.Count();


                foreach (var file in fileArray)
                {
                    string title = file.Substring(file.LastIndexOf("\\") + 1);

                    var match = Regex.Match(title, regex, RegexOptions.IgnoreCase);

                    if (!match.Success)
                    {
                        ignored += title + "; ";
                        System.Threading.Thread.Sleep(200);
                    }
                    else
                    {
                        i = 1;
                        listBoxWatchedMovies.Items.Add(title);
                        System.Threading.Thread.Sleep(200);
                    }
                    
                    progressBarAddingMovies.Value++;
                    


                }
                MessageBox.Show("Rejected folders:" + ignored + "\n Folder name is not in correct format!");
                if (i > 0)
                {
                    buttonDownloadPoster.Enabled = true;
                }
                else
                {
                    buttonDownloadPoster.Enabled = false;
                }


            }
        }

        private void GetMoviebyTitleAndYear(string Title, string Year)
        {
            var caller = new RestSharpCaller("http://www.omdbapi.com/?apikey=5d4834e7&");
            var movies = caller.GetMoviesByTitleYear(Title, Year);
            detailedView = new DetailedView();


            if (movies.Response == "True")
            {
                passMovieDetails(movies.Search[0].imdbID);
                detailedView.Show();

            }
            else
            {
                MessageBox.Show("Movie not found");
            }
  
        }

        private void ShowDetail(object sender, MouseEventArgs e)
        {
            string title;
            string year;
            var regex = "([\\w\\s]+) \\((\\w+)[\\)]$";

            var match = Regex.Match(listBoxWatchedMovies.SelectedItem.ToString(), regex, RegexOptions.IgnoreCase);

            if (match.Success)
            {
                title = match.Groups[1].Value;
                year = match.Groups[2].Value;
                GetMoviebyTitleAndYear(title,year);

            }
            else
            {
                
                MessageBox.Show("Some problem occurs!");

            }
        }

        private void buttonDownloadPoster_Click(object sender, EventArgs e)
        {
            string title;
            string year;
            var regex = "([\\w\\s]+) \\((\\w+)[\\)]$";

            var match = Regex.Match(listBoxWatchedMovies.SelectedItem.ToString(), regex, RegexOptions.IgnoreCase);

            if (match.Success)
            {
                title = match.Groups[1].Value;
                year = match.Groups[2].Value;
                var caller = new RestSharpCaller("http://www.omdbapi.com/?apikey=5d4834e7&");
                var movies = caller.GetMoviesByTitleYear(title, year);
                if (movies.Response == "True")
                {
                    string ImageURL = movies.Search[0].Poster;
                    try
                    {
                        SaveImage(movies.Search[0].Title + "_" + movies.Search[0].Year , listBoxWatchedMovies.SelectedItem.ToString(), ImageURL);
                        MessageBox.Show("Poster saved!");
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine("{0} Exception caught.", error);
                        MessageBox.Show("Error with downloading photo!");
                    }

                }
                else
                {
                    MessageBox.Show("Movie not found");
                }

            }
            else
            {

                MessageBox.Show("Some problem occurs!");
            }
        }
        public void SaveImage(string filename, string moviefolder, string imageUrl)
        {
            WebClient client = new WebClient();
            client.DownloadFile(imageUrl, @"" + PathToFolder + "\\" + moviefolder + "\\" + filename + ".jpg");
            client.Dispose();
        }
    }
}
