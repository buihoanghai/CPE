using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPE_vs1
{
    public class XMLNode
    {

        public string TagName;
        public List<XMLNode> Children;
        public void recursively(XMLNode Node, XMLNode ParrentNode)
        {
            Console.WriteLine(Node.ToString());
            if (Node.Children.Count == 0)
            {
                int iC = ParrentNode.Children.IndexOf(Node);
                if (iC < (ParrentNode.Children.Count - 1))
                {
                    recursively(ParrentNode.Children[iC], ParrentNode);
                }
            }
            else
                recursively(Node.Children[0], Node);
        }
    }

}
