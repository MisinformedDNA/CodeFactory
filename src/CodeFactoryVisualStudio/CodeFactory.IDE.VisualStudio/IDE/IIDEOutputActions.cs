//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.IDE
{
    /// <summary>
    /// Actions that support writing output information directly to the IDE.
    /// </summary>
    public interface IIDEOutputActions
    {
        /// <summary>
        /// Writes a formatted message to the CodeFactory output window.
        /// </summary>
        /// <param name="message">Message to display in the output window.</param>
        Task WriteToCodeFactoryOutputWindow(string message);
    }
}
