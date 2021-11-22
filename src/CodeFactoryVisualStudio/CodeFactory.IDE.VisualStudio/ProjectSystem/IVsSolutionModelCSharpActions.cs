//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Solution actions that support C# documents hosted in the solution.
    /// </summary>
    public interface IVsSolutionModelCSharpActions
    {
        /// <summary>
        /// Gets a list of csharp documents that implement the target class name.
        /// </summary>
        /// <param name="name">Target class name to search in all solution projects.</param>
        /// <param name="targetNamespace">Optional parameter to filter the namespace or sub namespace the class should belong to.</param>
        /// <returns>List of documents containing the class, or an empty list if no documents are found.</returns>
        Task<List<VsDocumentCSharp>> GetCSharpDocumentByClassNameAsync(string name, string targetNamespace = null);

        /// <summary>
        /// Gets a list of csharp documents that implement the target interface name.
        /// </summary>
        /// <param name="name">Target interface name to search in all solution projects.</param>
        /// <param name="targetNamespace">Optional parameter to filter the namespace or sub namespace the class should belong to.</param>
        /// <returns>List of documents containing the interface, or an empty list if no documents are found.</returns>
        Task<List<VsDocumentCSharp>> GetCSharpDocumentByInterfaceNameAsync(string name, string targetNamespace = null);
    }
}