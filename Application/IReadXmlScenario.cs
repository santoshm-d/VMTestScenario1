using System.Collections.Generic;
using Application.Scenarios.Queries.GetScenarioList;

namespace Application
{
    public interface IReadXmlScenario
    {
        List<SummaryDetailModel> ReadXmlScenarios();
    }
}
