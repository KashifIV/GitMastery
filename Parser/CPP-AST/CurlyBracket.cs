using System.Collections.Generic;
public class CurlyBracket : BracketContainer{

    public CurlyBracket(List<Node> children): base(children, "{", "}"){
        
    }
}