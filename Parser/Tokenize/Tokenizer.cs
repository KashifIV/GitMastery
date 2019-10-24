using System.IO;
using System.Collections.Generic;
public class Tokenizer{

    private string fileName; 
    string source; 
    public Lang Language {get;set;} 
    public ITokenize<CPP.Token> tokenize {get;set;} 
    public Tokenizer(string file){
        fileName = file; 
        string source = File.ReadAllText(fileName); 
        TokenFactory factory; 
        if (file.Contains(".cpp")){

            fileName = file; 
            Language = Lang.CPP; 
            factory = new CPPToken(source); 
        }
        else {
             factory = new CPPToken(source); 
        }
        tokenize = factory.GetTokenize();
    }
    public List<CPP.Token> Tokens{
        get{
            return tokenize.GetTokens(); 
        }   
    }

}