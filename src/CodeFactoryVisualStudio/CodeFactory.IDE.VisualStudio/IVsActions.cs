//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

using CodeFactory.IDE.VisualStudio.IDE;
using CodeFactory.IDE.VisualStudio.ProjectSystem;
using CodeFactory.IDE.VisualStudio.UserInterface;

namespace CodeFactory.IDE.VisualStudio
{
    /// <summary>
    /// Definition of the Visual Studio actions that are supported by code factory. 
    /// </summary>
    public interface IVsActions
    {

        /// <summary>
        /// Solution based commands that support the solution in Visual Studio.
        /// </summary>
        IVsSolutionActions Solution { get; }

        /// <summary>
        /// Project system commands that support projects in Visual Studio.
        /// </summary>
        IVsProjectActions Project { get;  }

        /// <summary>
        /// Project folder commands that support a project folder in a project in Visual Studio.
        /// </summary>
        IVsProjectFolderActions ProjectFolder { get; }

        /// <summary>
        /// Document commands that support a document hosted in a project, project folder, or a solution folder.
        /// </summary>
        IVsDocumentActions Document { get;  }

        /// <summary>
        /// User interface integration into Visual Studio. Focuses on creation and display of custom dialogs in Visual Studio.
        /// </summary>
        IVsUserInterfaceActions UserInterface { get; }

        /// <summary>
        /// Functionality access the Visual Studio IDE itself.
        /// </summary>
        IIDEActions IDE { get;  }

    }
}
