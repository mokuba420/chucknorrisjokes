using ChuckNorrisJokesLibrary;
using System;
using System.Threading.Tasks;

namespace chucknorrisconsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            JokeGenerator jokeGenerator = new JokeGenerator();
            string randomJoke = await jokeGenerator.GetRandomjoke();
           
            Console.WriteLine(randomJoke);

            String[] categories = await jokeGenerator.GetCategories();

            for (int index = 0; index < categories.Length; index++)
                Console.WriteLine(categories[index]);
        
        
        
        }
    }
}
