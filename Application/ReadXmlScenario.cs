using Application.Scenarios.Queries.GetScenarioList;
using VirginScenario.Domain;

namespace Application
{
    public class ReadXmlScenario : IReadXmlScenario
    {
        public List<SummaryDetailModel> ReadXmlScenarios()
        {
            System.Xml.Serialization.XmlSerializer reader =
                   new(typeof(Data));
            StreamReader file = new(@"..\\Data.xml");

            if (reader.Deserialize(file) is not Data scenarios) return new List<SummaryDetailModel>();
            file.Close();
            return scenarios.Scenario.Select(x => ScenarioListInputModel.MapToSummaryDetailModel(x)).ToList();

        }
    }
}
