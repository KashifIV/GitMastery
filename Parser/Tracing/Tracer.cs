namespace CPP{
public class Tracer{
    ITracer tracer; 
    public Tracer(Tokenizer tokenizer, Tree tree){
        TraceFactory factory; 
        if (tokenizer.Language == Lang.CPP){
            factory =new CPPTraceFactory(tokenizer, tree); 
        }
        else factory =new CPPTraceFactory(tokenizer, tree); 
        tracer = factory.GetTracer();
    }
    public bool IsMatch{
        get{
            return tracer.IsMatch(); 
        }
    }
}
}