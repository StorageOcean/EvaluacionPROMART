using Microsoft.AspNetCore.Mvc;
using SpotifyApp.BusinessEntities;
using SpotifyApp.BusinessLogic.Interface;
using System.Collections.Generic;

namespace SpotifyAppApiRest.Controllers
{
    [Route("api/v1/Spotify")]
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiController]
    public class SpotifyPlayController : Controller
    {
        private IRepositorySpotifyPlayListBL<SpotifyPlayListBE> repositorySpotifyPlayListBL;

        public SpotifyPlayController(IRepositorySpotifyPlayListBL<SpotifyPlayListBE> repositorySpotifyPlayList)
        {
            this.repositorySpotifyPlayListBL = repositorySpotifyPlayList;
        }

        // GET api/v1/Spotify
        [HttpGet]
        public JsonResult Get()
        {
            List<SpotifyPlayListBE> lista = repositorySpotifyPlayListBL.GetAllSpotifyPlayList(); ;
            return Json(lista);
        }

        // GET api/v1/Spotify/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            SpotifyPlayListBE entity = new SpotifyPlayListBE
            {
                IdList = id
            };
            SpotifyPlayListBE entityResult = repositorySpotifyPlayListBL.GetByIdSpotifyPlayList(entity); ;
            return Json(entityResult);
        }

        // POST api/v1/Spotify
        [HttpPost]
        public ActionResult Post([FromBody] SpotifyPlayListBE spotifyPlayListBE)
        {
            ResponseEntity responseEntity = repositorySpotifyPlayListBL.InsertSpotifyPlayList(spotifyPlayListBE);
            return Json(responseEntity);
        }

        // PUT api/v1/Spotify/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] SpotifyPlayListBE spotifyPlayListBE)
        {
            spotifyPlayListBE.IdList = id;
            ResponseEntity responseEntity = repositorySpotifyPlayListBL.UpdateSpotifyPlayList(spotifyPlayListBE);
            return Json(responseEntity);
        }

        // DELETE api/v1/Spotify/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            SpotifyPlayListBE entity = new SpotifyPlayListBE
            {
                IdList = id
            };
            ResponseEntity responseEntity = repositorySpotifyPlayListBL.DeleteSpotifyPlayList(entity);
            return Json(responseEntity);
        }
    }
}
