using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        private const int V = 1;

        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanets = new List<string>(){"Neptune", "Pluto"};
            planetList.AddRange(lastPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Insert(6, "Uranus");

            planetList.Remove("Pluto");

            string[] rockyPlanets = planetList.GetRange(1, 2).ToArray();
            
            Console.WriteLine("Rocky Planets");
            Console.WriteLine("-----");
            foreach( string planet in rockyPlanets )
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Planet List");
            Console.WriteLine("-----");
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }
            

            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };

            for (int i=0; i<numbers.Count; i++) {
                if (numbers.Contains(i)) {
                    Console.WriteLine($"numbers list does contain {i}");
                } else {
                    Console.WriteLine($"number list does not contain {i}");
                }
            }
            /*
            Create a dictionary with key value pairs to
            represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("one", "the word for number 1");
            wordsAndDefinitions.Add("two", "the word for number 2");
            wordsAndDefinitions.Add("three", "the word for number 3");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Awesome"]);
            Console.WriteLine(wordsAndDefinitions["one"]);
            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"{word.Key} is {word.Value}");
            }


            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

/*
    You want to track the following about each word:
        word, definition, part of speech, example sentence

    Example of one dictionary in the list:
    {
        "word": "excited",
        "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
        "part of speech": "adjective",
        "example sentence": "I am excited to learn C#!"
    }
*/

// Create dictionary to represent a few words
            Dictionary<string,  string> excitedWord  =  new Dictionary<string, string>() {
                {"word:", "excited"},
                {"definition:", "showing excitement"},
                {"speech:", "adjective"},
                {"ex sentence:", "im excited"}
            };

// Add each of the 4 bits of data about the word to the Dictionary
            

// Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

// create another Dictionary and add that to the list
            Dictionary<string, string> newWord  =  new Dictionary<string, string>() {
                {"word:", "elated"},
                {"definition:", "showing elation"},
                {"speech:", "adjective"},
                {"ex sentence:", "im elated"}
            };
            dictionaryOfWords.Add(newWord);

/*
    Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

    Example output for one word in the list of dictionaries:
        word: excited
        definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
        part of speech: adjective
        example sentence: I am excited to learn C#!
*/

//Iterate the List of Dictionaries
foreach (Dictionary<string, string> thing in dictionaryOfWords)
{
    // Iterate the KeyValuePairs of the Dictionary
    foreach (KeyValuePair<string, string> word in excitedWord)
    {
        Console.WriteLine($"{word.Key} {word.Value}");
    }
}


}
}
}
