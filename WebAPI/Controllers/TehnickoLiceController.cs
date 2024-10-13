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
    public class TehnickoLiceController : ApiController
    {

        // GET api/tehnickolice
        public List<TehnickoLiceView> Get()
        {
            DataProvider provider = new DataProvider();

            List<TehnickoLiceView> tehnicari = provider.GetTehnicari();



            return tehnicari;
        }

        // GET api/tehnickolice/5
        public TehnickoLiceView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetTehnickoLiceView(id);
        }

        // POST api/tehnickolice
        public int Post([FromBody]TehnickoLice v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddTehnickoLice(v);
        }

        // PUT api/tehnickolice/5
        public void Put(int id, [FromBody]TehnickoLice v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateTehnickoLice(id, v);

            return;
        }

        // DELETE api/tehnickolice/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveTehnickoLice(id);
        }

    }
}
