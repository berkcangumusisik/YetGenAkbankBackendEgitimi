namespace SpotifyClone.Entities
{
    public class Song
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }

        public string Producer { get; set; }

        public string Composer { get; set; }

        public Song()
        {
            Id = Guid.NewGuid();
        }

        public Song(string title, string artist, string producer, string composer) : this()
        {
            Title = title;
            Artist = artist;
            Producer = producer;
            Composer = composer;
        }
    }
}