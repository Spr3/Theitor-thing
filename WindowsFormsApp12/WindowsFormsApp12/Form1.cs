using System;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Web;
using System.Diagnostics;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FindMoveButton_Click(object sender, EventArgs e)
        {
            string nameofmovie = MovieNameTextBox.Text;
            MovieNameTextBox.Visible = false;
            MovieNameLabel.Visible = false;
            theatername.Visible = true;
            Location.Visible = true;
            Time.Visible = true;
            string ForURL = "";
            
            foreach (char letter in nameofmovie)
            {
                if (letter.ToString() == " ")
                {
                    ForURL = ForURL + "-";
                }
                else if (!Char.IsLetterOrDigit(letter))
                {
                    //Sup
                }
                else
                {
                    ForURL = ForURL + letter.ToString().ToUpper();
                }
            }

            string WebPage = "https://www.galaxytheatres.com/movie/Tucson/"+ ForURL + "#tucson";
            string website = "https://www.galaxytheatres.com/movie/Tucson/CHRISTMAS-WITH-THE-CHOSEN-THE-MESSENGERS#tucson";

            var web = new HtmlWeb();
            var doc = web.Load(website);
            var articals = doc.DocumentNode.SelectNodes("//*[@class= 'movie__dates']");

            foreach (var artical in articals)
            {
                var class1 = HttpUtility.HtmlDecode(artical.SelectSingleNode(".//div[@class = 'box movie__box']").InnerText);
                //grabbing data values 
                string date = "";
                string time = "";
                //Date
                int spacesleftfordate = 4;
                foreach (var letter in class1)
                {
                    //For the date
                    if (spacesleftfordate == 4)
                    {
                        if (letter.ToString() == "T")
                        {
                            date = date + letter.ToString();
                            spacesleftfordate -= 1;
                        }
                    }
                    else if (!(spacesleftfordate == 0))
                    {
                        date = date + letter.ToString();
                        if (letter.ToString() == " ")
                        {
                            spacesleftfordate -= 1;
                        }
                    }
                }
                //Time editing
                int numbersleftfortime = 4;
                foreach (var letter in class1)
                {
                    //For the date
                    if (numbersleftfortime == 4)
                    {
                        //if it is a number
                        //if is a number returns TRUE
                        if (int.TryParse(letter.ToString(), out int n))
                        {
                            spacesleftfordate -= 1;
                        }
                        else
                        {
                        }
                    }
                    else if (!(numbersleftfortime == 0))
                    {
                        date = date + letter.ToString();
                        if (letter.ToString() == " ")
                        {
                            time += letter.ToString();
                            spacesleftfordate -= 1;
                        }
                    }
                }
                Console.WriteLine(date);
                Console.WriteLine(time);
            }
        }
    }
}
