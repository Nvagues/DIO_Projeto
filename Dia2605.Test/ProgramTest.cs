namespace Dia2605.Test;

[TestClass]
public class ProgramTest
{
    [TestMethod]
    public void SomarDeveRetornar2()
    {
        int x = 1;
        int y = 1;

        int resultado = Program.Somar(x, y);

        Assert.AreEqual(2, resultado);
    }

    [TestMethod]
    public void SomarDeveRetornar0()
    {
        int x = 0-;
        int y = 0;

        int resultado = Program.Somar(x, y);

        Assert.AreEqual(0, resultado);
    }

    [TestMethod]
    public void SomarDeveRetornar3()
    {
        int x = 1;
        int y = 2;

        int resultado = Program.Somar(x, y);

        Assert.AreEqual(3, resultado);
    }

    [TestMethod]
    public void SomarDeveRetornar3_InvertendoXeY()
    {
        int x = 99;
        int y = 1;

        int resultado = Program.Somar(x, y);

        Assert.AreEqual(3, resultado);
    }

    [TestMethod]
    public void SomarDeveRetornar1()
    {
        int x = 0;
        int y = 1;

        int resultado = Program.Somar(x, y);

        Assert.AreEqual(1, resultado);
    }
}
