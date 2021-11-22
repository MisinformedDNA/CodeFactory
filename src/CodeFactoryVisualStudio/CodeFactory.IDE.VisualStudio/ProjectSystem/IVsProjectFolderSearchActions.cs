//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Search related actions for a project folder.
    /// </summary>
    public interface IVsProjectFolderSearchActions
    {
        /// <summary>
        /// Gets the parent visual studio model that is the parent of this project folder.
        /// </summary>
        /// <param name="source">The project folder to get the parent.</param>
        /// <returns>The visual studio model of the parent or null if the project folder does not have a parent.</returns>
        Task<VsProjectSystemModel> GetParentAsync(VsProjectFolder source);

        /// <summary>
        /// Gets the <see cref="VsProjectSystemModel"/> of the items that are direct children of this project folder.
        /// </summary>
        /// <param name="source">The project folder to get children from.</param>
        /// <param name="allChildren">Optional flag that determines if models under sub folders will also be returned, by default this is false.</param>
        /// <returns>Readonly list of the children that belong to this project folder. If no children are found an empty list will be returned. </returns>
        Task<IReadOnlyList<VsProjectSystemModel>> GetChildrenAsync(VsProjectFolder source, bool allChildren = false);   

        /// <summary>
        /// Gets the <see cref="VsDocument"/> of the items that are direct children of this project folder.
        /// </summary>
        /// <param name="source">The project folder to get the documents from.</param>
        /// <param name="allChildren">Optional flag that determines if document models under sub folders will also be returned, by default this is false.</param>
        /// <returns>Readonly list of the child documents that belong to this project folder. If no children are found an empty list will be returned. </returns>
        Task<IReadOnlyList<VsDocument>> GetDocumentsAsync(VsProjectFolder source, bool allChildren = false);   

        /// <summary>
        /// Gets the <see cref="VsProjectFolder"/> of the items that are direct children of this project folder.
        /// </summary>
        /// <param name="source">The project folder to get the folders from.</param>
        /// <param name="allChildren">Optional flag that determines if folder models under sub folders will also be returned, by default this is false.</param>
        /// <returns>Readonly list of the child folders that belong to this project folder. If no children are found an empty list will be returned. </returns>
        Task<IReadOnlyList<VsDocument>> GetFoldersAsync(VsProjectFolder source, bool allChildren = false);   
    }
}