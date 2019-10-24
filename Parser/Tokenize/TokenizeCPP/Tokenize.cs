using System.Collections.Generic;
using System.Linq;
namespace CPP{
    public class Tokenize: ITokenize<Token>{
        private ILexer<Token> lexer; 
        public List<Token> tokens;
        public List<Token> GetTokens(){
            return tokens; 
        }
        public Tokenize(string source){
            lexer = new CplusplusLexer(); 
            tokens = lexer.Tokenize(source).ToList(); 
            CleanTokens(); 

        }

        private void CleanTokens(){
            RemoveSpaces(); 
            UpdateNames();
            FindBounds(); 
        }

        private void FindBounds(){
            Stack<Token> stack = new Stack<Token>(); 

            for (int i = 0; i < tokens.Count; i++){
                if (tokens[i].tokenType == TokenType.CloseBracket){
                    if (stack.Count == 0) continue; 
                    Token value = stack.Pop(); 
                    tokens.Insert(i+1, new Token(value.tokenType, "End " + value.Value)); 
                }
                else if (tokens[i].tokenType == TokenType.Iterator || tokens[i].tokenType == TokenType.If || tokens[i].tokenType == TokenType.Else){
                    stack.Push(tokens[i]); 
                }
            
            }
        }
        private void UpdateNames(){
            for (int i = 0; i < tokens.Count; i++){
                if (tokens[i].tokenType == TokenType.Name){
                    if (tokens[i+1].tokenType == TokenType.OpenPar){
                        tokens[i].tokenType = TokenType.Function; 
                    }
                    else {
                        tokens[i].tokenType = TokenType.Variable; 
                    }
                }
                else if (tokens[i].tokenType == TokenType.OpenAngle || tokens[i].tokenType == TokenType.CloseAngle){
                    if (tokens[i-1].tokenType == TokenType.Variable || tokens[i-1].tokenType == TokenType.Costant &&  tokens[i+1].tokenType == TokenType.Variable || tokens[i+1].tokenType == TokenType.Costant ){
                        tokens[i].tokenType = TokenType.Comparison; 
                    }
                }
            }
        }
        private void RemoveSpaces(){
            tokens.RemoveAll(e=> e.tokenType == TokenType.Space);
        }
    }
}