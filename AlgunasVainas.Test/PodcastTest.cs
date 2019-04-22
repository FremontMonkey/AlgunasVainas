using System.Collections.Generic;
using AlgunasVainas.Model.Entities;
using AlgunasVainas.Model.Podcasts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgunasVainas.Infrastructure.Repositories.Podcasts;
using System.Threading.Tasks;

namespace AlgunasVainas.Test
{
    [TestClass]
    public class PodcastTest
    {
        PodcastService svcMock;
        IPodcastRepository repMock;
        PodcastService svc;
        IPodcastRepository rep;
        Podcast podcast;
        IList<Podcast> podcastList;
        string conn;

        [TestInitialize]
        public void Setup()
        {
            conn = "Server=XXXXX;Database=XXXXX; User ID=XXXXX;Password=XXXXX;Trusted_Connection=False; Encrypt=True;";
            repMock = new PodcastRepositoryMock();
            svcMock = new PodcastService(repMock);
            rep = new PodcastRepository(conn);
            svc = new PodcastService(rep);
        }

        [TestMethod]
        public async Task GetAllPodcastsAsync_Successfully_Returns_All_Podcasts()
        {
            podcastList = await svc.GetAllPodcastsAsync();
            Assert.IsTrue(podcastList.Count > 0);
        }

        [TestMethod]
        public async Task GetPodcastByIdAsync_Successfully_Returns_Podcast_If_Id_Is_Valid()
        {
            var podcastList = await svc.GetAllPodcastsAsync();
            var id = podcastList[0].Id;
            podcast = await svc.GetPodcastByIdAsync(id);
            Assert.IsNotNull(podcast);
        }

        [TestMethod]
        public async Task GetAllPodcastsAsync_Successfully_Returns_All_Podcasts_MOCK()
        {
            podcastList = await svcMock.GetAllPodcastsAsync();
            Assert.IsTrue(podcastList.Count > 0);
        }

        [TestMethod]
        public async Task GetPodcastByIdAsync_Successfully_Returns_Podcast_If_Id_Is_Valid_MOCK()
        {
            var podcastList = await svc.GetAllPodcastsAsync();
            var id = podcastList[0].Id;
            podcast = await svcMock.GetPodcastByIdAsync(id);
            Assert.IsNotNull(podcast);
        }
    }
}
