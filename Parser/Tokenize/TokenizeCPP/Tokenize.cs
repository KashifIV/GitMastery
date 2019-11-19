using System.Collections.Generic;
using System.IO; 
using System.Linq;
public class Tokenize: ITokenize<Token>{
    private ILexer<Token> lexer; 
    public List<Token> tokens;
    public List<Token> GetTokens(){
        return tokens; 
    }
    public Tokenize(string source){
        lexer = new CplusplusLexer(); 
        tokens = lexer.Tokenize(File.ReadAllText(source)).ToList(); 
        CleanTokens(); 
    }

    private void CleanTokens(){
        RemoveSpaces(); 
    }

    private void RemoveSpaces(){
        tokens.RemoveAll(e=> e.tokenType == TokenType.Space);
    }
}
