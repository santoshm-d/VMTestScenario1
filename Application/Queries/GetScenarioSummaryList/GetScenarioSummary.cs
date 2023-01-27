using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Scenarios.Queries.GetScenarioList
{
    public class GetScenarioSummary : IGetScenarioSummary
    {
        private IReadXmlScenario _readXmlScenario;

        public GetScenarioSummary(IReadXmlScenario readXmlScenario)
        {
            _readXmlScenario = readXmlScenario;
        }

        public List<ScenarioSummaryModel> Execute()
        {
            var scenarios = _readXmlScenario.ReadXmlScenarios();

            var summary = from list in scenarios
                          group list by list.ScenarioName
                          into grp
                          select new ScenarioSummaryModel() 
                          { ScenarioName = grp.Key, Detail = grp.ToList() };

            return summary.ToList();
        }
    }
}
