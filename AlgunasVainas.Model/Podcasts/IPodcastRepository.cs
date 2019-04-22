using AlgunasVainas.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlgunasVainas.Model.Podcasts
{
    public interface IPodcastRepository
    {
        Task<Podcast> GetPodcastByIdAsync(int id);
        Task<IList<Podcast>> GetAllPodcastsAsync();
    }
}
