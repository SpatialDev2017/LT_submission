using LT_consoleApp.Controller;
using LT_consoleApp.Model;
using Newtonsoft.Json;
using System;
using System.Text.RegularExpressions;



namespace LT_consoleApp
{
     class Program
    {
        static void Main(string[] args)
        {

            //GET data
            IRequestHandler httpClientRequestHandler = new HttpClientRequestHandler();
           var response = GetPhotos(httpClientRequestHandler);
          
           var repoList = JsonConvert.DeserializeObject<List<Repository>>(response);

            foreach(var album in repoList)
             {
                 if(album == null)
                 {
                     continue;
                 }
               Console.WriteLine("Photo ID: {0}", album.id);
               Console.WriteLine("Thumbnail: {0}", album.title); 

             }

        }

        public static string? GetPhotos(IRequestHandler rh)
        {
            
            Console.Write("Enter the id for the album you would like to query. \nAlbum Id:");
            string pattern = "[0-9]";
            Regex rg = new Regex(pattern);
            string photoId = Console.ReadLine();
            if (photoId == null)
                return null;
            else if (rg.IsMatch(photoId))
                return rh.GetAlbumsById(Constants.BaseUrl, photoId); 
            else
                throw new ArgumentNullException("Please enter a valid id");
           
            
        }


    }

}