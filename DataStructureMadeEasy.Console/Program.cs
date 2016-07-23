using System.Text.RegularExpressions;
using Backend;

namespace DataStructureMadeEasy.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var name = "Lorem ipsum dolor sit amet, qui ex choro quodsi moderatius, nam dolores explicari forensibus ad.";
            //var regex = new Regex("[' ']+");


            var document = new Document(name);
            //var result = document.GetTokens(new Regex("[' ']+"));
            //foreach (var word in result)
            //{
            //    System.Console.WriteLine(word);
            //}

            System.Console.WriteLine(document.GetNumberOfSentences());
        }


        /******* Regex ******

        var name = "Vaibhav bali with   multiple    spaces";
        removes one or more spaces    
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
