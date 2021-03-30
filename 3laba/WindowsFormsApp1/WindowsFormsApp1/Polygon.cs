using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    public class Polygon : Shape
    {
        public Polygon(int x0, int y0, Graphics drawPanel, Pen drawingPen, Color fillColor) : base(x0, y0, drawPanel,
            drawingPen, fillColor)
        {
        }

        public override Point StartPoint
        {
            get => base.StartPoint;
            set
            {
                startPoint = value;
                if ((n == 0) && (value.X > 0))
                {
                    points.AddLast(value);
                    n++;
                }
            }
        }

        public override Point PreDrawEndPoint
        {
            get => base.PreDrawEndPoint;
            set { DrawPanel.DrawLine(DrawingPen, points.ElementAt<Point>(n - 1), value); }
        }

        public override Point EndPoint
        {
            get => base.EndPoint;
            set
            {
                endPoint = value;
                points.AddLast(value);
                if (!this.EndOfCurrentFigure)
                {
                    if (n > 0)
                    {
                        DrawPanel.DrawLine(DrawingPen, points.ElementAt<Point>(n - 1),
                            points.ElementAt<Point>(n));
                    }

                    n++;
                }
                else
                {
                    var brush = new SolidBrush(FillColor);

                    n = 0;

                    DrawPanel.DrawPolygon(DrawingPen, points.ToArray());
                    DrawPanel.FillPolygon(brush, points.ToArray());
                    points.Clear();
                    brush.Dispose();
                    this.EndOfCurrentFigure = false;
                }
            }
        }
        private LinkedList<Point> points = new LinkedList<Point>();
        protected int n = 0;
    }
}