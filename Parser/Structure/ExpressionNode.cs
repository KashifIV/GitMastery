using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic; 
namespace CPP{
public class ExpressionNode: Node{
    public List<string> RequiredValues {get;}
    public List<string> RequiredOperators {get;}

    public ExpressionNode(Node parent, List<Node> child, List<string> values, List<string> Operators)
        :base(parent, child, TokenType.Expression)
    {
        RequiredValues = values; 
        RequiredOperators = Operators; 
    }
    public override bool IsValid(Node node){
        if (node is ExpressionNode){
            ExpressionNode realNode = (ExpressionNode)node; 

            if (RequiredValues != null){
                foreach (var value in RequiredValues){
                    if (!realNode.RequiredValues.Contains(value)) return false; 
                }
            }
            if (RequiredOperators != null){
                foreach(var value in RequiredOperators){
                    if (!realNode.RequiredOperators.Contains(value)) return false; 
                }
            }
            return true; 
        }
        else return false; 
    }
}
}