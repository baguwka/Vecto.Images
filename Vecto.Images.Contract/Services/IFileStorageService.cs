using System.Threading.Tasks;

namespace Vecto.Images.Contract.Services
{
    public interface IFileStorageService
    {
        Task<string> Store(string filePath, byte[] content, string fileName, FileStorageBucket bucket);
        Task<byte[]?> Download(string filePath, string fileId, FileStorageBucket bucket);
    }
}