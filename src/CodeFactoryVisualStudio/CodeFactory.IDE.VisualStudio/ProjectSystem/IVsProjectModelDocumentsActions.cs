//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Project actions that manage documents hosted in the project.
    /// </summary>
    public interface IVsProjectModelDocumentsActions
    {
        /// <summary>
        /// Adds a project document to the root of the project.
        /// </summary>
        /// <param name="fileName">The file name of the document. This should be the name only with no file path.</param>
        /// <param name="content">The content that will be initially added to the document. This is an optional parameter.</param>
        /// <returns>The created project document.</returns>
        Task<VsDocument> AddDocumentAsync(string fileName, string content = null);

        /// <summary>
        /// Finds all instances of a document in a project by it's file name.
        /// </summary>
        /// <param name="fileName">The file name of the document including the extension of the file name.</param>
        /// <returns>List of all documents in the project with the file name, or an empty list if none are found.</returns>
        Task<IReadOnlyList<VsDocument>> FindDocumentsAsync(string fileName);

        /// <summary>
        /// Finds all instances of a document in the project.
        /// </summary>
        /// <param name="allLevels">Optional parameter that determines if documents from project folders will also be returned. Default will be false the root level only.</param>
        /// <returns>List of all documents in the project with the file name, or an empty list if none are found.</returns>
        Task<IReadOnlyList<VsDocument>> GetDocumentsAsync(bool allLevels = false);

        /// <summary>
        /// Adds an existing document to the project.
        /// </summary>
        /// <param name="fileName">The file name for the document. This should be the file name only with extension. The file must already be in the projects folder.</param>
        /// <returns>The model of the created project document.</returns>
        Task<VsDocument> AddExistingDocumentAsync(string fileName);
    }
}
