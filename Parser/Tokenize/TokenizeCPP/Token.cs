

public class Token : IToken{
    
    public TokenType tokenType {get;set;}
    public string Value {get;set;}
    public string ID {get; set;} 
    public Token(TokenType token, string value){
        tokenType = token; 
        Value = value; 
    }
}
