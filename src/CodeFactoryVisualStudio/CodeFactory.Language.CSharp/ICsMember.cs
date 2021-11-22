//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Threading.Tasks;
using CodeFactory.Document;
using CodeFactory.SourceCode;

namespace CodeFactory.Language.CSharp{
    /// <summary>
    /// Base definition for all c# member models.
    /// </summary>
    public interface ICsMember:ICsModel,ISourceFiles,ICsAttributes,IDocumentation,IParent,ILookup
    {
        /// <summary>
        ///     The name assigned to the member.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     The security scope that has been assigned to the member.
        /// </summary>
        CsSecurity Security { get; }

        /// <summary>
        /// The type of member the model is.
        /// </summary>
        CsMemberType MemberType { get; }

        /// <summary>
        /// Gets a <see cref="ICsModel"/> from the currently loaded source code. 
        /// </summary>
        /// <param name="lookupPath">The fully qualified path to the model to be loaded.</param>
        /// <returns>The loaded model or null if the model could not be found.</returns>
        ICsModel GetModel(string lookupPath);
    }
}
