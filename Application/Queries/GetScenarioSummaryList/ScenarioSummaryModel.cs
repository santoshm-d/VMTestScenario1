using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Scenarios.Queries.GetScenarioList
{
    //As the input is a scenario list and UI needs to represent a summary , I picked up scenario name
    //The data has quite a lot of duplicates, once the need of input is identified we can display a summary of duplicates or summary based on userid
    // Tests have not been added
    public class ScenarioSummaryModel
    {
        public string ScenarioName { get; set; }
        public List<SummaryDetailModel> Detail { get; set; }
       
    }

    public class SummaryDetailModel
    {
        public string ScenarioName { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string UserId { get; set; }
        public System.DateTime SampleDate { get; set; }
        public string CreationDate { get; set; }
        public byte NumMonths { get; set; }
        public byte MarketId { get; set; }
        public byte NetworkLayerId { get; set; }
    }
}
