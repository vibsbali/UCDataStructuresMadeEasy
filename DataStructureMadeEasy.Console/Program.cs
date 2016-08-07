using System.ComponentModel;
using System.Runtime.InteropServices;
using Backend;
using DataStructuresMadeEasy.Bst;

namespace DataStructureMadeEasy.Console
{
    class Program
    {
        static void Main()
        {
            var trie = new Trie();

            

            



            //var name = "This is a test.  How many???  " + "Senteeeeeeeeeences are here... there should be 5!  Right?";
            //var name = "sentence, with, lots, of, commas.!  "
            //    + "(And some poaren)).  The output is: 7.5.";
            //var name = "many???  Senteeeeeeeeeences are";
            var name = "Here is a series of test sentences. Your program should "
                       + "find 3 sentences, 33 words, and 49 syllables. Not every word will have "
                       + "the correct amount of syllables (example, for example), "
                       + "but most of them will.";
            //var name = "Sentences?!";
            //var regex = new Regex("[' ']+");


            var document = new Document(name);
            //var result = document.GetTokens(new Regex("[' ']+"));
            //foreach (var word in result)
            //{
            //    System.Console.WriteLine(word);
            //}

            System.Console.WriteLine(document.GetNumberOfSentences());
            System.Console.WriteLine(document.GetNumberOfWords());
            foreach (var word in document.GetWords())
            {
                trie.Add(word);
            }
            foreach (var word in document.GetWords())
            {
                System.Console.Write("Word is {0} ", word);
                System.Console.WriteLine(trie.Get(word));
            }
            System.Console.WriteLine(document.GetNumberOfSyllables());
            System.Console.WriteLine(document.GetFleschScore());
        }


        /******* Regex ******

        Resources: 
        http://regexr.com/
        https://regex101.com/


        var name = "Vaibhav bali with   multiple    spaces";
        //removes one or more spaces    
        var regex = new Regex("[' ']+");

            var result = regex.Split(name);
            foreach (var s in result)
            {
                System.Console.WriteLine(s);
            }
        output - Vaibhavbaliwithmuliplespaces





        */






    }
}

/*

testCase(new BasicDocument("This is a test.  How many???  "
		        + "Senteeeeeeeeeences are here... there should be 5!  Right?"),
				16, 13, 5);
		testCase(new BasicDocument(""), 0, 0, 0);
		testCase(new BasicDocument("sentence, with, lots, of, commas.!  "
		        + "(And some poaren)).  The output is: 7.5."), 15, 11, 4);
		testCase(new BasicDocument("many???  Senteeeeeeeeeences are"), 6, 3, 2);
		testCase(new BasicDocument("Here is a series of test sentences. Your program should "
				+ "find 3 sentences, 33 words, and 49 syllables. Not every word will have "
				+ "the correct amount of syllables (example, for example), "
				+ "but most of them will."), 49, 33, 3);
		testCase(new BasicDocument("Segue"), 2, 1, 1);
		testCase(new BasicDocument("Sentence"), 2, 1, 1);
		testCase(new BasicDocument("Sentences?!"), 3, 1, 1);
		testCase(new BasicDocument("Lorem ipsum dolor sit amet, qui ex choro quodsi moderatius, nam dolores explicari forensibus ad."),
		         32, 15, 1);
*/