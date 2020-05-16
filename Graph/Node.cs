using System;
using System.Collections.Generic;
using System.Linq;

namespace Graph
{
    public class NodeIdentifier
    {
        private readonly string name;

        public NodeIdentifier(string name)
        {
            this.name = name;
        }

        public override bool Equals(object obj)
        {
            return obj is NodeIdentifier identifier &&
                   name == identifier.name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name);
        }
    }

    public interface INode
    {
        
    }

    public class Node
    {
        private Chart chart;
        private List<Node> dependencies = new List<Node>();

        private int value = 0;
        private string id;

        public Node(int value)
        {
            this.value = value;
        }

        public Node()
        {
        }

        public Node(string id)
        {
            this.id = id;
        }

        public Node(string id, Chart chart)
        {
            this.id = id;
            this.chart = chart;
        }

        public int Evaluate()
        {
            return value + dependencies.Sum(d => d.Evaluate());
        }

        public int Evaluate2()
        {

            return 0;
            //return chart.GetNode("SomeNode") + chart.GetNode("SomeNode"));
        }

        public void AddNode(Node node)
        {
            dependencies.Add(node);
        }
    }
}
