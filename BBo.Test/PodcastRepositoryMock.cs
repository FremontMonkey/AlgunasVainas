using BBo.Model.Entities;
using BBo.Model.Podcasts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBo.Test
{
    internal class PodcastRepositoryMock : IPodcastRepository
    {
        private IList<Podcast> podcastList;
        private Podcast podcast;

        public async Task<IList<Podcast>> GetAllPodcastsAsync()
        {
            return await CreateMockPodcastList();
        }

        public async Task<Podcast> GetPodcastByIdAsync(int id)
        {
            podcastList = new List<Podcast>();
            podcastList = await CreateMockPodcastList();
            podcast = podcastList.FirstOrDefault(i => i.Id == id);
            return podcast;
        }

        private async Task<List<Podcast>> CreateMockPodcastList()
        {
            var mockPodcastList = new List<Podcast>();

            var podcast1 = new Podcast(1, "Podcast 1", "http://www.google.com", 
                "https://d3wo5wojvuv7l.cloudfront.net/t_square_limited_320/images.spreaker.com/original/4d62a22bf2a6f0b9b8bf8ba9ba953acb.jpg", 
                "This is Podcast 1");
            mockPodcastList.Add(podcast1);

            var podcast2 = new Podcast(2, "Podcast 2", "http://www.google.com",
                "https://d3wo5wojvuv7l.cloudfront.net/t_square_limited_320/images.spreaker.com/original/4d62a22bf2a6f0b9b8bf8ba9ba953acb.jpg",
                "This is Podcast 2");
            mockPodcastList.Add(podcast2);

            var podcast3 = new Podcast(3, "Podcast 3", "http://www.google.com",
                "https://d3wo5wojvuv7l.cloudfront.net/t_square_limited_320/images.spreaker.com/original/4d62a22bf2a6f0b9b8bf8ba9ba953acb.jpg",
                "This is Podcast 3");
            mockPodcastList.Add(podcast3);

            return await Task.FromResult<List<Podcast>>(mockPodcastList);
        }
    }
}