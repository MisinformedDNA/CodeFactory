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
    public interface IVsProjectModelActions
    {

        /// <summary>
        /// Get all the children that are direct children of the project.
        /// </summary>
        /// <param name="allChildren">Optional Flag that determines if it should return all children of the project and not just the top level children. The default value is false.</param>
        /// <returns>The children of the project, if no children are found and empty list will be returned.</returns>
        Task<IReadOnlyList<VsProjectSystemModel>> GetChildrenAsync(bool allChildren = false);

        /// <summary>
        /// Project actions that support documents that are hosted in the project.
        /// </summary>
        IVsProjectModelDocumentsActions Document { get; }

        /// <summary>
        /// Project actions that support project and solution folders associated with the project.
        /// </summary>
        IVsProjectModelSolutionFolderActions Folder { get; }

        /// <summary>
        /// Project actions that support references or other projects referenced by the project.
        /// </summary>
        IVsProjectModelReferenceActions Reference { get; }

        /// <summary>
        /// Project actions that support the CSharp Language.
        /// </summary>
        IVsProjectModelCSharpActions CSharp { get; }

    }
}
