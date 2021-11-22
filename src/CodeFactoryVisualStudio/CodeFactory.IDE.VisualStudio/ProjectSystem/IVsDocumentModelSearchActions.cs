//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{    
    /// <summary>
    /// Visual studio actions that support searching that supports the <see cref="VsDocument"/> and supporting models.
    /// </summary>
    public interface IVsDocumentModelSearchActions
    {
        /// <summary>
        /// Get the parent visual studio model of the document. 
        /// </summary>
        /// <returns>Model of the parent of this document. The model will be returned unless there is no parent, otherwise null will be returned.</returns>
        Task<VsProjectSystemModel> GetParentAsync();

        /// <summary>
        /// Gets the direct children of the document.
        /// </summary>
        /// <param name="allChildren">Flag that determines if all children from the document should be returned.</param>
        /// <returns>Readonly list of all the project documents, if no children are found then an empty readonly list will be returned.</returns>
        Task<IReadOnlyList<VsDocument>> GetChildrenAsync(bool allChildren);

    }
}
