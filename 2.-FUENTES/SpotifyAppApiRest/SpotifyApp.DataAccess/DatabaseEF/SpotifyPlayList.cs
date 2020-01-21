using System;
using System.Collections.Generic;

namespace SpotifyAppApiRest
{
    public partial class SpotifyPlayList
    {
        public int IdList { get; set; }
        public string Titulo { get; set; }
        public string Album { get; set; }
        public string Artista { get; set; }
        public TimeSpan Duracion { get; set; }
    }
}
