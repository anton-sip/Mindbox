using Mindbox.Geometry;
using Mindbox.Geometry.Figure;
using Mindbox.Interfaces;

namespace MindBox.Geometry.Test;

public class TriangleTest
{
    private const double Epsillon = Constants.Epsillon;
        
    [SetUp]
    public void Setup()
    {
    }
    
    [TestCase(3, 5, 4)]
    public void Triangle_SquareValue(double sideA, double sideB, double sideC)
    {
        IFigure figure = new Triangle(sideA, sideB, sideC);
        double p = (sideA + sideB + sideC) / 2;
        double square =  Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        Assert.That(figure.Square - square,Is.LessThan(Epsillon), "Ошибка в вычислениях площади");
    }
    
    [TestCase(-1, 1, 1)]
    [TestCase(1, -1, 1)]
    [TestCase(1, 1, -1)]
    [TestCase(0, 0, 0)]
    [TestCase(8, 2, 3)]
    public void Triangle_WrongSideArgument(double sideA, double sideB, double sideC)
    {
        Assert.Catch<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [TestCase(3,4,3, ExpectedResult = false)]
    [TestCase(3,4,5, ExpectedResult = true)]
    public bool Triangle_CheckRight(double sideA, double sideB, double sideC)
    {
        ITriangle figure = new Triangle(sideA, sideB, sideC);
        return figure.IsRightTriangle(Epsillon);
    }
}