using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_List
{
    class Movie
    {
        //These are properties title and category
        public string Title { get; set; }
        public string Category { get; set; }
        //This is a constructor for the properties
        public Movie(string Title, string Category)
        {
            this.Title = Title;
            this.Category = Category;
        }
    }

}
