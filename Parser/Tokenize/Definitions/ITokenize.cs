using System.Collections.Generic;
public interface ITokenize<VToken> where VToken : IToken {
    List<VToken> GetTokens(); 
}