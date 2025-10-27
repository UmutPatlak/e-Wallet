using Newtonsoft.Json;

namespace e_Wallet.Application.Exceptions
{
    public class ExceptionModel : ErrorStatusCode
    {
        public IEnumerable<string> Errors { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }



    }

    public class  ErrorStatusCode 
     {
        
        public int StatusCode { get; set; }

    }
}
