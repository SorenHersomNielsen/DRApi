using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRApi.Model
{
    public class Tracks
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        private int recordId;

        public int RecordId
        {
            get { return recordId; }
            set { recordId = value; }
        }


        public override string ToString()
        {
            return $"the id is {Id}, and the song name is {Name}, and is under music genre: {Genre}";
        }
    }
}
