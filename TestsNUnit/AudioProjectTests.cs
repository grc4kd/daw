namespace TestsNUnit;

public class AudioProjectTests
{
    [Test]
    public void CreateProjectTest()
    {
        var sut = new AudioProject();
        Assert.That(sut.Name, Is.EqualTo("defaultProject"));
    }
    
    [Test]
    public void ChangeProjectNameTest()
    {
        var sut = new AudioProject();
        const string name = "project eagle"; 
        sut.Name = name;
        Assert.That(sut.Name, Is.EqualTo(name));
    }

    [Test]
    public void ChangeProjectWebsiteTest()
    {
        var sut = new AudioProject();
        const string website = "https://www.kumc.edu/project-eagle.html";
        sut.Website = website;
        Assert.That(sut.Website, Is.EqualTo(website));
    }
}