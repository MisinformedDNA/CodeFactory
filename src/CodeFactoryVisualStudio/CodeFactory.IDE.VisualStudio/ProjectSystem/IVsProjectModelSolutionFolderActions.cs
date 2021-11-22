//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Project actions that support both solution and project folders from a target project.
    /// </summary>
    public interface IVsProjectModelSolutionFolderActions
    {
        /// <summary>
        /// Adds a project folder to the root of the project.
        /// </summary>
        /// <param name="folderName">The name of the project folder. This should be the name only with no path.</param>
        /// <returns>The created project folder.</returns>
        Task<VsProjectFolder> AddProjectFolderAsync(string folderName);

        /// <summary>
        /// Gets project folders in the target project.
        /// </summary>
        /// <param name="allLevels">Optional parameter that will grab all the implemented folders not just the folders in the root of the project.</param>
        /// <returns>List of the project folders, or an empty list if no project folders were found.</returns>
        Task<IReadOnlyList<VsProjectFolder>> GetProjectFoldersAsync(bool allLevels = false);

        /// <summary>
        /// Gets the parent solution folder that holds the project.
        /// </summary>
        /// <param name="source">Project to get the parent for.</param>
        /// <returns>Returns a solution folder if the project has a parent or null if the project has no parent solution folder.</returns>
        Task<VsSolutionFolder> GetParenSolutionFolderAsync(VsProject source);
        
    }
}