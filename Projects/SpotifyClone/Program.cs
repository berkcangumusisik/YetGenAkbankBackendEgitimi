
using SpotifyClone.Entities;
using SpotifyClone.Services;

Song song1 = new Song
{
    Title = "Requem K.626",
    Artist = "Wolfgang Amadeus Mozart",
    Producer = "Wolfgang Amadeus Mozart",
    Composer = "Wolfgang Amadeus Mozart"
};

Song song2 = new Song
{
    Title = "Symphony No. 9",
    Artist = "Ludwig van Beethoven",
    Producer = "Ludwig van Beethoven",
    Composer = "Ludwig van Beethoven"
};


var playlist = new Playlist(song1);
playlist.AddSong(song2);

playlist.ShowSongs();

Console.WriteLine("Önceki Şarkı ");
Console.WriteLine(playlist.GetSongs());

playlist.ShuffleSongs();

Console.WriteLine("Yeni Şarkı ");
Console.WriteLine(playlist.GetSongs());

NotePadService notepadService = new NotePadService();
notepadService.WriteToNotepad(playlist);