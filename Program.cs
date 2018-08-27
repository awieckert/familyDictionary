using System;
using System.Collections.Generic;

namespace familyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Krista"},
                {"age", "42"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){
              {"name", "ButtFace"},
              {"age", "OLD!"}
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> relative in myFamily)
            {
                Console.WriteLine($"{relative.Value["name"]} is my {relative.Key} and is {relative.Value["age"]}");
            }
        }
    }
}
