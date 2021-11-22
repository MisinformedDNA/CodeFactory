//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using CodeFactory.SourceCode;

namespace CodeFactory.Language.CSharp
{
    /// <summary>
    /// Model definition for an attribute in a c# implementation.
    /// </summary>
    public interface ICsAttribute:ICsModel,IParent,ISourceFiles
    {

        /// <summary>
        ///     The type information for the attribute itself.
        /// </summary>
        ICsType Type { get; }

        /// <summary>
        ///     Flag that determines if the attribute has parameters
        /// </summary>
        bool HasParameters { get; }

        /// <summary>
        ///     Enumeration of the parameters that are assigned to the attribute. This will be an empty list if HasParameters is false.
        /// </summary>
        IReadOnlyList<ICsAttributeParameter> Parameters { get; }

        /// <summary>
        /// Gets a <see cref="ICsModel"/> from the currently loaded source code. 
        /// </summary>
        /// <param name="lookupPath">The fully qualified path to the model to be loaded.</param>
        /// <returns>The loaded model or null if the model could not be found.</returns>
        ICsModel GetModel(string lookupPath);
    }
}
