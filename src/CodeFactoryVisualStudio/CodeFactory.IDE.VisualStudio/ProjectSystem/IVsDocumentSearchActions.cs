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
    public interface IVsDocumentSearchActions
    {
        /// <summary>
        /// Get the parent visual studio model of the document. 
        /// </summary>
        /// <param name="source">document to get the parent of.</param>
        /// <returns>Model of the parent of this document. The model will be returned unless there is no parent, otherwise null will be returned.</returns>
        Task<VsProjectSystemModel> GetParentAsync(VsDocument source);

        /// <summary>
        /// Gets the direct children of the document.
        /// </summary>
        /// <param name="source">The document to get children from.</param>
        /// <param name="allChildren">Flag that determines if all children from the document should be returned.</param>
        /// <returns>Readonly list of all the project documents, if no children are found then an empty readonly list will be returned.</returns>
        Task<IReadOnlyList<VsDocument>> GetChildrenAsync(VsDocument source, bool allChildren);

    }
}
