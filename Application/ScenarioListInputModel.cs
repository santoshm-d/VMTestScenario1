using Application.Scenarios.Queries.GetScenarioList;
using VirginScenario.Domain;


namespace Application
{
    public class ScenarioListInputModel
    {
        public byte ScenarioID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string UserID { get; set; }
        public DateTime SampleDate { get; set; }
        public string CreationDate { get; set; }
        public byte NumMonths { get; set; }
        public byte MarketID { get; set; }
        public byte NetworkLayerID { get; set; }
        public static SummaryDetailModel MapToSummaryDetailModel(XMLInputSchema scenario)
        {
            return new SummaryDetailModel()
            {
                ScenarioName = string.IsNullOrEmpty(scenario.Name) ? "Scenario name is missing in source data" : scenario.Name,
                Surname = scenario.Surname,
                Forename = scenario.Forename,
                UserId = scenario.UserID,
                SampleDate = scenario.SampleDate,
                CreationDate = scenario.CreationDate,
                NumMonths = scenario.NumMonths,
                MarketId = scenario.MarketID,
                NetworkLayerId = scenario.NetworkLayerID

            };
        }
    }
}
