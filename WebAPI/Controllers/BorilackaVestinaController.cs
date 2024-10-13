using SBP_Projekat;
using SBP_Projekat.DTOs;
using SBP_Projekat.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class BorilackaVestinaController : ApiController
    {

        // GET api/borilackavestina
        public List<BorilackaVestinaView> Get()
        {
            DataProvider provider = new DataProvider();

            List<BorilackaVestinaView> vestine = provider.GetBorilackeVestine();



            return vestine;
        }

        // GET api/borilackavestina/5
        public BorilackaVestinaView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetBorilackaVestinaView(id);
        }

        // POST api/borilackavestina
        public int Post([FromBody]BorilackaVestina v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddBorilackaVestina(v);
        }

        // PUT api/borilackabestina/5
        public void Put(int id, [FromBody]BorilackaVestina v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateBorilackaVestina(id, v);

            return;
        }

        // DELETE api/borilackavestina/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveBorilackaVestina(id);
        }

    }
}
