using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Philippi;
using R5T.Sparta;


namespace R5T.Lockerbie
{
    /// <summary>
    /// Keeps track of local file-path file-format.
    /// Files are given unique identities (in addition to their unique file path).
    /// Repository provides CRUD operations for FileInfo objects describing files in the local file-system.
    /// </summary>
    public interface ILocalFileInfoRepository
    {
        // Create.
        Task<FileIdentity> Add(FilePath filePath, FileFormat fileFormat);
        //FileIdentity Add(FilePath filePath); // Might not be in core functionality since will need to determine file format from file extension of file path.
        Task Add(FileInfo fileInfo);

        // Read.
        Task<bool> Exists(FileIdentity fileIdentity);
        Task<bool> Exists(FilePath filePath);

        Task<IEnumerable<FileInfo>> GetAll();

        Task<FilePath> GetFilePath(FileIdentity fileIdentity);
        Task<FileIdentity> GetFileIdentity(FilePath filePath);
        Task<FileFormat> GetFileFormat(FileIdentity fileIdentity);
        Task<FileFormat> GetFileFormat(FilePath filePath);
        Task<FileInfo> GetFileInfo(FileIdentity fileIdentity);
        Task<FileInfo> GetFileInfo(FilePath filePath);

        //bool HasFormat(FileIdentity fileIdentity, FileFormat fileFormat); // Extension method.
        //bool HasFormat(FilePath filePath, FileFormat fileFormat); // Extension method.

        // Update.
        Task SetFileFormat(FileIdentity fileIdentity, FileFormat fileFormat);
        Task SetFileFormat(FilePath filePath, FileFormat fileFormat);

        // Delete.
        Task Delete(FileIdentity fileIdentity);
        Task Delete(FilePath filePath);
    }
}
