//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

using CodeFactory.SourceCode;

namespace CodeFactory.Language.CSharp
{
    /// <summary>
    /// Model definition for a namespace of the C# model.
    /// /// </summary>
    public interface ICsNamespace:ICsModel,IParent,ILookup,ISourceFiles
    {
        /// <summary>
        /// The name of the namespace.
        /// </summary>
        string Name { get; }
    }
}
