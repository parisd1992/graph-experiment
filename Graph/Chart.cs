using System;
using System.Collections.Generic;

namespace Graph
{
    public class Chart
    {
        List<Node> nodes;


        public Chart()
        {
            nodes = new List<Node>();
        }

        public void AddNode(Node node)
		{
            nodes.Add(node);

		}

        public bool HasNode(Node node)
		{
            return nodes.Contains(node);
		}
    }
}
