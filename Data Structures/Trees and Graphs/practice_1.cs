/*
Route Between Nodes

Given a directed graph amd twp mpdes (s) and (e).
Design an algorithm to find out whether there is a route from (s) to (e).

baaart.dev
*/

namespace Graph_Sandbox {

    public class Graph{
        public Node[] nodes;

        public Node[] getNodes(){
            return nodes;
        }
    }

    public class Node{
        public string Name;
        public STATE state;
        public Nodes[] children;

        public Nodes[] getAdjacent(){
            return children;
        }
    }

    enum STATE { Unvisited, Visited, Visiting }

    public bool HasPath(Graph g, Node start, Node end){
        if(start == end) return; // Exit if the nodes are the same.

        // BFS using Queue, store nodes that need to be searched.
        Queue<Node> q = new Queue<Node>();

        // Set all nodes to unvisited.
        foreach(var n in g.getNodes()){
            n.state = STATE.Unvisited;
        }

        // Visit start node and queue for BFS search.
        start.state = STATE.Visiting;
        q.Enqueue(start);

        Node visitingNode;
        while(!q.IsEmpty()){
            visitingNode = q.Dequeue();

            if(visitingNode != null){
                foreach (var nodeAdjacent in visitingNode.getAdjacent())
                {
                    if(nodeAdjacent.state == STATE.Unvisited){
                        if(nodeAdjacent == end) { 
                            return true;
                        } else{
                            nodeAdjacent.state = STATE.Visiting;
                            q.Enqueue(nodeAdjacent);
                        }
                    }
                }
                visitingNode.state = STATE.Visited;
            }
        }      
        return false;
    }
}
