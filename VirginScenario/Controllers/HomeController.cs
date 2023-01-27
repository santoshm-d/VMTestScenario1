using Application.Scenarios.Queries.GetScenarioList;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetScenarioSummary _query;

        public HomeController(ILogger<HomeController> logger, IGetScenarioSummary query)
        {
            _logger = logger;
            _query = query;
        }

        public ViewResult Index()
        {
            var scenarios = _query.Execute();
           
            return View(scenarios);
        }
       
    }
}