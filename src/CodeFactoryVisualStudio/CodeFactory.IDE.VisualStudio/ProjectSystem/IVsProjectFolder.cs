//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Definition of a visual studio project folder model information.
    /// </summary>
    public interface IVsProjectFolder:IVsProjectSystemModel,IParent,IChildren
    {
        /// <summary>
        /// the fully qualified path to the project folder.
        /// </summary>
        string Path { get;}
    }
}
