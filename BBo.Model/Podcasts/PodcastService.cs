using BBo.Model.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BBo.Model.Podcasts
{
    public class PodcastService
    {
        IPodcastRepository _repository = null;

        public PodcastService(IPodcastRepository repository)
        {
            _repository = repository;
            if (_repository == null)
                throw new ArgumentException("Repository cannot be null");
        }

        public async Task<IList<Podcast>> GetAllPodcastsAsync()
        {
            try
            {
                return await _repository.GetAllPodcastsAsync();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("ERROR GetAllPodcasts: " + ex.ToString(), ex);
                // throw new Exception();
            }
        }

        public async Task<Podcast> GetPodcastByIdAsync(int id)
        {
            //throw new NotImplementedException();
            try
            {
                return await _repository.GetPodcastByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("ERROR GetPodcastById: " + ex.ToString(), ex);
            }
        }
    }
}
