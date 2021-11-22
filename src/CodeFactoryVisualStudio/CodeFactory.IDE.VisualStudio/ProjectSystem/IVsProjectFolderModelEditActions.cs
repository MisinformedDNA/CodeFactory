//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Actions for editing the project folder in Visual Studio.
    /// </summary>
    public interface IVsProjectFolderModelEditActions
    { 
        /// <summary>
        /// Deletes the project folder.
        /// </summary>
        /// <returns>Flag determining if the folder was deleted, True for deleted and false if the folder could not be deleted.</returns>
        Task<bool> DeleteAsync();

        /// <summary>
        /// Removes the project folder from visual studio, but does not delete it from the file system.
        /// </summary>
        /// <returns>Flag determining if the folder was removed, True for removed and false if the folder could not be removed.</returns>
        Task<bool> RemoveAsync();

        /// <summary>
        /// Adds a new project folder under the current project folder.
        /// </summary>
        /// <param name="folderName">The name of the project folder. The project folder name should be the name only no path.</param>
        /// <returns>The model for the created project folder.</returns>
        Task<VsProjectFolder> AddProjectFolderAsync(string folderName);

        /// <summary>
        /// Adds a document to the project folder.
        /// </summary>
        /// <param name="fileName">The file name for the document. This should be the file name only with extension.</param>
        /// <param name="content">The content to be added to the document once its added. Note, this is an optional parameter.</param>
        /// <returns>The model of the created project document.</returns>
        Task<VsDocument> AddDocumentAsync(string fileName, string content = null);

        /// <summary>
        /// Adds an existing document to the project folder.
        /// </summary>
        /// <param name="fileName">The file name for the document. This should be the file name only with extension. The file must already be in the project folder.</param>
        /// <returns>The model of the created project document.</returns>
        Task<VsDocument> AddExistingDocumentAsync(string fileName);
    }
}