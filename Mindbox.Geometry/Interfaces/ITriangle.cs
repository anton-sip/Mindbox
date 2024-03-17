namespace Mindbox.Interfaces;

public interface ITriangle : IFigure
{
    public double SideA { get; init; }
    public double SideB { get; init; }
    public double SideC { get; init; }
    public double Perimetr { get; init; }
    public bool IsRightTriangle(double epsillon = 1e-3);
}