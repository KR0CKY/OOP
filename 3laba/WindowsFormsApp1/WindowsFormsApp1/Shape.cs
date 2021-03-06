using System.Drawing;

namespace WindowsFormsApp1
{
    public abstract class Shape
    {
        public Graphics DrawPanel;
        protected Point startPoint;
        protected Point endPoint = new Point(-1, -1);
        public Pen DrawingPen;
        public Color FillColor;
        public bool EndOfCurrentFigure = false;

        public Shape(int x0, int y0, Graphics drawPanel, Pen drawingPen, Color fillColor)
        {
            startPoint = new Point(x0, y0);
            DrawPanel = drawPanel;
            DrawingPen = drawingPen;
            FillColor = fillColor;
        }

        public virtual Point StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }

        public virtual Point PreDrawEndPoint
        {
            get { return endPoint; }
            set { EndPoint = value; }
        }

        public virtual Point EndPoint
        {
            get { return endPoint; }
            set { endPoint = value; }
        }

        protected void StartDrawPoint(ref Point MainPicture, ref Point TemporaryImage)
        {
            int buf;
            if (TemporaryImage.X < MainPicture.X)
            {
                buf = TemporaryImage.X;
                TemporaryImage.X = MainPicture.X;
                MainPicture.X = buf;
            }

            if (TemporaryImage.Y < MainPicture.Y)
            {
                buf = TemporaryImage.Y;
                TemporaryImage.Y = MainPicture.Y;
                MainPicture.Y = buf;
            }
        }
        
        public virtual string FigureName
        {
            get
            {
                return "FigureName";
            }
        }
    }
}