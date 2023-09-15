using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Playlisten
{
    /// <summary>
    /// class <>Platlist </c> represent a playlist from online
    /// </summary>
    internal class Playlist
    {

        private string _name;

        private LinkedList<Song> _songs = new LinkedList<Song>();

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public LinkedList<Song> Songs
        {
            get { return _songs; }
            set { _songs = value; }
        }
        #region constructors
        public Playlist()
        {

        }
        public Playlist(string name) : this()
        {
            _name = name;
        }
        #endregion
    }
}
