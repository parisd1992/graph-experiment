# graph-experiment
Experimenting with TDD and C# to create a graph system


Some ideas:

flower graph

flowers = root length / root space * soil quality 

flowers = new Node(flowers)

rl  = new Node(root-length)
rs = new Node(root-space)
sq = new Node(soil-quality)

flowers.AddNode(rl)
flowers.AddNode(rs)
flowers.AddNode(sq)

flowers = flowers.Evaluate();


how do we increase root length?

rl.Evaluate { return v };
rl.v += 1;


graph is told here is 



a node is a holder of some data, e.g. a number, a function


a node is added to a chart
charts evaluate nodes - they know / keep track if nodes have changed or if they can quickly return the same value


NodeA = 5
NodeB = 2
NodeC = NodeA + NodeB


To evaluate NodeC I want to say, Graph Get Node A, Graph Get Node B, Sum.

So a Node has access to a graph getter to use it’s API

NodeD = NodeC + 1


go even simpler: a graph is told nodes and their dependencies.  If you want to calculate something you ask the graph for the nodes, then you do something with them

NodeA = 5
NodeB = 2
NodeC (deps on NodeA, NodeB)
