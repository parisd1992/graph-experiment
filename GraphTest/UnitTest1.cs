using Graph;
using NUnit.Framework;

namespace GraphTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NodeHasANameTest()
        {
            Chart chart = new Chart();

            Node nodeA = new Node("NodeA");
            Node nodeB = new Node("NodeB");
            Node nodeC = new Node("NodeC", chart);

        }



        [Test]
        public void HasNodeReturnsTrueIfNodeExistsTest()
        {
            Chart myChart = new Chart();
            Node myNode = new Node();
            myChart.AddNode(myNode);

            Assert.AreEqual(true, myChart.HasNode(myNode));
        }

        [Test]
        public void HasNodeReturnsFalseIfNodeDoesNotExistTest()
        {
            Chart myChart = new Chart();
            Node myNode = new Node();

            Assert.AreEqual(false, myChart.HasNode(myNode));
        }


        [Test]
        public void NodeCanReturnAValueTest()
        {
            Node myNode = new Node(5);

            Assert.AreEqual(5, myNode.Evaluate());
        }

        [Test]
        public void NodeDependsOnValueOfConnectedNodeTest()
        {
            Node myNode = new Node(5);
            Node myNode1 = new Node(5);

            myNode.AddNode(myNode1);
            

            Assert.AreEqual(10, myNode.Evaluate());
        }
    }
}