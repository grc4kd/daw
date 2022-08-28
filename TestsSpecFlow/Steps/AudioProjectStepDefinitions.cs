using System.Diagnostics;
using DigitalAudioWorkstation;
using NUnit.Framework;

namespace TestsSpecFlow.Steps;

[Binding]
public sealed class AudioProjectStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;

    private AudioProject _project = null!;

    public AudioProjectStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }
    
    [Given(@"a new project is created")]
    public void GivenANewProjectIsCreated()
    {
        _project = new AudioProject();
    }
    
    [When(@"a new project is created")]
    public void WhenANewProjectIsCreated()
    {
        _project = new AudioProject();
    }

    [When(@"the project name is changed to ""(.*)""")]
    public void WhenTheProjectNameIsChangedTo(string p0)
    {
        _project.Name = p0;
    }
    
    [Then(@"the project name should be ""(.*)""")]
    public void ThenTheProjectNameShouldBe(string @default)
    {
        Assert.AreEqual(@default, _project.Name);
    }

    [When(@"the project website is changed to ""(.*)""")]
    public void WhenTheProjectWebsiteIsChangedTo(string p0)
    {
        _project.Website = p0;
    }

    [Then(@"the project website should be ""(.*)""")]
    public void ThenTheProjectWebsiteShouldBe(string p0)
    {
        Assert.AreEqual(p0, _project.Website);
    }
}