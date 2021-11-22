//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Threading.Tasks;
using CodeFactory.Document;
using CodeFactory.SourceCode;

namespace CodeFactory.Language.CSharp{
    /// <summary>
    /// Model that represents a using statement in a C# source model. 
    /// </summary>
    public interface ICsUsingStatement:ICsModel,IParent,ILookup
    {
        
        /// <summary>
        /// The target namespace that is being imported into the sources scope.
        /// </summary>
        string ReferenceNamespace { get; }

        /// <summary>
        /// Flag that determines if the namespace reference has an alias.
        /// </summary>
        bool HasAlias { get; }

        /// <summary>
        /// The alias assigned to the namespace being imported. This will be null if the <see cref="HasAlias"/> is false. 
        /// </summary>
        string Alias { get; }

        /// <summary>
        /// Gets a <see cref="ICsModel"/> from the currently loaded source code. 
        /// </summary>
        /// <param name="lookupPath">The fully qualified path to the model to be loaded.</param>
        /// <returns>The loaded model or null if the model could not be found.</returns>
        ICsModel GetModel(string lookupPath);
    }
}
