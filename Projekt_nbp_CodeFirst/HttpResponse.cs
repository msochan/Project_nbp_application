namespace Projekt_nbp_CodeFirst
{

    public enum Response
    {
        Accepted,
        Rejected
    };

    public class HttpResponse
    {

        
        public Response responseStatus { get; set; }
        public string responseData { get; set; }
        public string responseMessage { get; set; }



        public HttpResponse(Response responseStatus, string responseData, string responseMessage)
        {
            this.responseStatus = responseStatus;
            this.responseData = responseData;
            this.responseMessage = responseMessage;
        }
    }
}
