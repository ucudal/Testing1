using NUnit.Framework;
using TestDateFormat;
namespace Library.Tests;

[TestFixture]
public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestearCorrecto()
    {
        var expected = "1997-11-10";
        var res = DateFormatter.ChangeFormat("10/11/1997");
        Assert.AreEqual(expected, res);
        
    }

    [Test]
    public void TestearBlanco()
    {
        var expected = "";
        var res = DateFormatter.ChangeFormat("10/11/1997");
        Assert.AreNotEqual(expected, res);
    }

     [Test]
    public void TestearFormatoIncorrecto()
    {
        var expected = "10/11/1997";
        var res = DateFormatter.ChangeFormat("10/11/1997");
        //Espero que no sea igual a lo original
        Assert.AreNotEqual(expected, res);
    }
}