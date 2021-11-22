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
    public interface IVsProjectModelReferenceActions
    {
        /// <summary>
        /// Gets the references assigned to this project.
        /// </summary>
        /// <returns>Readonly list of the references.</returns>
        Task<IReadOnlyList<VsReference>> GetReferencesAsync();

        /// <summary>
        /// Searches a project for a reference by name and returns it if found.
        /// </summary>
        /// <param name="name">The name of the project to search for.</param>
        /// <returns>The reference if found otherwise will return null.</returns>
        Task<VsReference> GetReferenceAsync(string name);

        /// <summary>
        /// Get the <see cref="VsProject"/> models for all projects that are referenced by this project.
        /// </summary>
        /// <returns>Readonly list of the referenced projects or an empty list if there is no referenced projects.</returns>
        Task<IReadOnlyList<VsProject>> GetReferencedProjects();
    }
}