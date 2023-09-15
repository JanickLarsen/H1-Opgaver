using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Playlisten
{
    internal class Program
    {
        static void Main()
        {
            // song playlist from youtube
            Playlist ytPlaylist = new Playlist("the winner");
            ytPlaylist.Songs.AddLast(new Song("Jansa", "Never lose", 180));
            ytPlaylist.Songs.AddLast(new Song("CaptainSparklez", "Revenge", 241));
            ytPlaylist.Songs.AddLast(new Song("BebopVox WOGSCAST", "Don't Mine At Night", 248));

            // songs from 2 films "piger i trøjen 2" and "piger til søs"
            Playlist ytMusicPlaylist = new Playlist("Gammle Gode sange");
            ytMusicPlaylist.Songs.AddFirst(new Song("Piger til søs (1977)", "Knalde Kalle", 120));
            ytMusicPlaylist.Songs.AddFirst(new Song("Piger i trøjen 2 (1976)", "Kompagniets største kvaj", 132));
            ytMusicPlaylist.Songs.AddFirst(new Song("Piger i trøjen 2 (1976)", "Anita", 96));
        }
    }
}
