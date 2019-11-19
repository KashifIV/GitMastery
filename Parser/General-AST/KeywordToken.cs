public abstract class AKeywordToken : AToken{
    Keyword keyword; 
    public AKeywordToken(Keyword keyword, string value) : base(value) => this.keyword = keyword; 
}