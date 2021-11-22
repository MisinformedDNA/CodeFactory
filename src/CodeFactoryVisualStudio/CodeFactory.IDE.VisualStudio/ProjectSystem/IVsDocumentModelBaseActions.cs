//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{    
    /// <summary>
    /// Visual studio actions that support the <see cref="VsDocument"/> model.
    /// </summary>
    public interface IVsDocumentModelBaseActions:IVsBaseActions
    {
        /// <summary>
        /// Actions that support the model.
        /// </summary>
        IVsDocumentModelActions Model { get; }
        
    }
}
