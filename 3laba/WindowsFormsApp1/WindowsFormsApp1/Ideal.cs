using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class Ideal : Polygon
    {
        public Ideal(int x0, int y0, Graphics drawPanel, Pen drawingPen, Color fillColor) : base(x0, y0, drawPanel,
            drawingPen, fillColor)
        {
        }
        public override Point StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }

        public override Point PreDrawEndPoint
        {
            get { return endPoint; }
            set { EndPoint = value; }
        }

        public override Point EndPoint
        {
            get => base.EndPoint;
            set
            {
                int r = (int) (endPoint.X - startPoint.X) / 2, x1, y1;
                var backColor = new SolidBrush(FillColor);
                var center = new PointF(StartPoint.X + r, startPoint.Y + r);
                double angle = Math.PI * 2 / TopAmount,
                    shiftAngle = Math.PI * (endPoint.X - startPoint.X) / (endPoint.Y - startPoint.Y) / 20;

                endPoint = value;

                for (int i = 0; i < TopAmount; i++)
                {
                    x1 = (int) (center.X + Math.Cos(i * angle + shiftAngle) * r);
                    y1 = (int) (center.Y + Math.Sin(i * angle + shiftAngle) * r);
                    points[i].X = x1;
                    points[i].Y = y1;
                }

                DrawPanel.DrawPolygon(DrawingPen, points);
                DrawPanel.FillPolygon(backColor, points);
                backColor.Dispose();
            }
        }
        protected int topAmount = 3;
        protected Point[] points = new Point[3];
        public int TopAmount
        {
            get { return topAmount; }
            set
            {
                points = new Point[value];
                topAmount = value;
            }
        }
    }
}