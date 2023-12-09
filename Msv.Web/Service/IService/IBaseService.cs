using Msv.Web.Models;

namespace Msv.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto  requestDto);
    }
}
