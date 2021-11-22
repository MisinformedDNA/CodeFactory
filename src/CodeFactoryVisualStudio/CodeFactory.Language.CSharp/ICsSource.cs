//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

using System.Collections.Generic;

namespace CodeFactory.Language.CSharp
{
    /// <summary>
    /// Source definition from a source that was written in C#.
    /// </summary>
    public interface ICsSource : ICsModel, IParent
    {
        /// <summary>
        /// The namespaces that are used as references to access other libraries not hosted in the source document.
        /// </summary>
        IReadOnlyList<ICsUsingStatement> NamespaceReferences { get; }

        /// <summary>
        /// The interfaces that were defined in the source.
        /// </summary>
        IReadOnlyList<ICsInterface> Interfaces { get; }

        /// <summary>
        /// The classes that were defined in the source.
        /// </summary>
        IReadOnlyList<ICsClass> Classes { get; }

        /// <summary>
        /// The structures that were defined in the source.
        /// </summary>
        IReadOnlyList<ICsStructure> Structures { get; }

        /// <summary>
        /// The delegates that were defined in the source.
        /// </summary>
        IReadOnlyList<ICsDelegate> Delegates { get; }

        /// <summary>
        /// The enumerations that were defined in the source.
        /// </summary>
        IReadOnlyList<ICsEnum> Enums { get; }

        /// <summary>
        /// The namespaces that were defined in the source.
        /// </summary>
        IReadOnlyList<ICsNamespace> Namespaces { get; }

        /// <summary>
        /// Gets a <see cref="ICsModel"/> from the currently loaded source code. 
        /// </summary>
        /// <param name="lookupPath">The fully qualified path to the model to be loaded.</param>
        /// <returns>The loaded model or null if the model could not be found.</returns>
        ICsModel GetModel(string lookupPath);
    }
}
