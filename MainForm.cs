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
using WindowsFormsApp1.Callers;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{


    public partial class OMDb : Form
    {

        private int PageNumber { get; set; }
        private int NumberOfPages { get; set; }





        /* var caller = new RestSharpCaller("http://www.omdbapi.com/?apikey=5d4834e7&");*/

        public OMDb()
        {

            InitializeComponent();
            textBoxSearch.Text = OMDB_API.Properties.Settings.Default.Search;
            PageNumber = 1;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie newItem = (Movie)listBoxSearchResults.SelectedItem;
            SelectedItemID = newItem.imdbID;
            labelMovieTitle.Text = newItem.Title;
            labelMovieYear.Text = newItem.Year;
            pictureBoxPoster.ImageLocation = newItem.Poster;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PageNumber = 1;
            GetMoviesSearch(PageNumber);
            
        }

        private void buttonMoreDetails_Click(object sender, EventArgs e)
        {
            DetailedView detailedView = new DetailedView(SelectedItemID);

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
                // List<Movie> movies = listBoxSearchResults.Items.Cast<Movie>().OrderBy(i => i.Title).GroupBy(i => i.Year).Cast<Movie>().ToList();
                List<Movie> movies = listBoxSearchResults.Items.Cast<Movie>().OrderBy(i => i.Year).Cast<Movie>().ToList();

                listBoxSearchResults.Items.Clear();

                foreach (Movie movie in movies)
                {
                    listBoxSearchResults.Items.Add(movie);
                }

                if (contextMenuStripOption.Items[1].Selected)
                {
                    ((ToolStripMenuItem)contextMenuStripOption.Items[1]).Checked = false;
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
                /* List<Movie> movies = listBoxSearchResults.Items.Cast<Movie>().OrderBy(i => i.Title).GroupBy(i => i.Type).Cast<Movie>().ToList();*/

                List<Movie> movies = listBoxSearchResults.Items.Cast<Movie>().OrderBy(i => i.Type).Cast<Movie>().ToList();
                listBoxSearchResults.Items.Clear();

                foreach (Movie movie in movies)
                {
                    listBoxSearchResults.Items.Add(movie);
                }

                if (contextMenuStripOption.Items[0].Selected)
                {
                    ((ToolStripMenuItem)contextMenuStripOption.Items[0]).Checked = false;
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
            
            Movie newItem = (Movie)listBoxSearchResults.SelectedItem;
                TextWriter txt = new StreamWriter("..\\..\\Data\\Data.txt", true);
            txt.Write(newItem.imdbID + ";" + newItem.Text + "\n" );
            txt.Close();


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
    }
}
