namespace TestsNUnit;

public class AudioProjectTests
{
    [Test]
    public void CreateProjectTest()
    {
        using var mock = AutoMock.GetLoose();
        var sut = mock.Create<AudioProject>();
        Assert.That(sut.Name, Is.EqualTo("defaultProject"));
    }
    
    [Test]
    public void ChangeProjectNameTest()
    {
        using var mock = AutoMock.GetLoose();
        var sut = mock.Create<AudioProject>();
        // DONATE: https://www.kumc.edu/project-eagle.html
        sut.Name = "project eagle";
        Assert.That(sut.Name, Is.EqualTo("project eagle"));
    }
}