// Client code
public class Program
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(20, 10);
        rectangle.Render();
        IShape clonedRectangle = rectangle.Clone();
        clonedRectangle.Render();

        Circle circle = new Circle(15);
        circle.Render();
        IShape clonedCircle = circle.Clone();
        clonedCircle.Render();
    }
}