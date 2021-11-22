//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{    
    /// <summary>
    /// Visual studio actions that support the <see cref="VsDocument"/> model.
    /// </summary>
    public interface IVsDocumentModelActions
    {
        /// <summary>
        /// Actions that support searching for a <see cref="VsDocument"/> and supporting models.
        /// </summary>
        IVsDocumentModelSearchActions Search { get; }

        /// <summary>
        /// Actions that support getting the content from a Visual Studio hosted document.
        /// </summary>
        IVsDocumentModelContentActions Content { get; }

        /// <summary>
        /// Actions that support the editing of a Visual Studio hosted document.
        /// </summary>
        IVsDocumentModelEditActions Edit { get; }
        
    }
}
