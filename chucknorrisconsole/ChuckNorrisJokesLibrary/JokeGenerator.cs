using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace ChuckNorrisJokesLibrary
{
    public class JokeGenerator
    {
        public async Task<string> GetRandomjoke()
        {
            var client = new HttpClient();

            string randomJokeString = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");

            var joke = JsonConvert.DeserializeObject<Joke>(randomJokeString);

            return joke.value;




        }

        public async Task<string[]> GetCategories()
        {
            var client = new HttpClient();

            string categoriesString = await client.GetStringAsync("https://api.chucknorris.io/jokes/categories");

            var categories = JsonConvert.DeserializeObject<string[]>(categoriesString);

            return categories;



        }
    }

}