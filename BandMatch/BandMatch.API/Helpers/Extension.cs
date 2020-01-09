using Microsoft.AspNetCore.Http;

namespace BandMatch.API.Helpers
{
    public static class Extension // static don't need to  create an instance
    {
        public static void AddApplicationError(this HttpResponse response, string message) // void doesn't return anything
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}