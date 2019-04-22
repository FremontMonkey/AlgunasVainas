namespace BBo.Model.Entities
{
    public class Podcast
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public Podcast() { }

        public Podcast(int id, string name, 
            string url, string imageUrl, string description)
        {
            Id = id;
            Name = name;
            Url = url;
            ImageUrl = imageUrl;
            Description = description;
        }
    }
}
