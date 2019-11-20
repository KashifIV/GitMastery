using System;
using System.Collections.Generic;
using System.Text.RegularExpressions; 

public class CplusplusLexer : ILexer<Token>{
    List<TokenDefinition> tokenDefinitions; 
    public CplusplusLexer(){
        tokenDefinitions = new List<TokenDefinition>(); 
        KeywordDefinitions(); 
        SymbolDefinitons(); 
        AddDefinition(new TokenDefinition(TokenType.Name, @"^[a-zA-Z][a-zA-Z0-9_]{0,}"));
        AddDefinition(new TokenDefinition(TokenType.Constant, @"^[0-9]{1,}|[0-9]{1,}f"));
        const string quote = "\""; 
        AddDefinition(new TokenDefinition(TokenType.Constant, @"^" + @quote +@".{0,}" + @quote));
        AddDefinition(new TokenDefinition(TokenType.Space, @" "));
    }

    private void KeywordDefinitions(){
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^int")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^float")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^double")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^string")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^long")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^char")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^int")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^auto")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^short"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^unsigned"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^signed"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^const"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^register"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^union"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^volatile"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^mutable")); 


        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^enum")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^Keyword")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^struct")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^namespace")); 


        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^private")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^virtual")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^public")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^protected")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^friend")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^template")); 


        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^true"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^false"));  

        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^if")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^case")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^else")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^try")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^catch")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^switch")); 

        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^for"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^do"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^while"));

        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^asm")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^operator"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^throw")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^explicit")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^break")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^extern")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^export")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^typedef"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^typeid"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^typename"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^continue"));  
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^delete"));  
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^goto"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^reinterpret_cast"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^static_cast"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^const_cast"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^dynamic_cast")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^using"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^sizeof"));
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^wchar_t")); 
        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^inline")); 



        AddDefinition(new TokenDefinition(TokenType.Keyword, @"^return"));
        
    }
    private void SymbolDefinitons(){
        AddDefinition(new TokenDefinition(TokenType.Comma, @"^,"));
        AddDefinition(new TokenDefinition(TokenType.Semicolon, @"^;")); 
        AddDefinition(new TokenDefinition(TokenType.OpenBracket, @"^{")); 
        AddDefinition(new TokenDefinition(TokenType.CloseBracket, @"^}")); 
        AddDefinition(new TokenDefinition(TokenType.OpenPar, @"^\(")); 
        AddDefinition(new TokenDefinition(TokenType.ClosePar, @"^\)")); 

        AddDefinition(new TokenDefinition(TokenType.OpenAngle, @"^<")); 
        AddDefinition(new TokenDefinition(TokenType.CloseAngle, @"^>")); 

        AddDefinition(new TokenDefinition(TokenType.Plus, @"^\+")); 
        AddDefinition(new TokenDefinition(TokenType.Minus, @"^\-")); 
        AddDefinition(new TokenDefinition(TokenType.ForSlash, @"^\/"));
        AddDefinition(new TokenDefinition(TokenType.Asterix, @"^\*"));
        AddDefinition(new TokenDefinition(TokenType.Equivilant, @"^=="));

        AddDefinition(new TokenDefinition(TokenType.Equals, @"^="));   

        AddDefinition(new TokenDefinition(TokenType.Newline, @"^\n"));

    }



    public void AddDefinition(TokenDefinition tokenDefinition){
        tokenDefinitions.Add(tokenDefinition); 
    }
    public IEnumerable<Token> Tokenize(string source)
    {
        while(source.Length > 0){
            foreach(var rule in tokenDefinitions){
                Match match = rule.Regex.Match(source); 
                if (match.Success){ 
                    yield return new Token(rule.type, match.Value); 
                    source = source.Substring(match.Value.Length); 
                    break; 
                }
            }
        }

    }
}
