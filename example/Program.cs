using PhyllotaxisDistribution.src;

namespace PhyllotaxisDistribution.example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = Phyllotaxis.Distribution(1000);

            double[] xs = new double[points.Count];
            double[] ys = new double[points.Count];

            for (int i = 0; i < points.Count; i++)
            {
                xs[i] = points[i].x;
                ys[i] = points[i].y;
            }

            ScottPlot.Plot plot = new ScottPlot.Plot();
            plot.Add.ScatterPoints(xs, ys);

            plot.SavePng("plot.png", 500, 500);
        }
    }
}
