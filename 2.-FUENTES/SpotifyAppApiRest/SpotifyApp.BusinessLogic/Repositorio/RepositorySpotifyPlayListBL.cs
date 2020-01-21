using SpotifyApp.BusinessEntities;
using SpotifyApp.BusinessLogic.Interface;
using SpotifyApp.DataAccess.Interface;
using System.Collections.Generic;

namespace SpotifyApp.BusinessLogic.Repositorio
{
    public class RepositorySpotifyPlayListBL : IRepositorySpotifyPlayListBL<SpotifyPlayListBE>
    {
        private IRepositorySpotifyPlayListDA<SpotifyPlayListBE> repositorySpotifyPlayListDA;

        public RepositorySpotifyPlayListBL(IRepositorySpotifyPlayListDA<SpotifyPlayListBE> repositorySpotifyPlayList)
        {
            this.repositorySpotifyPlayListDA = repositorySpotifyPlayList;
        }       

        public List<SpotifyPlayListBE> GetAllSpotifyPlayList()
        {
            return repositorySpotifyPlayListDA.GetAllSpotifyPlayList();
        }

        public SpotifyPlayListBE GetByIdSpotifyPlayList(SpotifyPlayListBE t)
        {
            return repositorySpotifyPlayListDA.GetByIdSpotifyPlayList(t);
        }

        public ResponseEntity InsertSpotifyPlayList(SpotifyPlayListBE t)
        {
            return repositorySpotifyPlayListDA.InsertSpotifyPlayList(t);
        }

        public ResponseEntity UpdateSpotifyPlayList(SpotifyPlayListBE t)
        {
            return repositorySpotifyPlayListDA.UpdateSpotifyPlayList(t);
        }

        public ResponseEntity DeleteSpotifyPlayList(SpotifyPlayListBE t)
        {
            return repositorySpotifyPlayListDA.DeleteSpotifyPlayList(t);
        }
    }
}
