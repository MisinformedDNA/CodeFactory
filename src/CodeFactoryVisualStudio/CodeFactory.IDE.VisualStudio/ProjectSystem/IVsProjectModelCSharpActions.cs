//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Visual Studio actions at the project level that support the C# language.
    /// </summary>
    public interface IVsProjectModelCSharpActions
    {
        /// <summary>
        /// Gets a list of csharp documents that implement the target class name.
        /// </summary>
        /// <param name="name">Target class name to search in all solution projects.</param>
        /// <param name="targetNamespace">Optional parameter to filter the namespace or sub namespace the class should belong to.</param>
        /// <returns>List of documents containing the class, or an empty list if no documents are found.</returns>
        Task<IReadOnlyList<VsDocumentCSharp>> GetCSharpDocumentByClassNameAsync ( string name, string targetNamespace = null);

        /// <summary>
        /// Gets a list of csharp documents that implement the target interface name.
        /// </summary>
        /// <param name="name">Target interface name to search in all solution projects.</param>
        /// <param name="targetNamespace">Optional parameter to filter the namespace or sub namespace the class should belong to.</param>
        /// <returns>List of documents containing the interface, or an empty list if no documents are found.</returns>
        Task<IReadOnlyList<VsDocumentCSharp>> GetCSharpDocumentByInterfaceNameAsync (string name, string targetNamespace = null);

        /// <summary>
        /// Gets the C# documents hosted in the project.
        /// </summary>
        /// <param name="source">The source project to search for C# documents.</param>
        /// <param name="allLevels">Optional parameter that determines if documents should be gathered from project folders also. Default is false.</param>
        /// <returns>List of the C# documents hosted in the project, or an empty list if there are no documents.</returns>
        Task<IReadOnlyList<VsDocumentCSharp>> GetCSharpDocumentsAsync (bool allLevels = false);
    }
}