namespace POCCSharpSonar;

[TestFixture]
public class SomarTest
{
    [Test]
    public void Test1()
    {
        Somar somar = new Somar();
        Assert.That(somar.Soma(1, 1), Is.EqualTo(2));
    }
}