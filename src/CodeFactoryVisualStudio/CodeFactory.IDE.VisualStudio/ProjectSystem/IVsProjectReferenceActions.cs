//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Project actions that support references and external projects referenced by a target project.
    /// </summary>
    public interface IVsProjectReferenceActions
    {
        /// <summary>
        /// Gets the references assigned to this project.
        /// </summary>
        /// <param name="source">The source project to get the references from.</param>
        /// <returns>Readonly list of the references.</returns>
        Task<IReadOnlyList<VsReference>> GetReferencesAsync(VsProject source);

        /// <summary>
        /// Searches a project for a reference by name and returns it if found.
        /// </summary>
        /// <param name="source">Source project to get the reference from.</param>
        /// <param name="name">The name of the project to search for.</param>
        /// <returns>The reference if found otherwise will return null.</returns>
        Task<VsReference> GetReferenceAsync(VsProject source, string name);

        /// <summary>
        /// Get the <see cref="VsProject"/> models for all projects that are referenced by this project.
        /// </summary>
        /// <param name="source">Source project to get referenced projects from.</param>
        /// <returns>Readonly list of the referenced projects or an empty list if there is no referenced projects.</returns>
        Task<IReadOnlyList<VsProject>> GetReferencedProjects(VsProject source);
    }
}