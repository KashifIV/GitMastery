using System.Reflection.Metadata;
using System;
using System.Collections.Generic; 

namespace CPP{
public class Tree{
    public Node root; 
    public Tree(){
        root = new Node(null, new List<Node>{
            new Node(null, new List<Node>{
                new Node(null, null, TokenType.Comparison), 
                new Node(null, null, TokenType.Equals), 
            }, TokenType.Iterator)
        }
        , TokenType.Program); 
        SetParent(root); 
        

    }
    private void SetParent(Node current){
        if (current.children == null) return; 

        foreach (var item in current.children){
            item.Parent = current;  
            SetParent(item); 
        }
    }
    
}
}