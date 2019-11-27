using System;
using System.Threading.Tasks;

namespace rest_call
{
    class Program
    {
        // private int maxNumber = 0;
        // private int currentNumber = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ApiHelper.InitializeClient();
            Console.WriteLine("Hello World!");

        }

        // private async Task LoadImage(int imageNumber = 0)
        // {
        //     var starship = await StarshipProcessor.LoadStarship(imageNumber);

        //     if (imageNumber == 0)
        //     {
                
        //     }
        // }
    }
}
