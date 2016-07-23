using System.Text.RegularExpressions;

namespace DataStructureMadeEasy.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Vaibhav bali with   multiple    spaces";
            var regex = new Regex("[' ']+");

            var result = regex.Split(name);
            foreach (var s in result)
            {
                System.Console.WriteLine(s);
            }
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
