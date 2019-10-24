using System.Collections.Generic; 
namespace CPP{
public class Node{
    public Node Parent {get;set;}
    public List<Node> children; 
    public TokenType Value {get;} 
    public bool Visited {get;set;}

    public Node(Node parent, List<Node> child, TokenType value){
        Parent = parent; 
        children = child; 
        Value = value; 
        Visited = false; 
    }
    public virtual bool IsValid(Node node){
        return node.Value == this.Value;
    }
}
}