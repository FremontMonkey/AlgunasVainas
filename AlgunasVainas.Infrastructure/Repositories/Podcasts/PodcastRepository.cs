using AlgunasVainas.Model.Entities;
using AlgunasVainas.Model.Podcasts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AlgunasVainas.Infrastructure.Repositories.Podcasts
{
    public class PodcastRepository : IPodcastRepository
    {
        private readonly string strConn;
        private SqlConnection connection;
        public PodcastRepository(string connectionString)
        {
            strConn = connectionString;
        }

        public async Task<IList<Podcast>> GetAllPodcastsAsync()
        {
            var podcastList = new List<Podcast>();
            connection = new SqlConnection(strConn);

            using (connection)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT Id, Name, Url, ImageUrl, Description FROM dbo.Podcast;",
                  connection);
                await connection.OpenAsync();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var podcast = new Podcast();
                        if (reader[0] != DBNull.Value)
                            podcast.Id = reader.GetInt32(0);
                        if (reader[1] != DBNull.Value)
                            podcast.Name = reader.GetString(1);
                        if (reader[2] != DBNull.Value)
                            podcast.Url = reader.GetString(2);
                        if (reader[3] != DBNull.Value)
                            podcast.ImageUrl = reader.GetString(3);
                        if (reader[4] != DBNull.Value)
                            podcast.Description = reader.GetString(4);

                        podcastList.Add(podcast);
                    }
                }
            }

            return podcastList;
        }
        public async Task<Podcast> GetPodcastByIdAsync(int id)
        {
            var podcast = new Podcast();
            connection = new SqlConnection(strConn);

            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT Id, Name, Url, ImageUrl, Description FROM dbo.Podcast WHERE Id = @Id;", connection);
                command.Parameters.Add(new SqlParameter("@Id", id)); 
                await connection.OpenAsync();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader[0] != DBNull.Value)
                            podcast.Id = reader.GetInt32(0);
                        if (reader[1] != DBNull.Value)
                            podcast.Name = reader.GetString(1);
                        if (reader[2] != DBNull.Value)
                            podcast.Url = reader.GetString(2);
                        if (reader[3] != DBNull.Value)
                            podcast.ImageUrl = reader.GetString(3);
                        if (reader[4] != DBNull.Value)
                            podcast.Description = reader.GetString(4);
                    }
                }
            }
            return podcast;
        }
    }
}
