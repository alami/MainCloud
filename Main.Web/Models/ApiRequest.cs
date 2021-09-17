using static Main.Web.SD;

namespace Main.Web.Models
{
    public class ApiRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data{ get; set; }
        public string AccessToken { get; set; }

    }
}
