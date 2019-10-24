using System; 
using System.Collections.Generic; 
namespace CPP{
public class CPPTracer : ITracer{
    Node Root; 
    List<Token> tokens; 
    int currentIndex = 0; 
    bool match; 
    public CPPTracer(Node root, List<Token> t){
        Root = root; 
        tokens = t; 
        RunChild(root); 
        if (CheckVisits(root)){
            match = true; 
        }
        else {
           match = false; 
        }
    }
    public bool IsMatch(){
        return match; 
    }

    private void RunChild(Node node){
        node.Visited = true; 
        if (node.children == null) return; 
        while (currentIndex < tokens.Count){
            bool isComplete = true; 
            if (tokens[currentIndex].tokenType == TokenType.Return) return; 
            else if (tokens[currentIndex].Value.Contains("End")) return; 
            foreach (var options in node.children){
                if (options.Value == tokens[currentIndex].tokenType){
                    RunChild(options);
                }
                if (!options.Visited) isComplete = false; 
            }
            if (isComplete) return; 
            currentIndex++; 
        }
    }

    private bool CheckVisits(Node current){
        if (current.children == null) return current.Visited; 
        foreach (var item in current.children){
            item.Parent = current;  
            if (!CheckVisits(item)){
                Console.WriteLine("Failed " + item.Value.ToString());
                return false; 
            } 
            else {
                Console.WriteLine("Success " + current.Value.ToString());
            }
            
        }
        return true; 
    }
}
}