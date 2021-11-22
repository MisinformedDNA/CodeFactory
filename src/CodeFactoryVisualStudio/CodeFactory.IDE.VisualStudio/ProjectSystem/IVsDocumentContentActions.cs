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
    public interface IVsDocumentContentActions
    {
        /// <summary>
        /// Gets the content of the document.
        /// </summary>
        /// <param name="source">The document to get content from.</param>
        /// <returns>The content of the document or null if there is no content in the document.</returns>
        Task<string> GetDocumentContentAsStringAsync(VsDocument source);

        /// <summary>
        /// Gets the content of the document.
        /// </summary>
        /// <param name="source">The document to get content from.</param>
        /// <param name="startLocation">The starting position within the document to get content from.</param>
        /// <param name="endLocation">The ending position within the document to get content form.</param>
        /// <returns>The content of the document or null if there is no content in the document.</returns>
        Task<string> GetDocumentContentAsStringAsync(VsDocument source, IDocumentLocation startLocation, IDocumentLocation endLocation);

        /// <summary>
        /// Gets the content of the document.
        /// </summary>
        /// <param name="source">The document to get content from.</param>
        /// <returns>Document content as </returns>
        Task<IDocumentContent> GetDocumentContentAsContentAsync(VsDocument source);
    }
}