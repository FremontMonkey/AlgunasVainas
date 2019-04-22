using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AlgunasVainas.Infrastructure.Repositories.Podcasts;
using AlgunasVainas.Model.Entities;
using AlgunasVainas.Model.Podcasts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AlgunasVainas.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PodcastController : ControllerBase
    {
        private readonly PodcastService _service;
        private readonly IPodcastRepository _repository;

        public PodcastController(IConfiguration configuration)
        {
            string connectionString = configuration.GetSection("ConnectionStrings")["AlgunasVainasConnection"];
            _repository = new PodcastRepository(connectionString);
            _service = new PodcastService(_repository);
        }

        // GET: api/Podcast
        [HttpGet]
        public async Task<IList<Podcast>> Get()
        {
            //var personList = new List<Podcast>();
            var personList = await _service.GetAllPodcastsAsync();
            return personList;
        }

        // GET: api/Podcast/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Podcast> Get(int id)
        {
            var podcast = new Podcast();
            podcast = await _service.GetPodcastByIdAsync(id);
            return podcast;
        }

        // POST: api/Podcast
        [HttpPost]
        public void Post([FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Podcast/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
