using System;
using CPP = CPP;

public abstract class TokenFactory{
    string source; 
    public TokenFactory(string text){
        source = text; 
    }
    public abstract ITokenize<CPP::Token> GetTokenize(); 
}

public class CPPToken : TokenFactory{
    CPP::Tokenize tokenize; 
    public CPPToken(string source)
        :base(source)
    {
        tokenize = new CPP::Tokenize(source); 
    }
    public override ITokenize<CPP::Token> GetTokenize(){
        return tokenize; 
    }
    
}