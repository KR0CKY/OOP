using System.Drawing;

namespace WindowsFormsApp1
{
    public class Rectangle : Shape
    {
        public Rectangle(int x0, int y0, Graphics drawPanel, Pen drawingPen, Color fillColor) : base(x0, y0, drawPanel,
            drawingPen, fillColor)
        {
        }

        public override Point EndPoint
        {
            get => base.StartPoint;
            set
            {
                var brush = new SolidBrush(FillColor);
                endPoint = value;
                Point MainPicture = new Point(startPoint.X, startPoint.Y);

                StartDrawPoint(ref startPoint, ref endPoint);
                DrawPanel.DrawRectangle(DrawingPen, startPoint.X, startPoint.Y, endPoint.X - startPoint.X,
                    endPoint.Y - startPoint.Y);
                DrawPanel.FillRectangle(brush, startPoint.X, startPoint.Y, endPoint.X - startPoint.X,
                    endPoint.Y - startPoint.Y);
                startPoint = MainPicture;
            }
        }
    }
}