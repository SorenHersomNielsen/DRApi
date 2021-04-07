using DRApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRApi.Manager
{
    public class RecordManager
    {
        public static List<Record> RecordList = new List<Record>()
        {
            new Record{Title = "Øde Ø", Artist ="Rasmus Seebach", Duration = 180, YearOfPublication = 2013},
            new Record{ Title = "Pas På Den Knaldrøde Gummibåd", Artist = "Birthe Kjær",Duration = 180, YearOfPublication = 1971}
        };

        public List<Record> GetAll()
        {
            return new List<Record>(RecordList);
        }
    }
}
