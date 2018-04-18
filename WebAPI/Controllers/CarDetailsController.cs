using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNet.SignalR;
using WebAPI.Models;

using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Hubs;

namespace WebAPI.Controllers
{
    public class CarDetailsController : ApiController
    {
        // GET: api/CarDetails
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

      
        // POST: api/CarDetails
        public void Post([FromBody]string value)
        {

        }

        // PUT: api/CarDetails/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/CarDetails/5
        public void Delete(int id)
        {

        }

        [HttpGet]
        [Route("AmazingRace/UpdateTeamPositionTest")]
        public IEnumerable<CarsStock> GetAllcarDetails()
        {
            CarsStock ST = new CarsStock();
            CarsStock ST1 = new CarsStock();
            List<CarsStock> li = new List<CarsStock>();

            ST.CarName = "Maruti Waganor";
            ST.CarPrice = "4 Lakh";
            ST.CarModel = "VXI";
            ST.CarColor = "Brown";

            ST1.CarName = "Maruti Swift";
            ST1.CarPrice = "5 Lakh";
            ST1.CarModel = "VXI";
            ST1.CarColor = "RED";

            li.Add(ST);
            li.Add(ST1);
            return li;
        }

        public IEnumerable<CarsStock> Get(int id)
        {
            CarsStock ST = new CarsStock();
            CarsStock ST1 = new CarsStock();
            List<CarsStock> li = new List<CarsStock>();
            if (id == 1)
            {
                ST.CarName = "Maruti Waganor";
                ST.CarPrice = "4 Lakh";
                ST.CarModel = "VXI";
                ST.CarColor = "Brown";
                li.Add(ST);
            }
            else
            {
                ST1.CarName = "Maruti Swift";
                ST1.CarPrice = "5 Lakh";
                ST1.CarModel = "VXI";
                ST1.CarColor = "RED";
                li.Add(ST1);
            }
            return li;
        }

        [HttpPost]
        public void PostCar([FromBody] CarsStock cs)
        {

        }

        [HttpPut]
        public void Putcar(int id, [FromBody]CarsStock cs)
        {

        }

        [HttpDelete]
        public void Deletecar(int id)
        {

        }

        //[Authorize]
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("AmazingRace/UpdateTeamPosition")]
        public void PostTeamPosition([FromBody] TeamPosition position)
        {
            ////broadcast to all signalR client 
            var context = GlobalHost.ConnectionManager.GetHubContext<SignalRHub>();
            context.Clients.All.broadcast(position.eventId, position.TeamId, position.x, position.y, position.ptStpPass);

        }

    }
}
