using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ControlSystemsProjectSFG
{
    class Path
    {
        Point start;
        Point end;
        string name = "";
        int id;

        public Point Start
        {
            get { return start; }
            set { start = value; }
        }

        public Point End
        {
            get { return end; }
            set { end = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Path(Point st, Point ep, int id)
        {
            this.start = st;
            this.end = ep;
            this.name = "g" + id;
            this.id = id;
        }

        public void Draw(Graphics g)
        {
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
            Pen pen = new Pen(Color.Blue, 1);
            //pen.StartCap = LineCap.RoundAnchor;
            pen.CustomEndCap = bigArrow;
            if (end.X > start.X)
            {
                g.DrawLine(pen, start, end);
                g.DrawString(name, new Font(new FontFamily("Arial"), 12), Brushes.Black, new PointF(((start.X + end.X) / 2), ((start.Y + end.Y) / 2) + 10));
            }
            else if (end.X < start.X)
            {
                g.DrawBezier(pen, start, new Point(start.X, start.Y - 100), new Point(end.X, end.Y - 100), end);
                g.DrawString(name, new Font(new FontFamily("Arial"), 12), Brushes.Black, new PointF(((start.X + end.X) / 2), ((start.Y + end.Y) / 2) - 70));
            }
            else
            {
                g.DrawEllipse(pen, start.X, start.Y, -10, -10);
                g.DrawString(name, new Font(new FontFamily("Arial"), 12), Brushes.Black, new PointF(((start.X + end.X) / 2), ((start.Y + end.Y) / 2) - 12));
            }
        }
    }
}
