namespace OOPSConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of shapes
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle();
            shapes[1] = new Rectangle();
            shapes[2] = new Triangle();

            // Draw each shape
            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
    
}