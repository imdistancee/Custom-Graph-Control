using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GraphControl
{

    public class Graph : Panel
    {
        public enum LineType : int
        {
            CURVE = 0,
            LINE = 1
        }

        private List<Point> graphPoints;
        public Color graphColor { get; set; } = Color.Green;
        public LineType lineType { get; set; } = LineType.CURVE;
        public int lineSize { get; set; } = 2;

        public Graph()
        {
            this.DoubleBuffered = true;
            graphPoints = new List<Point>();

            this.Paint += Graph_Paint;
        }

        public void AddPoint(int x, int y)
        {
            graphPoints.Add(new Point(x, y));
        }

        private void Graph_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (graphPoints.Count > 1)
            {
                switch (lineType)
                {
                    case LineType.CURVE:
                        graphics.DrawCurve(new Pen(new SolidBrush(graphColor), lineSize), graphPoints.ToArray());
                        break;
                    case LineType.LINE:
                        graphics.DrawLines(new Pen(new SolidBrush(graphColor), lineSize), graphPoints.ToArray());
                        break;
                }

            }
        }
    }
}
