using System.Collections.Generic; 
namespace CPP{
public class AssignmentNode : Node{
    public Node Assigner {get;}
    public Node Evaluation {get;}

    public AssignmentNode(Node parent, List<Node> child, Node assigner, Node evaluator)
        :base(parent, child, TokenType.Assignment)
    {
        Assigner = assigner; 
        Evaluation = evaluator; 
    }
    public override bool IsValid(Node node){
        return true;
    }
}
}