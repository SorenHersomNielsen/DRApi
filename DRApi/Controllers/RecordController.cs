using DRApi.Manager;
using DRApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {

        RecordManager manager = new RecordManager();
        // GET: api/<RecordController>
        [HttpGet]
        public IEnumerable<Record> Get()
        {
            return manager.GetAll();
        }

        // GET api/<RecordController>/5
        [HttpGet("{id}")]
        public Record GetById(int id)
        {
            return manager.GetById(id);
        }

        [HttpGet("title/{title}")]
        public Record GetByTitle(string title)
        {
            return manager.GetByTitle(title);
        }

        [HttpGet("artist/{artist}")]
        public Record GetByArtist(string artist)
        {
            return manager.GetByArtist(artist);
        }

        [HttpGet("{RecordId}/Tracks")]
        public IEnumerable<Tracks> GetAllTracks(int RecordId)
        {
            return manager.GetAllTracksByRecoridId(RecordId);
        }

        // POST api/<RecordController>
        [HttpPost]
        public Record Post([FromBody] Record value)
        {
            return manager.AddRecord(value);
        }

        [HttpPost("{RecordId}/Tracks")]
        public Tracks PostTracks(int RecordId, [FromBody] Tracks value)
        {
            return manager.AddTracks(RecordId, value);
        }

        // PUT api/<RecordController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // PUT api/<RecordController>/5
        [HttpPut("{TracksId}/Tracks")]
        public Tracks PutTracks(int TracksId, [FromBody] Tracks value)
        {
            return manager.UpdateTracks(TracksId, value);
        }

        // DELETE api/<RecordController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
