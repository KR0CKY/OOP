using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        LinkedList<Type> ShapesList = new LinkedList<Type>();
        Graphics paintField;
        Pen pen;
        Shape _currentShape;
        Bitmap MainPicture = new Bitmap(2000, 2000);
        private void Form1_Load(object sender, EventArgs e)
        {
            _currentShape = (Shape) Activator.CreateInstance(ShapesList.ElementAt<Type>(2), -1, -1, paintField, pen, fillColorView.BackColor);
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentShape = (Shape) Activator.CreateInstance(ShapesList.ElementAt<Type>(2), -1, -1, paintField, pen,
                fillColorView.BackColor);
            numberOfTopsLabel.Visible = false;
            numberOfTopsUpDown.Visible = false;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentShape = (Shape) Activator.CreateInstance(ShapesList.ElementAt<Type>(4), -1, -1, paintField, pen,
                fillColorView.BackColor);
            numberOfTopsLabel.Visible = false;
            numberOfTopsUpDown.Visible = false;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentShape = (Shape) Activator.CreateInstance(ShapesList.ElementAt<Type>(0), -1, -1, paintField, pen,
                fillColorView.BackColor);
            numberOfTopsLabel.Visible = false;
            numberOfTopsUpDown.Visible = false;
        }

        private void multilineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentShape = (Shape) Activator.CreateInstance(ShapesList.ElementAt<Type>(3), -1, -1, paintField, pen,
                fillColorView.BackColor);
            numberOfTopsLabel.Visible = false;
            numberOfTopsUpDown.Visible = false;
        }

        private void polygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentShape = (Shape) Activator.CreateInstance(ShapesList.ElementAt<Type>(1), -1, -1, paintField, pen,
                fillColorView.BackColor);
            numberOfTopsLabel.Visible = true;
            numberOfTopsUpDown.Visible = true;
        }

        private void PreDrawTimer_Tick(object sender, EventArgs e)
        {
            PreDrawTimer.Enabled = false;
            numberOfTopsLabel.Visible = false;
            numberOfTopsUpDown.Visible = false;
        }

        private void clearPaintButton_Click(object sender, EventArgs e)
        {
            paintField = Graphics.FromImage(MainPicture);
            paintField.Clear(pictureBox1.BackColor);
            pictureBox1.Image = MainPicture;
        }

        private void penColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                penColorView.BackColor = colorDialog1.Color;
                pen.Color = colorDialog1.Color;
            }
        }

        private void fillColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                fillColorView.BackColor = colorDialog1.Color;
                _currentShape.FillColor = colorDialog1.Color;
            }
        }
        private void penColorView_Click(object sender, EventArgs e)
        {
        }

        private void fillColorView_Click(object sender, EventArgs e)
        {
        }

        private void numberOfTopsUpDown_ValueChanged(object sender, EventArgs e)
        {
            (_currentShape as Ideal).TopAmount = (int) numberOfTopsUpDown.Value;
        }

        private void thicknessUpDown_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (int) thicknessUpDown.Value;
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _currentShape.StartPoint = new Point(e.X, e.Y);
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                paintField = Graphics.FromImage(MainPicture);
                _currentShape.DrawPanel = paintField;

                if (e.Button == MouseButtons.Right) _currentShape.EndOfCurrentFigure = true;

                _currentShape.EndPoint = new Point(e.X, e.Y);

                _currentShape.StartPoint = new Point(-2, -2);
                pictureBox1.Image = MainPicture;

            }
            catch
            {
            }
        }

        public Form1()
        {
            InitializeComponent();
            if (!StartCheck())
            {
                MessageBox.Show("Exit. Program will close.");
                Application.Exit();
            }
            paintField = Graphics.FromImage(MainPicture);
            paintField.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.Width = (int) thicknessUpDown.Value;
            pictureBox1.Image = MainPicture;
        }
        private bool StartCheck()
        {
            bool check = false;

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            
            for (int i = 0; i < types.Length; i++)
            {
                foreach (PropertyInfo pi in types[i].GetProperties())
                {
                    if ((pi.Name == "FigureName") && (pi.CanRead) && (!pi.CanWrite))
                    {
                        if (!types[i].IsAbstract)
                        {
                            ShapesList.AddLast(types[i]);
                            check = true;
                        }
                    }
                }
            }
            return check;
        }
    }
}
