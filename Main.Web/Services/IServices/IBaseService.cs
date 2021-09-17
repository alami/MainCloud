using Main.Web.Models;
using System;
using System.Threading.Tasks;

namespace Main.Web.Services.IServices
{
    public interface IBaseService: IDisposable
    {
        ResponseDto responseModel {  get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
