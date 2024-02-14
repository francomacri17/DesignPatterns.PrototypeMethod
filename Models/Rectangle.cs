// Concrete prototype implementation for Rectangle
public class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    // Copy constructor
    public Rectangle(Rectangle source)
    {
        Width = source.Width;
        Height = source.Height;
    }

    public void Render()
    {
        Console.WriteLine($"Rendering Rectangle [Width: {Width}, Height: {Height}]");
    }

    public IShape Clone()
    {
        return new Rectangle(this);
    }
}