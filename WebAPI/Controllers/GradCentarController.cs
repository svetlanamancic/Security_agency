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
    public class GradCentarController : ApiController
    {

        // GET api/gradcentar
        public List<GradCentarView> Get()
        {
            DataProvider provider = new DataProvider();

            List<GradCentarView> gradovi = provider.GetGradoveCentara();



            return gradovi;
        }

        // GET api/gradcentar/5
        public GradCentarView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetGradCentarView(id);
        }

        // POST api/gradcentar
        public int Post([FromBody]GradCentar v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddGradCentar(v);
        }

        // PUT api/gradcentar/5
        public void Put(int id, [FromBody]GradCentar v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateGradCentar(id, v);

            return;
        }

        // DELETE api/gradcentar/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveGradCentar(id);
        }

    }
}
