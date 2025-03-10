
namespace PhyllotaxisDistribution.src
{
    public static class Phyllotaxis
    {
        public const int MAX_SAMPLES = 1000;
        public const double SEPARATION = 0.5;
        public const double GOLDEN_ANGLE = 137.5f;
        public const double DEG_TO_RAD = (Math.PI * 2) / 360;
        

        public static List<Point> Distribution(int samples = MAX_SAMPLES, double separation = SEPARATION, double angle = GOLDEN_ANGLE)
        {
            List<Point> points = new List<Point>();
            angle = angle * DEG_TO_RAD;

            for (int i = 0; i < samples; i++)
            {
                double angleIncrement = i * angle;
                double radius = separation * Math.Sqrt(i);

                double x = radius * Math.Cos(angleIncrement);
                double y = radius * Math.Sin(angleIncrement);

                points.Add(new Point(x, y));
            }

            return points;
        }
    }
}
