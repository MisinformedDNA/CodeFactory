//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeFactory.Language.CSharp;
using CodeFactory.SourceCode;

namespace CodeFactory.IDE.VisualStudio.Language.CSharp{
    /// <summary>
    /// The base implementation all container type models must implement in C#.
    /// </summary>
    public interface ICsContainer: ICsModel,ISourceFiles,ICsAttributes,IDocumentation,ICsGeneric,IParent,ILookup
    {
        /// <summary>
        /// The type of container model that has been implemented.
        /// </summary>
        CsContainerType ContainerType { get; }

        /// <summary>
        ///     The name of the container.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     The namespace the container objects belongs to.
        /// </summary>
        string Namespace { get; }

        /// <summary>
        ///     The security scope assigned to the container.
        /// </summary>
        CsSecurity Security { get; }

        /// <summary>
        ///     List of the interfaces that are inherited by this container.
        /// </summary>
        IReadOnlyList<CsInterface> InheritedInterfaces { get; }

        /// <summary>
        ///     List of the members that are implemented in this container.
        /// </summary>
        IReadOnlyList<CsMember> Members { get; }

        /// <summary>
        ///     List of the methods that are implemented in this container.
        /// </summary>
        IReadOnlyList<CsMethod> Methods { get; }

        /// <summary>
        ///     List of the properties that are implemented in this container.
        /// </summary>
        IReadOnlyList<CsProperty> Properties { get; }

        /// <summary>
        ///     Enumeration of the events assigned to this container. If HasEvents is false this will be null.
        /// </summary>
        IReadOnlyList<CsEvent> Events { get; }

        /// <summary>
        /// The source code syntax that is stored in the body of the container model. This will be null if the container was not loaded from source code.
        /// </summary>
        Task<string> GetBodySyntaxAsync();

        /// <summary>
        /// Gets a <see cref="ICsModel"/> from the currently loaded source code. 
        /// </summary>
        /// <param name="lookupPath">The fully qualified path to the model to be loaded.</param>
        /// <returns>The loaded model or null if the model could not be found.</returns>
        CsModel GetModel(string lookupPath);
    }
}
