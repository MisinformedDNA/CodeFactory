//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Threading.Tasks;
using CodeFactory.Document;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Visual Studio actions for editing the contents of a visual studio hosted document.
    /// </summary>
    public interface IVsDocumentModelEditActions
    {
        /// <summary>
        /// Deletes the document.
        /// </summary>
        /// <remarks>Currently does not support deleting solution documents.</remarks>
        /// <returns>Flag that notifies if the delete operation completed successfully.</returns>
        Task<bool> DeleteAsync();

        /// <summary>
        /// Removes a document from visual studio but does not remove it from the file system. 
        /// </summary>
        /// <remarks>Currently does not support removing solution documents.</remarks>
        /// <returns>Flag that notifies if the remove operation completed successfully.</returns>
        Task<bool> RemoveAsync();

        /// <summary>
        /// Adds content to the beginning of a document.
        /// </summary>
        /// <param name="content">The content to be added.</param>
        Task AddContentToBeginningAsync( string content);

        /// <summary>
        /// Adds content to the end of a document.
        /// </summary>
        /// <param name="content">The content to be added.</param>
        Task AddContentToEndAsync(string content);

        /// <summary>
        /// Adds content to a target starting at an assigned
        /// </summary>
        /// <param name="location">Location within the document to add content to.</param>
        /// <param name="content">The content to be added to the document.</param>
        Task AddContentAsync(IDocumentLocation location, string content);

        /// <summary>
        /// Removes all the content from a document.
        /// </summary>
        Task RemoveContentAsync();

        /// <summary>
        /// Removes a target set of content from the document.
        /// </summary>
        /// <param name="startLocation">The starting position within the document to remove content from.</param>
        /// <param name="endLocation">The ending position within the document to remove content form.</param>
        /// <returns></returns>
        Task RemoveContentAsync(IDocumentLocation startLocation, IDocumentLocation endLocation);

        /// <summary>
        /// Replaces all the content within the document.
        /// </summary>
        /// <param name="content">Content to replace the existing content in the document.</param>
        Task ReplaceContentAsync(string content);

        /// <summary>
        /// Replaces all the content within the document.
        /// </summary>
        /// <param name="content">Content to replace the existing content in the document.</param>
        /// <param name="startLocation">The starting position within the document to replace content.</param>
        /// <param name="endLocation">The ending location within the document to replace content.</param>
        Task ReplaceContentAsync(string content,IDocumentLocation startLocation, IDocumentLocation endLocation);
    }
}