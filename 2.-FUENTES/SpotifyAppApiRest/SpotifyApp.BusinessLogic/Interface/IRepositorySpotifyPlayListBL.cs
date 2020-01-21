using SpotifyApp.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyApp.BusinessLogic.Interface
{
    public interface IRepositorySpotifyPlayListBL<T>
    {
        List<T> GetAllSpotifyPlayList();
        T GetByIdSpotifyPlayList(T t);
        ResponseEntity InsertSpotifyPlayList(T t);
        ResponseEntity UpdateSpotifyPlayList(T t);
        ResponseEntity DeleteSpotifyPlayList(T t);
    }
}
