using System.Collections.Generic;
namespace CPP{
public abstract class TraceFactory{
    Tokenizer tokens; 
    Tree structure; 
    public TraceFactory(Tokenizer tokenizer, Tree tree){
        tokens = tokenizer; 
        structure = tree; 
    }
    public abstract ITracer GetTracer(); 

}

public class CPPTraceFactory:TraceFactory{
    CPPTracer tracer; 
    public CPPTraceFactory(Tokenizer tokenizer, Tree tree)
        :base(tokenizer, tree)
    {
        tracer = new CPPTracer(tree.root, tokenizer.Tokens); 
    }
    public override ITracer GetTracer(){
        return tracer; 
    }

}
}