using SpotifyApp.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyApp.DataAccess.Interface
{
    public interface IRepositorySpotifyPlayListDA <T>
    {
        List<T> GetAllSpotifyPlayList();
        T GetByIdSpotifyPlayList(T t);
        ResponseEntity InsertSpotifyPlayList(T t);
        ResponseEntity UpdateSpotifyPlayList(T t);
        ResponseEntity DeleteSpotifyPlayList(T t);
    }
}
