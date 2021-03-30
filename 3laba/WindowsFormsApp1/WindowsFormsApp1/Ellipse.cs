using System.Drawing;

namespace WindowsFormsApp1
{
    public class Ellipse : Shape
    {
        public Ellipse(int x0, int y0, Graphics drawPanel, Pen drawingPen, Color fillColor) : base(x0, y0, drawPanel, drawingPen, fillColor) { }
        public override Point EndPoint
        {
            get => base.StartPoint;
            set
            {
                var brush = new SolidBrush(FillColor);
                
                endPoint = value;
                Point MainPicture = new Point(startPoint.X, startPoint.Y);
                
                StartDrawPoint(ref startPoint, ref endPoint);
                DrawPanel.DrawEllipse(DrawingPen, startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
                DrawPanel.FillEllipse(brush, startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
                startPoint = MainPicture;
                brush.Dispose();
            }
        }
    }
}