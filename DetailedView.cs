using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Callers;


namespace WindowsFormsApp1
{
    public partial class DetailedView : Form
    {

        
        public DetailedView( string imdMovie)
        {
            /*
            OMDb OmdbMovie = new OMDb();

            string address = OmdbMovie.SelectedItemID;
            */
            
            InitializeComponent();



            var caller = new RestSharpCaller("http://www.omdbapi.com/?apikey=5d4834e7&");
            var movies = caller.GetMovie(imdMovie);

            Console.WriteLine("hahahhahahhaha{0}", movies.Title);

            
            textBoxTitleYear.Text = movies.Title + " (" + movies.Year + ")" ;

            textBoxGenre.Text =  movies.Genre + "  |  " + movies.Runtime + "  |  " + movies.Released + "  |  " + movies.Rated;
            textBoxAwards.Text = "Awards: " + movies.Awards;
            textBoxLanguage.Text = "Language: " + movies.Language;
            textBoxCountry.Text = "Country: " + movies.Country;
            textBoxMetascore.Text = "Metascore: " + movies.Metascore;
            textBoxType.Text = movies.Type;

            richTextBoxInfo.Text = "Director: " + movies.Director + "\n\nWriter: " + movies.Writer + "\n\nActors: " + movies.Actors + "\n\nProduction: " + movies.Production;

            textBoxRating.Text = "IMDb rating: " + movies.imdbRating + "/" + movies.imdbVotes + " votes";

           
            // lblRatings.Text = movies.Ratings;
            textBoxDVD.Text = "DVD: " + movies.DVD;
            textBoxBoxOffice.Text = "BoxOffice: " + movies.BoxOffice;
            textBoxWebsite.Text = "Website: " + movies.Website;

            richTextBoxPlot.Text = movies.Plot;

            // richTextBoxRatings.Text = movies.Ratings;

            foreach(var rating in movies.Ratings)
                {

                    richTextBoxRatings.Text += "Source: "+ rating.Source + "Rating:" + rating.Value + "\n";


            }

            pictureBoxDetailed.ImageLocation = movies.Poster;




        }



        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxDetailed_Click(object sender, EventArgs e)
        {

        }

        private void DetailedView_Load(object sender, EventArgs e)
        {

        }
    }
}
