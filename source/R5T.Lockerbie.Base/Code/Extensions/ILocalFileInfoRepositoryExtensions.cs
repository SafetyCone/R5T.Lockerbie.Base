using System;
using System.Threading.Tasks;

using R5T.Philippi;
using R5T.Sparta;


namespace R5T.Lockerbie.Extensions
{
    public static class ILocalFileInfoRepositoryExtensions
    {
        public static async Task<bool> HasFormat(this ILocalFileInfoRepository localFileInfoRepository, FileIdentity fileIdentity, FileFormat fileFormat)
        {
            var itemfileFormat = await localFileInfoRepository.GetFileFormat(fileIdentity);

            var output = fileFormat == itemfileFormat;
            return output;
        }

        public static async Task<bool> HasFormat(this ILocalFileInfoRepository localFileInfoRepository, FilePath filePath, FileFormat fileFormat)
        {
            var itemfileFormat = await localFileInfoRepository.GetFileFormat(filePath);

            var output = fileFormat == itemfileFormat;
            return output;
        }
    }
}
