using Mindbox.Geometry;
using Mindbox.Geometry.Figure;
using Mindbox.Interfaces;

namespace MindBox.Geometry.Test;

public class CircleTests
{
    private const double Epsillon = Constants.Epsillon;
        
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(5)]
    [TestCase(10)]
    public void Circle_SquareValue(double radius)
    {
        IFigure circle = new Circle(radius);
        double square = Math.PI * Math.Pow(radius, 2);
        Assert.That(circle.Square - square,Is.LessThan(Epsillon), "Ошибка в вычислениях площади круга");
    }
    
    [TestCase(0)]
    [TestCase(-5.2)]
    public void Circle_WrongRadiusArgument(double radius)
    {
        Assert.Catch<ArgumentException>(() => new Circle(radius));
    }
}