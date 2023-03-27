using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RestSharp;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static HttpClient client = new HttpClient();
         
        static void Main(string[] args)
        { 
            
        
          getRandomWord();
        }
public static void getRandomWord()
{
    requestWord("random");
}

public static void getSortedWords()
{
    requestWord("sorted");
}

public static void getAllWords()
{
    requestWord("all");
}

public static void requestWord(string route)
{
      var client = new RestClient("http://localhost:5037/controller/");
      var request = new RestRequest(route);
      var response = client.Execute(request);
      var word = response.Content;
      Console.WriteLine(word);
}

        
       
    }
}