using System;
using System.Collections.Generic;

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
        FileIdentity Add(FilePath filePath, FileFormat fileFormat);
        //FileIdentity Add(FilePath filePath); // Might not be in core functionality since will need to determine file format from file extension of file path.

        // Read.
        bool Exists(FileIdentity fileIdentity);
        bool Exists(FilePath filePath);

        IEnumerable<FileInfo> GetAll();

        FilePath GetFilePath(FileIdentity fileIdentity);
        FileIdentity GetFileIdentity(FilePath filePath);
        FileFormat GetFileFormat(FileIdentity fileIdentity);
        FileFormat GetFileFormat(FilePath filePath);
        FileInfo GetFileInfo(FileIdentity fileIdentity);
        FileInfo GetFileInfo(FilePath filePath);

        //bool HasFormat(FileIdentity fileIdentity, FileFormat fileFormat); // Extension method.
        //bool HasFormat(FilePath filePath, FileFormat fileFormat); // Extension method.

        // Update.
        void SetFileFormat(FileIdentity fileIdentity, FileFormat fileFormat);
        void SetFileFormat(FilePath filePath, FileFormat fileFormat);

        // Delete.
        void Delete(FileIdentity fileIdentity);
        void Delete(FilePath filePath);
    }
}
