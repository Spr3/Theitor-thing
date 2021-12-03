using System;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Web;
using System.Collections.Generic;
using System.Linq;

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
            if (string.IsNullOrWhiteSpace(MovieNameTextBox.Text))
            {
                Console.WriteLine("Blank");
                FindMoveButton.Text = "The Movie is blank";
                FindMoveButton.Enabled = false;
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Chanked");
                FindMoveButton.Text = "Find Movie";
                FindMoveButton.Enabled = true;
            }   
            else
            {
                Console.WriteLine(FindMoveButton.Text);
                MovieNameTextBox.Visible = false;
                MovieNameLabel.Visible = false;
                theatername.Visible = true;
                Location.Visible = true;
                Time.Visible = true;
                string website = "https://www.galaxytheatres.com/movie/Tucson/" + ForURL + "#tucson";

                Console.WriteLine(website);

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
                    int numbersleftfortime = 6;
                    foreach (var letter in class1)
                    {
                        //For the date
                        if (numbersleftfortime == 6)
                        {
                            //if it is a number
                            //if is a number returns TRUE
                            if (int.TryParse(letter.ToString(), out int n))
                            {
                                numbersleftfortime -= 1;
                            }
                        }
                        else if (!(numbersleftfortime == 0))
                        {
                            if (int.TryParse(letter.ToString(), out int n) || letter.ToString() == ":")
                            {
                                time += letter.ToString();
                                numbersleftfortime -= 1;
                            }
                        }
                    }
                    Time.Text = "Date and Time:\n" + date + time;
                }
            }

            string FindMovies = "https://www.galaxytheatres.com/movie-theater/tucson?d=12/3/2021";

            var web1 = new HtmlWeb();
            var doc1 = web1.Load(FindMovies);
            var articals1 = doc1.DocumentNode.SelectNodes("//*[@class= 'flex__container nowPlaying']");

            foreach (var artical1 in articals1)
            {
                string text = artical1.InnerText;
                string[] findword = new string[] {"y", "n", "o", "p", "s", "i"};
                string word = "";
                int letteron = 0;
                bool wordfound = false;
                string[] OpenMovies = new string[] {};
                string movieName = "";
                foreach (char letter in text)
                {
                    
                    // if has not found the word
                    if (!wordfound)
                    {
                        //if the letter is alsost the word
                        if (letter.ToString().ToLower() == findword[letteron] || !wordfound)
                        {
                            Console.WriteLine(findword[letteron]);
                            //if at end of array
                            if (findword[letteron] == "i")
                            {
                                wordfound = true;
                            }
                            letteron += 1;
                        }
                        else
                        {
                            //restarts word
                            letteron = 0;
                        }
                    }
                    //if the movie was found
                    else
                    {
                        if (Char.IsLetter(letter))
                        {
                            movieName += letter.ToString();
                        }
                        else if (!(movieName==""))
                        {
                            wordfound = false;
                            List<string> ls = findword.ToList();
                            ls.Add(movieName);
                            findword.ToArray();
                        }
                    }
                }
                foreach (string movie in OpenMovies)
                {
                    Console.WriteLine(movie);
                }    
                //var class1 = HttpUtility.HtmlDecode(artical1.SelectSingleNode(".//div[@class = 'box movie__box']").InnerText);
            }
        }
    }
}
//Synopsis
