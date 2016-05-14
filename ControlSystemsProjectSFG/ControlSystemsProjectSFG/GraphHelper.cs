using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystemsProjectSFG
{
    class GraphHelper
    {
        Stack<Node> s = new Stack<Node>();
        List<List<Node>> forwardPaths = new List<List<Node>>();
        List<List<Node>> loops = new List<List<Node>>();
        Dictionary<string, Node> loopsHash = new Dictionary<string, Node>();

        public void DFS(Node start, Node end, Node root, bool isLoop)
        {
            if (start == end && s.Count != 0)
            {
                AddPath(root, isLoop);

                s.Pop().isVisited = false;
                return;
            }
            else if (start.Outs.Count == 0)
            {
                if (s.Count != 0)
                    s.Pop().isVisited = false;
                return;
            }
            else
            {
                foreach (Node n in start.Outs)
                {
                    if (!n.isVisited)
                    {
                        n.isVisited = true;
                        s.Push(n);
                        DFS(n, end, root, isLoop);
                    }
                }
                if (s.Count != 0)
                    s.Pop().isVisited = false;
            }

        }

        private void AddPath(Node root, bool isLoop)
        {
            List<Node> temp = new List<Node>();
            for (int i = 0; i < s.Count; i++)
            {
                temp.Add(s.ElementAt(i));
            }
            temp.Add(root);
            temp.Reverse();
            if (!isLoop)
                forwardPaths.Add(temp);
            else
                loops.Add(temp);
        }

        public List<List<Node>> CalculatePath(Node start, Node end)
        {
            DFS(start, end, start, false);
            return forwardPaths;
        }

        public List<List<Node>> CalculateLoops(List<Node> allNodes)
        {
            foreach (Node n in allNodes)
            {
                DFS(n, n, n, true);
                n.isVisited = true;
            }

            foreach (Node n in allNodes)
                n.isVisited = false;

            return loops;
        }

        public string CalculateGain(List<Path> p)
        {
            string temp = "";
            if (p != null && !(p.Count == 0))
            {
                temp += "(";
                foreach (Path y in p)
                {
                    temp += y.Name + ".";
                }
                temp = temp.Substring(0, temp.Length - 1);
                temp += ")";
            }
            return temp;
        }


        public List<Path> NodesToEdges(List<Node> nodes, List<Path> paths)
        {
            List<Path> path = new List<Path>();
            for (int i = 0; i < nodes.Count; i++)
            {
                foreach (Path p in paths)
                {
                    if (i + 1 >= nodes.Count)
                        break;
                    if (p.Start.Center == nodes[i].Center && p.End.Center == nodes[i + 1].Center)
                        path.Add(p);
                }
            }

            return path;
        }

        public bool IsNonTouching(List<Node> a, List<Node> b)
        {

            foreach (Node n in a)
            {
                foreach (Node m in b)
                {
                    if (n == m)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool IsNonTouching(Dictionary<string, Node> a, List<Node> b)
        {
            foreach (Node n in b)
            {
                if (a.ContainsKey(n.Name))
                {
                    return false;
                }
            }
            return true;
        }

        public void CalculateNonTouching(LoopData loopData)
        {
            int max = loopData.Size;
            for (int i = 2; i < max; i++)
            {
                int asd = loopData.getNonTouching(i - 1).Count;
                for (int j = 0; j < loopData.getNonTouching(i - 1).Count; j++)
                {
                    List<List<Node>> temploops = new List<List<Node>>();
                    loopsHash.Clear();
                    foreach (List<Node> loop in loopData.getNonTouchingat(i - 1, j))
                    {
                        temploops.Add(loop);
                        foreach (Node n in loop)
                        {
                            if(!loopsHash.ContainsKey(n.Name))
                                loopsHash.Add(n.Name, n);
                        }
                    }

                    int k = 0;
                    if (i == 2)
                        k = j + 1;

                    List<List<Node>> cachedloop = new List<List<Node>>();
                    foreach (List<Node> loop in temploops)
                    {
                        cachedloop.Add(loop);
                    }

                    for (; k < loopData.getNonTouching(1).Count; k++)
                    {
                        if (IsNonTouching(loopsHash, loopData.getLoop(i - 1, k, 0)))
                        {
                            temploops.Add(loopData.getLoop(i - 1, k, 0));
                            loopData.addNonTouching(i, temploops);
                        }
                        if (temploops.Count == i)
                        {
                            temploops = new List<List<Node>>();
                            foreach (List<Node> loop in cachedloop)
                            {
                                temploops.Add(loop);
                            }
                        }
                    }
                }
            }

            removeDuplicates(loopData);
        }

        public bool similarLoops(List<Node> a, List<Node> b)
        {
            foreach(Node n in a)
            {
                bool match = false;
                foreach (Node m in b)
                {
                    if(n.Name.Equals(m.Name))
                    {
                        match = true;
                    }

                }
                if (!match)
                    return false;
            }
            return true;
        }

        public bool similarListLopps(List<List<Node>> a, List<List<Node>> b)
        {
            foreach(List<Node> ln in a)
            {
                bool match = false;
                foreach(List<Node> lm in b)
                {
                    if (similarLoops(ln, lm))
                        match = true;
                }
                if (!match)
                    return false;
            }
            return true;
        }

        public void removeDuplicates(LoopData ld)
        {
            int max = ld.Size;
            for (int i = 3; i < max; i++)
            {
                for (int j = 0; j < ld.getNonTouching(i).Count; j++)
                {
                    for(int k = j + 1; k < ld.getNonTouching(i).Count; k++)
                    {
                        if(similarListLopps(ld.getNonTouchingat(i,j), ld.getNonTouchingat(i,k)))
                        {
                            ld.getNonTouching(i).RemoveAt(k);
                            k--;
                        }
                    }
                }
            }
        }

        public string CalculateDelta(LoopData ld, List<Path> paths)
        {
            string delta = " 1 ";
            for(int i = 1; i < ld.Size; i++)
            {
                if (i % 2 != 0)
                    delta += "- ( ";
                else
                    delta += "+ ( ";
                foreach(List<List<Node>> lln in ld.getNonTouching(i))
                {
                    foreach(List<Node> loop in lln)
                    {
                        delta += CalculateGain(NodesToEdges(loop, paths));
                    }
                    delta += " + ";
                }
                if (delta.EndsWith(" + "));
                    delta = delta.Substring(0, delta.Length - 3);
                delta += " ) ";
            }
            return delta;
        }

        public string CalculateTransferFunction(LoopData ld, List<Path> paths, List<List<Node>> fpaths)
        {
            string tf = "";
            foreach(List<Node> path in fpaths)
            {
                tf += CalculateGain(NodesToEdges(path, paths));
                tf += " ( 1 ";
                for (int i = 1; i < ld.Size; i++)
                {
                    string temp = "";
                    int count = 0;
                    foreach (List<List<Node>> lln in ld.getNonTouching(i))
                    {
                        bool flag = true;

                        foreach (List<Node> loop in lln)
                        {
                            if(IsNonTouching(path, loop))
                            {
                                if(flag)
                                {
                                    if (i % 2 != 0)
                                        temp += "- ( ";
                                    else
                                        temp += "+ ( ";
                                    flag = false;
                                }
                                temp += CalculateGain(NodesToEdges(loop, paths));
                                count++;
                            }
                        }
                        if(count == i)
                            tf += temp;
                    }
                    //tf = tf.Substring(0, tf.Length - 3);
                    tf += " ) ";
                }
                tf += " + ";
            }
            if (tf.EndsWith(" + "));
                tf = tf.Substring(0, tf.Length - 2);
            tf += "\n";
            tf += "______________________________\n";
            tf += " ( ";
            tf += CalculateDelta(ld, paths);
            tf += " ) ";
            return tf;
        }
    }
}
