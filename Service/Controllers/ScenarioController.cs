using Application.Scenarios.Queries.GetScenarioList;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScenarioController : ControllerBase
    {

        private readonly IGetScenarioSummary _query;

        public ScenarioController(IGetScenarioSummary query)
        {
            _query = query;
        }

        [HttpGet]
        //Code is not throwing any exception back to the client
        public IEnumerable<ScenarioSummaryModel>  Get()
        {
            try
            {
                return  _query.Execute();
            }
            catch ( Exception e) {
                return Enumerable.Empty<ScenarioSummaryModel>();
            }
        }
    }
}