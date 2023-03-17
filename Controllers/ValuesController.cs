using BlackCoderWeatherAPICALL.Data;
using BlackCoderWeatherAPICALL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackCoderWeatherAPICALL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        ConnectionDbContext db;
        public ValuesController(ConnectionDbContext _db)
        {
                db = _db;
        }
        [HttpGet]
        public ActionResult GetData()
        {
            return Ok(db.saleData.ToList());
        }
        
    }
}
