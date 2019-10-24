using System.Text.RegularExpressions;
namespace CPP{
    public class TokenDefinition{
        public bool IsIgnored {get;set;}
        public Regex Regex {get;set;}
        public TokenType type {get;set;}
        public TokenDefinition(TokenType token, string regex, bool ignored = false){
            type = token; 
            Regex = new Regex(regex); 
            IsIgnored = ignored; 
        }
    }
}