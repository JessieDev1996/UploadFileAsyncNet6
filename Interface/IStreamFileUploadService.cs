using Microsoft.AspNetCore.WebUtilities;

namespace UploadFileAsync.Interface
{
    public interface IStreamFileUploadService
    {
        Task<bool> UploadFile(MultipartReader reader, MultipartSection section);
    }
}
