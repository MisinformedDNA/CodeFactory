//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2020 CodeFactory, LLC
//*****************************************************************************

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Visual studio actions that support the <see cref="IVsProjectFolder"/> model.
    /// </summary>
    public interface IVsProjectFolderActions
    {
        /// <summary>
        /// Search related actions that support the project folder.
        /// </summary>
        IVsProjectFolderSearchActions Search { get; }

        /// <summary>
        /// Actions for editing a Visual Studio project folder.
        /// </summary>
        IVsProjectFolderEditActions Edit { get; }

        /// <summary>
        /// Actions that support C# documents in the project folder.
        /// </summary>
        IVsProjectFolderCSharpActions CSharp { get; }

    }
}
