using ArmyBuilder.Applications;
using ArmyBuilder.Models;
using Newtonsoft.Json;
using System.Web.Http;

namespace ArmyBuilder.Controllers
{
    [RoutePrefix("api")]
    public class ListBuilderController : ApiController
    {
        [HttpGet]
        [Route("get")]
        public string Get()
        {
            var da = new DataAccess();
            var units = da.GetUnits();
            var jsonResp = JsonConvert.SerializeObject(units);

            return jsonResp;
        }

        [HttpPost]
        [Route("add")]
        public void Add([FromBody] Unit unit)
        {
            var dal = new DataAccess();
            dal.Add(unit);
        }

        [HttpPost]
        [Route("update")]
        public void Update([FromBody] Unit unit)
        {
            var da = new DataAccess();
            da.Update(unit);
        }

        [HttpPost]
        [Route("delete")]
        public void DeleteUnit([FromBody] Unit unit)
        {
            var da = new DataAccess();;
            da.Delete(unit);
        }
    }
}