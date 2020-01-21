using SpotifyApp.BusinessEntities;
using SpotifyApp.DataAccess.Interface;
using SpotifyAppApiRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpotifyApp.DataAccess.Repositorio
{
    public class RepositorySpotifyPlayListDA : IRepositorySpotifyPlayListDA<SpotifyPlayListBE>
    {

        private readonly SpotifyAppBDContext _contexto;


        public RepositorySpotifyPlayListDA(SpotifyAppBDContext contexto)
        {

            this._contexto = contexto;
        }

        public List<SpotifyPlayListBE> GetAllSpotifyPlayList()
        {
            List<SpotifyPlayListBE> lista = _contexto.SpotifyPlayList.Select(x => new SpotifyPlayListBE
            {
                IdList = x.IdList,
                Titulo = x.Titulo,
                Album = x.Album,
                Artista = x.Artista,
                Duracion = x.Duracion
            }).ToList();
            return lista;
        }

        public SpotifyPlayListBE GetByIdSpotifyPlayList(SpotifyPlayListBE playListBE)
        {
            SpotifyPlayListBE entity = _contexto.SpotifyPlayList.Select(x => new SpotifyPlayListBE
            {
                IdList = x.IdList,
                Titulo = x.Titulo,
                Album = x.Album,
                Artista = x.Artista,
                Duracion = x.Duracion
            }).Where(t => t.IdList == playListBE.IdList).FirstOrDefault();
            return entity;
        }

        public ResponseEntity InsertSpotifyPlayList(SpotifyPlayListBE playListBE)
        {
            ResponseEntity response;
            try
            {
                var entity = new SpotifyPlayList
                {
                    IdList = playListBE.IdList,
                    Titulo = playListBE.Titulo,
                    Album = playListBE.Album,
                    Artista = playListBE.Artista,
                    Duracion = playListBE.Duracion,
                };

                _contexto.SpotifyPlayList.Add(entity);
                _contexto.SaveChanges();

                response = new ResponseEntity
                {
                    Message = "Inserccion Correcta",
                    Status = true,
                    Date = DateTime.Now
                };
            }
            catch (Exception ex)
            {

                response = new ResponseEntity
                {
                    Message = ex.Message,
                    Status = false,
                    Date = DateTime.Now
                };
            }
            return response;
        }

        public ResponseEntity UpdateSpotifyPlayList(SpotifyPlayListBE playListBE)
        {
            ResponseEntity response;
            try
            {
                var entity = new SpotifyPlayList
                {
                    IdList = playListBE.IdList,
                    Titulo = playListBE.Titulo,
                    Album = playListBE.Album,
                    Artista = playListBE.Artista,
                    Duracion = playListBE.Duracion,
                };
                _contexto.SpotifyPlayList.Update(entity);
                _contexto.SaveChanges();

                response = new ResponseEntity
                {
                    Message = "Actualizacion Correcta",
                    Status = true,
                    Date = DateTime.Now
                };
            }
            catch (Exception ex)
            {

                response = new ResponseEntity
                {
                    Message = ex.Message,
                    Status = false,
                    Date = DateTime.Now
                };
            }
            return response;
        }

        public ResponseEntity DeleteSpotifyPlayList(SpotifyPlayListBE playListBE)
        {
            ResponseEntity response;
            try
            {
                var entity = new SpotifyPlayList
                {
                    IdList = playListBE.IdList
                };

                _contexto.SpotifyPlayList.Remove(entity);
                _contexto.SaveChanges();

                response = new ResponseEntity
                {
                    Message = "Eliminacion Correcta",
                    Status = true,
                    Date = DateTime.Now
                };
            }
            catch (Exception ex)
            {
                response = new ResponseEntity
                {
                    Message = ex.Message,
                    Status = false,
                    Date = DateTime.Now
                };
            }
            return response;
        }
    }
}
