using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LT_consoleApp.Controller
{
    public interface IRequestHandler
    {
        //method to get the albums from repo
        string GetAlbumsById(string url, string id);
        string GetPhotoById(string url, string id, string photoid);
        

    }
}
