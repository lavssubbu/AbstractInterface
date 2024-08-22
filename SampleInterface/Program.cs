namespace SampleInterface
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IShape shp = new Circle() { radius=10};//Created instance for circle class by using interface as a reference
            shp.DefaultSquare(5);
            shp.CalculateArea();                   
        }
    }
}
