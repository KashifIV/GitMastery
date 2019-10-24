using System.Collections.Generic; 
namespace CPP{
public class ComparisonNode : Node{
    ExpressionNode left, right; 
    public ComparisonNode(Node parent, List<Node> child, ExpressionNode expression1, ExpressionNode expression2)
        :base(parent, child, TokenType.Comparison)
    {
        left = expression1; 
        right = expression2; 
    }
    public override bool IsValid(Node node){
        if (node is ComparisonNode){
            ComparisonNode realNode = (ComparisonNode)node; 
            if ((left.IsValid(realNode.left) && right.IsValid(realNode.right)) || (left.IsValid(realNode.right) && right.IsValid(realNode.left))){
                return true; 
            }
            else return false; 
        }
        else return false; 
    }
}
}
