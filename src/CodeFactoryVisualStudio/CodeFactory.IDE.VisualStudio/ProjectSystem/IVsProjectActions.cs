//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Visual studio actions that support the <see cref="IVsProject"/> model.
    /// </summary>
    public interface IVsProjectActions
    {

        /// <summary>
        /// Get all the children that are direct children of the project.
        /// </summary>
        /// <param name="source">the project to get the children from.</param>
        /// <param name="allChildren">Optional flag that determines if it should return all children of the project and not just the top level children. The default value is false.</param>
        /// <returns>The children of the project, if no children are found and empty enumeration will be returned.</returns>
        Task<IReadOnlyList<VsProjectSystemModel>> GetChildrenAsync(VsProject source, bool allChildren = false);

        /// <summary>
        /// Project actions that support documents that are hosted in the project.
        /// </summary>
        IVsProjectDocumentsActions Document { get; }

        /// <summary>
        /// Project actions that support project and solution folders associated with the project.
        /// </summary>
        IVsProjectSolutionFolderActions Folder { get; }

        /// <summary>
        /// Project actions that support references or other projects referenced by the project.
        /// </summary>
        IVsProjectReferenceActions Reference { get; }

        /// <summary>
        /// Project actions that support the CSharp Language.
        /// </summary>
        IVsProjectCSharpActions CSharp { get; }

    }
}
