using System.Collections.Generic; 
using System; 
public class KeywordFactory{
    Dictionary<string, Keyword> hash;

    public KeywordFactory(){
        InitializeHash(); 
    }
    private void InitializeHash(){
        hash = new Dictionary<string, Keyword>(); 
        for (int i = 0; i < Enum.GetNames(typeof(Keyword)).Length; i++){
            hash.Add(Enum.GetName(typeof(Keyword), i).ToLower(), (Keyword)i); 
        }
    }

    public KeywordToken CreateToken(string value){
        if (hash.ContainsKey(value)){
            KeywordToken token = new KeywordToken(hash[value], value); 
            return token; 
        }
        else throw new System.Exception("The token was not an accepted keyword"); 
    }
}   