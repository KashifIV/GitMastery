
public abstract class AToken: Node{
    string value;

    protected AToken( string Value = null) => value = Value;

    public string Value{
        get => value; 
    }

}