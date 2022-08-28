using Autofac.Extras.Moq;
using DigitalAudioWorkstation;

namespace TestsNUnit;

public class AudioProjectTests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void CreateProjectTest()
    {
        using (var mock = AutoMock.GetLoose())
        {
            var sut = mock.Create<AudioProject>();
            Assert.That(sut.Name, Is.EqualTo("defaultProject"));
        }
    }
}