using System;

namespace prog
{
    class Program
    {
        static void Main(string[] args)
        {
            //seperately execute each expression
            int a,b,c;
            a=2;
            b=3;
            c=5;
        
            Console.WriteLine(++a);  
            
            Console.WriteLine(a*b*c); 
            
            Console.WriteLine(a++);    
            
            Console.WriteLine(b+=a);  
            
            Console.WriteLine(b+=a*c);  
            
            //Console.WriteLine(a++b);   //invalid
            
            Console.WriteLine(Convert.ToChar(a+=2, 2/2, a*b)); 
            
            //Console.WriteLine(++b++);   //invalid
            
            Console.WriteLine(a++ + b++); 
        }
    }
}
