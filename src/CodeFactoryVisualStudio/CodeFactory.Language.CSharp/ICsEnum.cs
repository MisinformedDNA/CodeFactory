//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using CodeFactory.SourceCode;

namespace CodeFactory.Language.CSharp
{
    /// <summary>
    /// Data model that provides information on an enumeration.
    /// </summary>
    public interface ICsEnum : ICsModel, ICsAttributes, IDocumentation, IParent, ILookup, ISourceFiles
    {
        /// <summary>
        ///     The name of the enumeration.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     The namespace the enumeration belongs to.
        /// </summary>
        string Namespace { get; }

        /// <summary>
        ///     The security scope assigned to the enumeration.
        /// </summary>
        CsSecurity Security { get; }

        /// <summary>
        ///     List of the enumeration values implemented in this enumeration.
        /// </summary>
        IReadOnlyList<ICsEnumValue> Values { get; }
    }
}
