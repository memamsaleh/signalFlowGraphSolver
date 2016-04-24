using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSystemsProjectSFG
{
    public partial class Form1 : Form
    {
        List<Node> nodes;
        List<Path> paths;
        Node selectedN = null;
        Path selectedP = null;
        enum state { DrawNode, DrawEdge, Edit, Clear, Neutral };
        state s = state.Neutral;
        Graphics g;
        int nid = 1;
        int pid = 1;
        Node start = null, end = null;
        Point sp;
        bool chosen = false;
        Node temp;
        GraphHelper gh = new GraphHelper();

        public Form1()
        {
            InitializeComponent();
            nodes = new List<Node>();
            paths = new List<Path>();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            foreach (Node n in nodes)
                n.Draw(g);

            foreach (Path p in paths)
                p.Draw(g);

        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            switch (s)
            {
                case state.DrawNode:
                    nodes.Add(new Node(new Point(e.X, e.Y), nid++));
                    s = state.Neutral;
                    break;
                case state.Neutral:
                    if (selectedN != null)
                        selectedN.Color = Brushes.Blue;

                    foreach(Node n in nodes)
                    {
                        if (n.Contains(new Point(e.X, e.Y)))
                        {
                            n.Color = Brushes.DarkGray;
                            selectedN = n;
                        }
                    }
                    break;
                case state.DrawEdge:
                    if (selectedN != null)
                        selectedN.Color = Brushes.Blue;

                    selectedN = null;

                    foreach (Node n in nodes)
                    {
                        if (n.Contains(new Point(e.X, e.Y)))
                        {
                            n.Color = Brushes.DarkGray;
                            selectedN = n;
                        }
                    }

                    if (!chosen && selectedN != null)
                    {
                        sp = new Point(selectedN.Center.X, selectedN.Center.Y);
                        chosen = true;
                        temp = selectedN;
                    }
                    else if(selectedN != null)
                    {
                        paths.Add(new Path(sp, new Point(selectedN.Center.X, selectedN.Center.Y), pid));
                        chosen = false;
                        pid++;
                        temp.addOut(selectedN);
                        selectedN.addIn(temp);
                    }
                    break;
            }
            Refresh();
        }

        private void AddNodeBtn_Click(object sender, EventArgs e)
        {
            s = state.DrawNode;
        }

        private void AddEdgeBtn_Click(object sender, EventArgs e)
        {
            s = state.DrawEdge;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            nodes.Remove(selectedN);
            //nid--;
            Refresh();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            s = state.Edit;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            s = state.Clear;
            s = state.Neutral;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if(selectedN != null && selectedN.Ins.Count == 0)
            {
                selectedN.Color = Brushes.Green;
                start = selectedN;
                selectedN = null;
            }
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            if (selectedN != null && selectedN.Outs.Count == 0)
            {
                selectedN.Color = Brushes.Red;
                end = selectedN;
                selectedN = null;
            }
        }

        private void SolveBtn_Click(object sender, EventArgs e)
        {
            List<List<Node>> fpaths = gh.CalculatePath(start, end);
            List<List<Node>> loops = gh.CalculateLoops(nodes);
            PrintPaths(fpaths);
            printLoops(loops);
            LoopData ld = new LoopData(loops);
            gh.CalculateNonTouching(ld);
            List<string> allS = ld.printAll();
            foreach(string s in allS)
            {
                loopsList.Items.Add(s);
            }
            string tf = gh.CalculateTransferFunction(ld, paths, fpaths);
            TFText.AppendText(tf);
        }

        private void PrintPaths(List<List<Node>> fpaths)
        {
            foreach(List<Node> path in fpaths)
            {
                string temp = "";
                foreach (Node n in path)
                {
                    temp += n.Name + "->";
                }
                temp = temp.Substring(0, temp.Length - 2);
                pathsList.Items.Add(temp);
            }
        }

        private void printLoops(List<List<Node>> loops)
        {
            foreach (List<Node> loop in loops)
            {
                string temp = "";
                foreach (Node n in loop)
                {
                    temp += n.Name + "->";
                }
                temp = temp.Substring(0, temp.Length - 2);
                loopsList.Items.Add(temp);
            }
        }

    }
}
