using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_List
{
    class CategoryList
    {
        //This creates an empty movie list, which is global and can be used anywhere within the class
        public List<Movie> MovieList { get; set; } = new List<Movie>();
        //This list has the four categories of type Movie (also global)
        List<string> category = new List<string>() { "Animated", "Drama", "Horror", "Scifi" };

        //This is a consctuctor
        public CategoryList()
        {
            //This list contains 12 movies and category for each movie
            MovieList.Add(new Movie("Sing", category[0]));
            MovieList.Add(new Movie("Big Hero 6", category[0]));
            MovieList.Add(new Movie("Spirited Away", category[0]));
            MovieList.Add(new Movie("Joy", category[1]));
            MovieList.Add(new Movie("The Notebook", category[1]));
            MovieList.Add(new Movie("Forrest Gump", category[1]));
            MovieList.Add(new Movie("Halloween", category[2]));
            MovieList.Add(new Movie("It", category[2]));
            MovieList.Add(new Movie("Us", category[2]));
            MovieList.Add(new Movie("Lucy", category[3]));
            MovieList.Add(new Movie("Venom", category[3]));
            MovieList.Add(new Movie("Avatar", category[3]));
            //MovieList.Sort();
        }

        public string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            return input;
        }

        public void GetGenre()
        {
            string dash = "-----------------------------------------------------";
            Console.WriteLine($"{dash}\n[0]{category[0]} [1]{category[1]} [2]{category[2]} [3]{category[3]}\n{dash}");
            Movie name;

            bool goOn = true;
            while (goOn == true)
            {
                try
                {
                    int index = int.Parse(GetUserInput($"Which genre are you interested in? Enter 0 to {category.Count - 1}"));
                    name = MovieList[index];
                    Console.WriteLine("");
                    if (index == 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Movie t = MovieList[i];
                            Console.WriteLine($"{t.Title}");
                        }
                    }
                    else if (index == 1)
                    {

                        for (int i = 3; i < 6; i++)
                        {
                            Movie t = MovieList[i];
                            Console.WriteLine($"{t.Title}");
                        }
                    }
                    else if (index == 2)
                    {
                        for (int i = 6; i < 9; i++)
                        {
                            Movie t = MovieList[i];
                            Console.WriteLine($"{t.Title}");
                        }
                    }
                    else if (index == 3)
                    {

                        for (int i = 9; i < 12; i++)
                        {
                            Movie t = MovieList[i];
                            Console.WriteLine($"{t.Title}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input was not a valid index");
                        goOn = true;
                    }
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input was not a valid index");
                    Console.WriteLine($"Please put an index between 0 and {category.Count - 1}");
                    goOn = true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Input was out of range");
                    Console.WriteLine($"Please put an index between 0 and {category.Count - 1}");
                    goOn = true;
                }
            }
        }

        public bool Continue()
        {
            string ans = GetUserInput("Would you like to continue? (y/n)").ToLower();
            if (ans == "y")
            {
                return true;
            }
            else if (ans == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                return Continue();
            }
        }




    }
}
