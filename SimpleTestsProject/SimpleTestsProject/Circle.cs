namespace SimpleTestsProject
{

    public class Circle
    {        
        public int Radius { get; set; }
        public Point Center { get; set; }

        public double GetSquare()
        {
            var result = 3.14 * Radius * Radius;
            return result;
        }

        public double GetLength()
        {
            var result = 2 * 3.1 * Radius;
            return result;
        }

        public double GetSectorSquare(float angle)
        {
            var result = 3.14 * Radius * Radius 
                         * (angle / 360);
            return result;
        }

        public Circle(Point center, int radius)
        {
            Radius = radius;
            Center = center;
        }
    }
}