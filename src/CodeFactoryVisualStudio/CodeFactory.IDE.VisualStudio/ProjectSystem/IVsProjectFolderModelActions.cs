//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Visual studio actions that support the <see cref="IVsProjectFolder"/> model.
    /// </summary>
    public interface IVsProjectFolderModelActions
    {
        /// <summary>
        /// Search related actions that support the project folder.
        /// </summary>
        IVsProjectFolderModelSearchActions Search { get; }

        /// <summary>
        /// Actions for editing a Visual Studio project folder.
        /// </summary>
        IVsProjectFolderModelEditActions Edit { get; }

        /// <summary>
        /// Actions that support C# documents in the project folder.
        /// </summary>
        IVsProjectFolderModelCSharpActions CSharp { get; }

    }
}
