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
    public class DetektorPokretaController : ApiController
    {

        // GET api/detektorpokreta
        public List<DetektorPokretaView> Get()
        {
            DataProvider provider = new DataProvider();

            List<DetektorPokretaView> alarm = provider.GetDetektore();

            return alarm;
        }

        // GET api/detektorpokreta/5
        public DetektorPokretaView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetDetektorPokretaView(id);
        }

        // POST api/detektorpokreta
        public int Post([FromBody]DetektorPokreta v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddDetektorPokreta(v);
        }

        // PUT api/detektorpokreta/5
        public void Put(int id, [FromBody]DetektorPokreta v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateDetektorPokreta(id, v);

            return;
        }

        // DELETE api/detektorpokreta/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveDetektorPokreta(id);
        }

    }
}
