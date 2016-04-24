using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ControlSystemsProjectSFG
{
    class Node
    {
        string name = "";
        int id;
        Point position;
        Point center;
        bool moved = false;
        Brush brush;
        List<Node> ins;
        List<Node> outs;
        public bool isVisited = false;

        public List<Node> Ins
        {
            get { return ins; }
        }

        public List<Node> Outs
        {
            get { return outs; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Brush Color
        {
            get { return brush; }
            set { brush = value; }
        }

        private Point Position
        {
            get
            {
                if (moved)
                {
                    position = new Point(center.X - 5, center.Y - 5);
                    return position;
                }
                return position;
            }
        }

        public Point Center
        {
            get { return center; }
        }

        public Node(Point center, int id)
        {
            this.center = center;
            this.brush = Brushes.Blue;
            this.id = id;
            Name = "Node " + id;
            this.position = new Point(center.X - 5, center.Y - 5);
            ins = new List<Node>();
            outs = new List<Node>();
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(brush, Position.X, Position.Y, 10, 10);
            g.DrawString(name, new Font(new FontFamily("Arial"), 12), Brushes.Black, new PointF(Position.X, Position.Y + 12));
        }

        public bool Contains(Point p)
        {
            double distance = Math.Sqrt(Math.Pow(p.X - center.X, 2) + Math.Pow(p.Y - center.Y, 2));
            return distance < 5;
        }

        public void addIn(Node n)
        {
            ins.Add(n);
        }

        public void addOut(Node n)
        {
            outs.Add(n);
        }

    }
}
