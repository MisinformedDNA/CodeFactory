//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

using System.Threading.Tasks;
using CodeFactory.Document;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Actions to get content from a Visual Studio document.
    /// </summary>
    public interface IVsDocumentModelContentActions
    {
        /// <summary>
        /// Gets the content of the document.
        /// </summary>
        /// <returns>The content of the document or null if there is no content in the document.</returns>
        Task<string> GetDocumentContentAsStringAsync();

        /// <summary>
        /// Gets the content of the document.
        /// </summary>
        /// <param name="startLocation">The starting position within the document to get content from.</param>
        /// <param name="endLocation">The ending position within the document to get content form.</param>
        /// <returns>The content of the document or null if there is no content in the document.</returns>
        Task<string> GetDocumentContentAsStringAsync(IDocumentLocation startLocation, IDocumentLocation endLocation);

        /// <summary>
        /// Gets the content of the document.
        /// </summary>
        /// <returns>Document content as </returns>
        Task<IDocumentContent> GetDocumentContentAsContentAsync();
    }
}