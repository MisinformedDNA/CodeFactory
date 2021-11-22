//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Actions that can be used with the a <see cref="VsSolution"/> model.
    /// </summary>
    public interface IVsSolutionActions
    {
        /// <summary>
        /// Gets the current loaded solution.
        /// </summary>
        /// <returns>The currently loaded solution.</returns>
        Task<VsSolution> GetSolutionAsync();

        /// <summary>
        /// Gets the solution folders and projects that belong to the solution. 
        /// </summary>
        /// <param name="allChildren">Get all children not just the first children of the solution.</param>
        /// <returns>Returns a readonly list of the children to the solution. If there are no children an empty list will be returned.</returns>
        Task<IReadOnlyList<VsProjectSystemModel>> GetChildrenAsync(bool allChildren);

        /// <summary>
        /// Solution folder actions that are supported by the hosting solution.
        /// </summary>
        IVsSolutionSolutionFolderActions Folder { get; }

        /// <summary>
        /// Project actions that are supported by the hosting solution.
        /// </summary>
        IVsSolutionProjectActions Project { get; }

        /// <summary>
        /// Solution actions that support c# documents that are hosted in the solution.
        /// </summary>
        IVsSolutionCSharpActions CSharp { get; }


    }
}
