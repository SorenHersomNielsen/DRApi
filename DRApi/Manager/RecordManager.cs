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
            new Record{Id = nextId++, Title = "Pas På Den Knaldrøde Gummibåd", Artist = "Birthe Kjær",Duration = 180, YearOfPublication = 1971},
            new Record{Id = nextId++, Title= "rasmus", Artist = "maj", Duration = 300, YearOfPublication = 2020}
        };
        
        public static List<Tracks> TracksList = new List<Tracks>()
        {
            new Tracks{Id = 1, Name = "Watch What Happens next", Genre = "Rock", RecordId = 1 },
            new Tracks{Id = 2, Name = "Meteor", Genre = "Rock", RecordId = 1 },
            new Tracks{Id = 3, Name = "SStacy's mom", Genre = "Rock", RecordId = 2}
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

        public List<Tracks> GetAllTracksByRecoridId(int id)
        {
            return new List<Tracks>(TracksList.FindAll(TracksList => TracksList.RecordId == id));
        }

        public Record AddRecord(Record record)
        {
            record.Id = nextId++;
            RecordList.Add(record);
            return record;
        }

        public Tracks AddTracks(int RecordId, Tracks tracks)
        {
            Record record = RecordList.Find(t => t.Id == RecordId);
            if (record == null)
            {
                return null;
            }
            tracks.RecordId = RecordId;
            tracks.Id = nextId++;
            TracksList.Add(tracks);
            return tracks;
        }

        public Tracks UpdateTracks(int TracksId, Tracks updates)
        {
            Tracks tracks = TracksList.Find(TracksList => TracksList.Id == TracksId);
            if (tracks == null)
            {
                return null;
            }

            tracks.Name = updates.Name;
            tracks.Genre = updates.Genre;
            tracks.RecordId = updates.RecordId;
            return tracks;
        }

    }
}
