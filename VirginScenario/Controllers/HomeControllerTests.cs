namespace Presentation.Controllers
{    
    using Moq.AutoMock;
    using NUnit.Framework;
    using Application.Scenarios.Queries.GetScenarioList;

    [TestFixture]
        public class HomeControllerTests
        {
            private HomeController _controller;
            private AutoMocker _mocker;
            private ScenarioSummaryModel _model;

        [SetUp]
        public void SetUp()
        {
            _model = new ScenarioSummaryModel();

            _mocker = new AutoMocker();

            _mocker.GetMock<IGetScenarioSummary>()
                .Setup(p => p.Execute())
                .Returns(new List<ScenarioSummaryModel> { _model });

            _controller = _mocker.CreateInstance<HomeController>();
        }

        [Test]
        public void TestGetIndexShouldReturnListOfScenarios()
        {
            var viewResult = _controller.Index();

            var result =  viewResult.Model==null? new List<ScenarioSummaryModel>(): (List<ScenarioSummaryModel>)viewResult.Model;

            Assert.That(result.Single(), Is.EqualTo(_model));
        }
    }
    }

