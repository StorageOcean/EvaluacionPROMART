using System;

namespace SpotifyApp.BusinessEntities
{
    public class SpotifyPlayListBE 
    {
        public int IdList { get; set; }
        public string Titulo { get; set; }
        public string Album { get; set; }
        public string Artista { get; set; }
        public TimeSpan Duracion { get; set; }
    }
}
