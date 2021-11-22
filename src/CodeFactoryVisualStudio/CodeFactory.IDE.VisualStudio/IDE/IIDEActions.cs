//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

namespace CodeFactory.IDE.VisualStudio.IDE
{
    /// <summary>
    /// CodeFactory actions for global functions on the IDE.
    /// </summary>
    public interface IIDEActions
    {
        /// <summary>
        /// Actions that support sending output directly to the IDE.
        /// </summary>
        IIDEOutputActions Output { get; }

    }
}