using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Playlisten
{
    /// <summary>
    /// class <c>Song</c> represent a song
    /// </summary>
    internal class Song
    {
        private string _artist;

        private string _title;

        private short _time;

        public string Artist
        {
            get { return _artist; }
            private set { _artist = value; }
        }
        public string Title
        {
            get { return _title; }
            private set { _title = value; }
        }

        public short Time
        {
            get { return _time; }
            private set { _time = value; }
        }
        #region constructors
        private Song()
        {

        }
        private Song(string artist) : this()
        {
            _artist = artist;
        }
        private Song(string artist, string title) : this(artist)
        {
            _title = title;
        }
        public Song(string artist, string title, short time) : this(artist, title)
        {
            _time = time;
        }

        #endregion
    }
}
