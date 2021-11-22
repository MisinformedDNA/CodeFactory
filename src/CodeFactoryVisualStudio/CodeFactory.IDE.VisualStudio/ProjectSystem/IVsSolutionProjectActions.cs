//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Project actions that are supported by the loaded solution.
    /// </summary>
    public interface IVsSolutionProjectActions
    {
        /// <summary>
        /// Gets the projects for the solution.
        /// </summary>
        /// <param name="allChildren">Optional parameter that determines if all projects should be retrieved not just the projects housed directly at the solution level.If true this will include projects hosted in solution folders. The default value is true.</param>
        /// <returns>Returns all the projects that are part of the solution. Will return an empty list if no projects are found.</returns>
        Task<IReadOnlyList<VsProject>> GetProjectsAsync(bool allChildren = true);

        /// <summary>
        /// Gets a target project from the solution by the name of the project.
        /// </summary>
        /// <param name="name">The name of the project to get from the solution.</param>
        /// <returns>The located project model or null if the project could not be found.</returns>
        Task<VsProject> GetProjectByName(string name);
    }
}