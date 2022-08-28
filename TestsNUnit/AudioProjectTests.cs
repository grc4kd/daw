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
        const string name = "project eagle"; 
        sut.Name = name;
        Assert.That(sut.Name, Is.EqualTo(name));
    }

    [Test]
    public void ChangeProjectWebsiteTest()
    {
        using var mock = AutoMock.GetLoose();
        var sut = mock.Create<AudioProject>();
        const string website = "https://www.kumc.edu/project-eagle.html";
        sut.Website = website;
        Assert.That(sut.Website, Is.EqualTo(website));
    }
}