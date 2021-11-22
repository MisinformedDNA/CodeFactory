//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using CodeFactory.SourceCode;

namespace CodeFactory.Language.CSharp
{
    /// <summary>
    /// Data model that provides information to a specific enumeration value implemented in an enumeration.
    /// </summary>
    public interface ICsEnumValue : ICsModel, ICsAttributes, IDocumentation, IParent, ILookup, ISourceFiles
    {
        /// <summary>
        ///     The name of the enumeration value.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     The security scope assigned to the enumeration value.
        /// </summary>
        CsSecurity Security { get; }

        /// <summary>
        ///     The value that has been assigned to the enumeration value.
        /// </summary>
        string Value { get; }

        /// <summary>
        /// Gets a <see cref="ICsModel"/> from the currently loaded source code. 
        /// </summary>
        /// <param name="lookupPath">The fully qualified path to the model to be loaded.</param>
        /// <returns>The loaded model or null if the model could not be found.</returns>
        ICsModel GetModel(string lookupPath);
    }
}
