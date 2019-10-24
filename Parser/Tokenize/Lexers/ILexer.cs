using System.Collections.Generic;
public interface ILexer<VToken> where VToken : IToken
{
    IEnumerable<VToken> Tokenize(string source); 
}