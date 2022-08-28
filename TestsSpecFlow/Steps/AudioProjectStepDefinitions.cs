using DigitalAudioWorkstation;
using NUnit.Framework;

namespace TestsSpecFlow.Steps;

[Binding]
public sealed class AudioProjectStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;

    private AudioProject? _project;

    public AudioProjectStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }
    
    [When(@"a new project is created")]
    public void WhenANewProjectIsCreated()
    {
        _project = new AudioProject();
    }

    [Then(@"the project name should be ""(.*)""")]
    public void ThenTheProjectNameShouldBe(string @default)
    {
        Assert.NotNull(_project);
        Assert.AreEqual(@default, _project!.Name);
    }
}