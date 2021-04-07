using DRApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRApi.Manager
{
    public class RecordManager
    {
        private static int nextId = 1;

        public static List<Record> RecordList = new List<Record>()
        {
            new Record{Id = nextId++, Title = "Øde Ø", Artist ="Rasmus Seebach", Duration = 180, YearOfPublication = 2013},
            new Record{Id = nextId++, Title = "Pas På Den Knaldrøde Gummibåd", Artist = "Birthe Kjær",Duration = 180, YearOfPublication = 1971}
        };

        public List<Record> GetAll()
        {
            return new List<Record>(RecordList);
        }

        public Record GetById(int id)
        {
            return RecordList.Find(record => record.Id == id);
        }

        public Record GetByTitle(string title)
        {
            return RecordList.Find(record => record.Title == title);
        }

        public Record GetByArtist(string artist)
        {
            return RecordList.Find(record => record.Artist == artist);
        }
    }
}
