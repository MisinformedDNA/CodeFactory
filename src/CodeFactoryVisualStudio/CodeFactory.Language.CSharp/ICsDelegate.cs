//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using CodeFactory.SourceCode;

namespace CodeFactory.Language.CSharp
{
    /// <summary>
    /// Model definition of a delegate in C#.
    /// </summary>
    public interface ICsDelegate:ICsModel,ICsAttributes,ICsGeneric,IDocumentation,IParent,ILookup,ISourceFiles
    {
        /// <summary>
        ///     The name assigned to the this item.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     The namespace the delegate is assigned to.
        /// </summary>
        string Namespace { get; }

        /// <summary>
        ///     The security scope that has been assigned to this item.
        /// </summary>
        CsSecurity Security { get; }

        /// <summary>
        ///     The type information about the return type assigned to the method.
        /// </summary>
        ICsType ReturnType { get; }

        /// <summary>
        ///     Flag that determines if the method has parameters assigned to it.
        /// </summary>
        bool HasParameters { get; }

        /// <summary>
        ///     List of the parameters that have been assigned to the delegate. If HasParameters property is set to false this will be an empty list.
        /// </summary>
        IReadOnlyList<ICsParameter> Parameters { get; }

        /// <summary>
        /// The invoke method definition for this delegate.
        /// </summary>
        ICsMethod InvokeMethod { get; }

        /// <summary>
        /// The begin invoke method definition for this delegate.
        /// </summary>
        ICsMethod BeginInvokeMethod { get; }

        /// <summary>
        /// The end invoke method definition for this delegate.
        /// </summary>
        ICsMethod EndInvokeMethod { get; }

        /// <summary>
        /// Flag that determines if the delegate return is a void.
        /// </summary>
        bool IsVoid { get; }

        /// <summary>
        /// Gets a <see cref="ICsModel"/> from the currently loaded source code. 
        /// </summary>
        /// <param name="lookupPath">The fully qualified path to the model to be loaded.</param>
        /// <returns>The loaded model or null if the model could not be found.</returns>
        ICsModel GetModel(string lookupPath);
    }
}
