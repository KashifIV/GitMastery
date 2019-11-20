public class KeywordToken : AToken{
    Keyword keyword; 
    public KeywordToken(Keyword keyword, string value) : base(value) => this.keyword = keyword; 
}