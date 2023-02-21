using System;
using System.Collections.Generic;

namespace foreach_ja_dictionary_töö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var school = new Dictionary<int, string>
            {
                {1,"Ristiku_Põhikool"},
                {2,"Tallinna_Kunstigümnaasium"},
                {3,"Tallinna_Tööstushariduskeskus"}
            };

            foreach (var paar in school)
            {
                Console.WriteLine($"{paar.Key}. {paar.Value}");
            }
        }
    }
}
