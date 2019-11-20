using System.Collections.Generic; 
public class BracketContainer : Collection{
    string openBracket, closeBracket; 
    public BracketContainer(List<Node> children, string OpenBracket, string CloseBracket) : base(children){
        openBracket = OpenBracket; 
        this.closeBracket = CloseBracket; 
    }
    public string OpenBracket{
        get => openBracket; 
    }
    public string CloseBracket{
        get=> closeBracket;
    }
}