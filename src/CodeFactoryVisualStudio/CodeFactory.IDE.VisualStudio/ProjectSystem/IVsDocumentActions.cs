//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{    
    /// <summary>
    /// Visual studio actions that support the <see cref="VsDocument"/> model.
    /// </summary>
    public interface IVsDocumentActions
    {
        /// <summary>
        /// Actions that support searching for a <see cref="VsDocument"/> and supporting models.
        /// </summary>
        IVsDocumentSearchActions Search { get; }

        /// <summary>
        /// Actions that support getting the content from a Visual Studio hosted document.
        /// </summary>
        IVsDocumentContentActions Content { get; }

        /// <summary>
        /// Actions that support the editing of a Visual Studio hosted document.
        /// </summary>
        IVsDocumentEditActions Edit { get; }
        
    }
}
