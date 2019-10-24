using System.Collections.Generic; 
namespace CPP{
public class VariableNode : Node{
    public string VariableName {get;}
    public VariableNode(Node parent, List<Node> child, string id)
        :base(parent, child, TokenType.Variable)
    {
        VariableName = id; 
    }
}
}