using System.Drawing;

namespace WindowsFormsApp1
{
    public class Line : Shape
    {
        public Line(int x0, int y0, Graphics drawPanel, Pen drawingPen, Color fillColor) : base(x0, y0, drawPanel,
            drawingPen, fillColor)
        {
        }

        public override Point EndPoint
        {
            get => base.StartPoint;
            set
            {
                endPoint = value;
                DrawPanel.DrawLine(DrawingPen, startPoint, endPoint);
            }
        }
    }
}