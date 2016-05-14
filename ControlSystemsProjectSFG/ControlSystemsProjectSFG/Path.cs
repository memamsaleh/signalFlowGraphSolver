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
        Node start;
        Node end;
        string name = "";
        int id;

        public Node Start
        {
            get { return start; }
            set { start = value; }
        }

        public Node End
        {
            get { return end; }
            set { end = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Path(Node st, Node ep, int id)
        {
            this.start = st;
            this.end = ep;
            this.name = "g" + id;
            this.id = id;
        }

        public void Draw(Graphics g)
        {
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(10, 10);
            Pen pen = new Pen(Color.Blue, 2);
            //pen.StartCap = LineCap.RoundAnchor;
            pen.CustomEndCap = bigArrow;
            if (end.Center.X > start.Center.X)
            {
                g.DrawLine(pen, start.Center, end.Center);
                g.DrawString(name, new Font(new FontFamily("Arial"), 12), Brushes.Black, new PointF(((start.Center.X + end.Center.X) / 2), ((start.Center.Y + end.Center.Y) / 2) + 10));
            }
            else if (end.Center.X < start.Center.X)
            {
                g.DrawBezier(pen, start.Center, new Point(start.Center.X, start.Center.Y - 100), new Point(end.Center.X, end.Center.Y - 100), end.Center);
                g.DrawString(name, new Font(new FontFamily("Arial"), 12), Brushes.Black, new PointF(((start.Center.X + end.Center.X) / 2), ((start.Center.Y + end.Center.Y) / 2) - 70));
            }
            else
            {
                g.DrawEllipse(pen, start.Center.X + 30, start.Center.Y, -30, -30);
                g.DrawString(name, new Font(new FontFamily("Arial"), 12), Brushes.Black, new PointF(((start.Center.X + end.Center.X) / 2), ((start.Center.Y + end.Center.Y) / 2) - 50));
            }
        }
    }
}
