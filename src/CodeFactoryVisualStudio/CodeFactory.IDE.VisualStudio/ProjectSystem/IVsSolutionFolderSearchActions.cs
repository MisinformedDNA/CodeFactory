//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2020 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Visual studio actions that support the <see cref="IVsSolutionFolder"/> model.
    /// </summary>
    public interface IVsSolutionFolderSearchActions
    {
        /// <summary>
        /// Gets the parent solution folder.
        /// </summary>
        /// <param name="source">The solution folder to find the parent for.</param>
        /// <returns>The parent solution folder model or null if there is no parent for this solution folder.</returns>
        Task<VsSolutionFolder> GetParentAsync(VsSolutionFolder source);

        /// <summary>
        /// Gets the children of the solution folder, this will return the files and projects that are part of the solution folder.
        /// </summary>
        /// <param name="source">The solution folder to get the children from.</param>
        /// <param name="allChildren">Flag that determines if all the direct children of the solution folder should also get there children.</param>
        /// <returns>Returns a readonly list of the children within this solution folder. Will return an empty list if there is no children.</returns>
        Task<IReadOnlyList<VsProjectSystemModel>> GetChildrenAsync(VsSolutionFolder source, bool allChildren);

        /// <summary>
        /// Gets all solution folders that are a child of this solution folder.
        /// </summary>
        /// <param name="source">The solution folder to get the children from.</param>
        /// <param name="allChildren">Optional parameters that determines if all child solution folders should be returned including sub folders. Default value is true.</param>
        /// <returns>Returns a readonly list of the child solution folders. Will return an empty list if there is no children.</returns>
        Task<IReadOnlyList<IVsSolutionFolder>> GetChildFoldersAsync(VsSolutionFolder source, bool allChildren = true);


    }
}
