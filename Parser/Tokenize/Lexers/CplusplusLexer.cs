using System;
using System.Collections.Generic;
using System.Text.RegularExpressions; 
namespace CPP{
    public class CplusplusLexer : ILexer<Token>{
        List<TokenDefinition> tokenDefinitions; 
        public CplusplusLexer(){
            tokenDefinitions = new List<TokenDefinition>(); 
            KeywordDefinitions(); 
            SymbolDefinitons(); 
            AddDefinition(new TokenDefinition(TokenType.Name, @"^[a-zA-Z][a-zA-Z0-9_]{0,}"));
            AddDefinition(new TokenDefinition(TokenType.Costant, @"^[0-9]{1,}|[0-9]{1,}f"));
            const string quote = "\""; 
            AddDefinition(new TokenDefinition(TokenType.Costant, @"^" + @quote +@".{0,}" + @quote));
            AddDefinition(new TokenDefinition(TokenType.Space, @" "));
        }

        private void KeywordDefinitions(){
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^int")); 
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^float")); 
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^double")); 
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^string")); 
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^long")); 
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^char")); 
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^int")); 
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^auto")); 
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^short"));
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^unsigned"));
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^signed"));
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^const"));
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^register"));
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^union"));
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^volatile"));
            AddDefinition(new TokenDefinition(TokenType.DataType, @"^mutable")); 


            AddDefinition(new TokenDefinition(TokenType.Class, @"^enum")); 
            AddDefinition(new TokenDefinition(TokenType.Class, @"^class")); 
            AddDefinition(new TokenDefinition(TokenType.Class, @"^struct")); 
            AddDefinition(new TokenDefinition(TokenType.Class, @"^namespace")); 


            AddDefinition(new TokenDefinition(TokenType.Visibility, @"^private")); 
            AddDefinition(new TokenDefinition(TokenType.Visibility, @"^virtual")); 
            AddDefinition(new TokenDefinition(TokenType.Visibility, @"^public")); 
            AddDefinition(new TokenDefinition(TokenType.Visibility, @"^protected")); 
            AddDefinition(new TokenDefinition(TokenType.Visibility, @"^friend")); 
            AddDefinition(new TokenDefinition(TokenType.Visibility, @"^template")); 


            AddDefinition(new TokenDefinition(TokenType.Costant, @"^true"));
            AddDefinition(new TokenDefinition(TokenType.Costant, @"^false"));  

            AddDefinition(new TokenDefinition(TokenType.If, @"^if")); 
            AddDefinition(new TokenDefinition(TokenType.If, @"^case")); 
            AddDefinition(new TokenDefinition(TokenType.Else, @"^else")); 
            AddDefinition(new TokenDefinition(TokenType.Try, @"^try")); 
            AddDefinition(new TokenDefinition(TokenType.Catch, @"^catch")); 
            AddDefinition(new TokenDefinition(TokenType.Switch, @"^switch")); 

            AddDefinition(new TokenDefinition(TokenType.Iterator, @"^for"));
            AddDefinition(new TokenDefinition(TokenType.Iterator, @"^do"));
            AddDefinition(new TokenDefinition(TokenType.Iterator, @"^while"));

            AddDefinition(new TokenDefinition(TokenType.Command, @"^asm")); 
            AddDefinition(new TokenDefinition(TokenType.Command, @"^operator"));
            AddDefinition(new TokenDefinition(TokenType.Command, @"^throw")); 
            AddDefinition(new TokenDefinition(TokenType.Command, @"^explicit")); 
            AddDefinition(new TokenDefinition(TokenType.Command, @"^break")); 
            AddDefinition(new TokenDefinition(TokenType.Command, @"^extern")); 
            AddDefinition(new TokenDefinition(TokenType.Command, @"^export")); 
            AddDefinition(new TokenDefinition(TokenType.Command, @"^typedef"));
            AddDefinition(new TokenDefinition(TokenType.Command, @"^typeid"));
            AddDefinition(new TokenDefinition(TokenType.Command, @"^typename"));
            AddDefinition(new TokenDefinition(TokenType.Command, @"^continue"));  
            AddDefinition(new TokenDefinition(TokenType.Command, @"^delete"));  
            AddDefinition(new TokenDefinition(TokenType.Command, @"^goto"));
            AddDefinition(new TokenDefinition(TokenType.Command, @"^reinterpret_cast"));
            AddDefinition(new TokenDefinition(TokenType.Command, @"^static_cast"));
            AddDefinition(new TokenDefinition(TokenType.Command, @"^const_cast"));
            AddDefinition(new TokenDefinition(TokenType.Command, @"^dynamic_cast")); 
            AddDefinition(new TokenDefinition(TokenType.Command, @"^using"));
            AddDefinition(new TokenDefinition(TokenType.Command, @"^sizeof"));
            AddDefinition(new TokenDefinition(TokenType.Command, @"^wchar_t")); 
            AddDefinition(new TokenDefinition(TokenType.Command, @"^inline")); 



            AddDefinition(new TokenDefinition(TokenType.Return, @"^return"));
            
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

            AddDefinition(new TokenDefinition(TokenType.Operator, @"^\+")); 
            AddDefinition(new TokenDefinition(TokenType.Operator, @"^\-")); 
            AddDefinition(new TokenDefinition(TokenType.Operator, @"^\/"));
            AddDefinition(new TokenDefinition(TokenType.Operator, @"^\*"));
            AddDefinition(new TokenDefinition(TokenType.Operator, @"^=="));

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
}