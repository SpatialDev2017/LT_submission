using LT_consoleApp.Controller;
using LT_consoleApp.Model;
using Newtonsoft.Json;
using System;



namespace LT_consoleApp
{
     class Program
    {
       
        IRequestHandler requestHandler = new HttpClientRequestHandler();
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

        public static string GetPhotos(IRequestHandler rh)
        {
            
            Console.Write("Enter the id for the album you would like to query. \nAlbum Id:");
            string photoId = Console.ReadLine();
            return rh.GetAlbumsById(Constants.BaseUrl, photoId);
        }


    }

}