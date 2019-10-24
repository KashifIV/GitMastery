using System;

namespace CPP 
{
    namespace Program{
        class Program
        {
            static void Main(string[] args)
            {
                Tokenizer tokenizer = new Tokenizer("Testing/countingLoop.cpp");
                CPP.Tree tree = new Tree(); 
                Tracer tracer = new Tracer(tokenizer, tree); 
                if (tracer.IsMatch){
                    Console.WriteLine("The Code Matches");
                }
                else Console.WriteLine("The Code does not Match"); 
            }
        }
    }
}
