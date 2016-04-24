using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystemsProjectSFG
{
    class LoopData
    {
        List<List<List<Node>>>[] nonTouching;
        int size;

        public int Size
        {
            get { return size; }
        }

        public LoopData(List<List<Node>> loops)
        {
            size = loops.Count + 1;
            nonTouching = new List<List<List<Node>>>[size];
            for(int i = 0 ; i < size; i++)
            {
                nonTouching[i] = new List<List<List<Node>>>();
            }
            foreach(List<Node> loop in loops)
            {
                List<List<Node>> temp = new List<List<Node>>();
                temp.Add(loop);
                nonTouching[1].Add(temp);
            }
        }

        public void addNonTouching(int n, List<List<Node>> loops)
        {
            nonTouching[n].Add(loops);
        }

        public List<List<List<Node>>> getNonTouching(int n)
        {
            return nonTouching[n];
        }

        public List<List<Node>> getNonTouchingat(int n, int i)
        {
            return nonTouching[n].ElementAt(i);
        }

        public List<Node> getLoop(int n, int i, int j)
        {
            return nonTouching[n].ElementAt(i).ElementAt(j);
        }

        public List<string> printAll()
        {
            List<string> s = new List<string>();
            for(int i = 2; i < size; i++)
            {
                s.Add(i + " Non Touching Loops:");
                foreach(List<List<Node>> lntl in nonTouching[i])
                {
                    string temp2 = "";
                    foreach (List<Node> loop in lntl)
                    {
                        string temp = "";
                        foreach (Node n in loop)
                        {
                            temp += n.Name + "->";
                        }
                        temp = temp.Substring(0, temp.Length - 2);
                        temp2 += temp + " & ";
                    }
                    temp2 = temp2.Substring(0, temp2.Length - 3);
                    s.Add(temp2);
                }
            }
            return s;
        }
    }
}
