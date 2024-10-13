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
    public class UltrazvucniAlarmController : ApiController
    {

        // GET api/ultrazvucnialarm
        public List<UltrazvucniAlarmView> Get()
        {
            DataProvider provider = new DataProvider();

            List<UltrazvucniAlarmView> alarm = provider.GetUltrazvucneAlarme();

            return alarm;
        }

        // GET api/ultrazvucnialarm/5
        public UltrazvucniAlarmView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetUltrazvucniAlarmView(id);
        }

        // POST api/ultrazvucnialarm
        public int Post([FromBody]UltrazvucniAlarm v)
        {
            DataProvider provider = new DataProvider();

            return provider.AddUltrazvucniAlarm(v);
        }

        // PUT api/ultrazvucnialarm/5
        public void Put(int id, [FromBody]UltrazvucniAlarm v)
        {
            DataProvider provider = new DataProvider();

            provider.UpdateUltrazvucniAlarm(id, v);

            return;
        }

        // DELETE api/ultrazvucnialarm/5
        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveUltrazvucniAlarm(id);
        }

    }
}
