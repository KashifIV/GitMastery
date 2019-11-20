using System.Collections.Generic; 
using System; 
public class KeywordFactory{
    Dictionary<string, Keyword> keywordHash;
    HashSet<string> customHash; 

    public Dictionary<string, Keyword> KeywordHash{
        get=> keywordHash;
    }

    public HashSet<string> CustomHash{
        get=> customHash; 
    }

    public KeywordFactory(){
        InitializeHash(); 
    }
    private void InitializeHash(){
        keywordHash = new Dictionary<string, Keyword>(); 
        for (int i = 0; i < Enum.GetNames(typeof(Keyword)).Length; i++){
            keywordHash.Add(Enum.GetName(typeof(Keyword), i).ToLower(), (Keyword)i); 
        }
    }
    public AToken CreateToken(string value){
        if (keywordHash.ContainsKey(value)){
            return CreateKeywordToken(value); 
        }
        else {
            return CreateCustomToken(value); 
        }
    }
    public KeywordToken CreateKeywordToken(string value){
        if (keywordHash.ContainsKey(value)){
            KeywordToken token = new KeywordToken(keywordHash[value], value); 
            return token; 
        }
        else throw new System.Exception("The token was not an accepted keyword"); 
    }
    public CustomKeywordToken CreateCustomToken(string value){
        if (customHash.Contains(value)){
            return new CustomKeywordToken(value); 
        }
        else{
            customHash.Add(value); 
            return new CustomKeywordToken(value); 
        }
    }
}   