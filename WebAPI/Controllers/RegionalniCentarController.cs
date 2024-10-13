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
    public class RegionalniCentarController : ApiController
    {

        // GET api/regionalnicentar
        public List<RegionalniCentarView> Get()
        {
            DataProvider provider = new DataProvider();

            List<RegionalniCentarView> centri = provider.GetRegionalneCentre();

            return centri;
        }

        // GET api/regionalnicentar/5
        public RegionalniCentarView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetRegionalniCentarView(id);
        }

        // POST api/regionalnicentar
        public int Post([FromBody]RegionalniCentar v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddRegionalniCentar(v);
        }

        // PUT api/regionalnicentar/5
        public void Put(int id, [FromBody]RegionalniCentar v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateRegionalniCentar(id, v);

            return;
        }

        // DELETE api/regionalnicentar/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveRegionalniCentar(id);
        }

    }
}
