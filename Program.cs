using System;
using System.Linq;



namespace ConsoleApplication1
{
    class  Program
    {
        static void Main(string[] args)
        {
            Solution("samurai", "ai");


        } 
        public static bool Solution(string str, string ending)
        {
            return str.EndsWith(ending);
        }
        
    }
}