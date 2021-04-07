using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRApi.Model
{
    public class Record
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string artist;

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        private int duration;

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        private int yearOfPublication;

        public int YearOfPublication
        {
            get { return yearOfPublication; }
            set { yearOfPublication = value; }
        }
    }
}
