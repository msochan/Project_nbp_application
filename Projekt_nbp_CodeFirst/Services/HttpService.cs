using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Projekt_nbp_CodeFirst.Services
{
    class HttpService
    {
        private static string uri;
        private static HttpClient client;

        private static HttpResponse connectionResult;


        public HttpService(string basePath, string httpAccept = null)
        {
            uri = basePath;
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            if (httpAccept != null)
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(httpAccept));

            }
        }


        public HttpResponse GetRequestSync(string path, string format = null)
        {
            try
            {
                string fullPath = path;

                if (format != null)
                    fullPath = path + format;


                HttpResponseMessage response = client.GetAsync(fullPath).Result;



                string responseContentData = response.Content.ReadAsStringAsync().Result;
                string responseMessage = response.ReasonPhrase;



                if (response.IsSuccessStatusCode)
                {

                    connectionResult = new HttpResponse(Response.Accepted, responseContentData, responseMessage);
                }
                else
                {
                    connectionResult = new HttpResponse(Response.Rejected, responseContentData, responseMessage);
                }
            }

           
            catch (ArgumentNullException ArgumentNullExepection)
            {
                Console.WriteLine("Path leading to resource is null", ArgumentNullExepection.Message);
            }

            catch (HttpRequestException HttpRequestExepection)
            {
                Console.WriteLine("Connection failed due to some Internet connection problems", HttpRequestExepection.Message);
            }

            catch (Exception OtherWebConnectionExepection)
            {
                Console.WriteLine("Problem with server connection occured", OtherWebConnectionExepection.Message);
            }


                return connectionResult;
        }


        public Task<HttpResponse> GetRequestAsync(string path, string format = null)
        {
           



           return Task.Run(() =>
           {
               Thread.Sleep(5000);
               return GetRequestSync(path);
           });

                
            
        }




    }
    
}
