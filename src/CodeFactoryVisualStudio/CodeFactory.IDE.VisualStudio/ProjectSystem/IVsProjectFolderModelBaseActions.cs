//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Visual studio actions that support the <see cref="IVsProjectFolder"/> model.
    /// </summary>
    public interface IVsProjectFolderModelBaseActions:IVsBaseActions
    {
        /// <summary>
        /// Actions that support the model.
        /// </summary>
        IVsProjectFolderModelActions Model { get; }
    }
}
