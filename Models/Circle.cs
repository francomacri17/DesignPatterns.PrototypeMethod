// Concrete prototype implementation for Circle
public class Circle : IShape
{
    public int Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius;
    }

    // Copy constructor
    public Circle(Circle source)
    {
        Radius = source.Radius;
    }

    public void Render()
    {
        Console.WriteLine($"Rendering Circle [Radius: {Radius}]");
    }

    public IShape Clone()
    {
        return new Circle(this);
    }
}