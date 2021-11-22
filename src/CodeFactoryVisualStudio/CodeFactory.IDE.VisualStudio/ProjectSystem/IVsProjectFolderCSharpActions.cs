//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Project folder actions that directly support C# implementation in a project folder.
    /// </summary>
    public interface IVsProjectFolderCSharpActions
    {
        /// <summary>
        /// Gets the target namespace for a document that support c# language to be placed in this folder. 
        /// </summary>
        /// <param name="source">The project folder model to get the namespace for.</param>
        /// <returns>The fully qualified namespace if the project is a c# project that supports this project folder. Otherwise null will be returned.</returns>
        Task<string> GetCSharpNamespaceAsync(VsProjectFolder source);

        /// <summary>
        /// Searches a project folder for a C# document that implements the target class name. 
        /// </summary>
        /// <param name="source">The source project folder to search in.</param>
        /// <param name="name">The name of the class to search for in the project folder.</param>
        /// <param name="allLevels">Optional parameter that determines if all sub folders will be searched for classes with the same name. The default is false.</param>
        /// <returns>List of the found c# documents that contain the class, or an empty list if no documents were found.</returns>
        Task<IReadOnlyList<VsDocumentCSharp>> FindCSharpDocumentsByClassNameAsync(VsProjectFolder source, string name,
            bool allLevels = false);

        /// <summary>
        /// Searches a project folder for a C# document that implements the target interface name. 
        /// </summary>
        /// <param name="source">The source project folder to search in.</param>
        /// <param name="name">The name of the interface to search for in the project folder.</param>
        /// <param name="allLevels">Optional parameter that determines if all sub folders will be searched for interfaces with the same name. The default is false.</param>
        /// <returns>List of the found c# documents that contain the interface, or an empty list if no documents were found.</returns>
        Task<IReadOnlyList<VsDocumentCSharp>> FindCSharpDocumentsByInterfaceNameAsync(VsProjectFolder source, string name,
            bool allLevels = false);

        /// <summary>
        /// Gets the C# documents hosted in the project folder.
        /// </summary>
        /// <param name="source">The source project folder to search for C# documents.</param>
        /// <param name="allLevels">Optional parameter that determines if documents should be gathered from project folders also. Default is false.</param>
        /// <returns>List of the C# documents hosted in the project, or an empty list if there are no documents.</returns>
        Task<IReadOnlyList<VsDocumentCSharp>> GetCSharpDocumentsAsync (VsProjectFolder source, bool allLevels = false);
    }
}