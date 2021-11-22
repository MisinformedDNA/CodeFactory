using System.Collections.Generic;
using CodeFactory.IDE.VisualStudio.Language.CSharp;
using CodeFactory.SourceCode;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Data model that represents a project system document that hosts C# source code.
    /// </summary>
    public abstract class VsDocumentCSharp:VsDocument,IVsDocumentCSharp
    {
        private readonly CsSource _sourceCode;

        /// <summary>
        /// Constructor for the base class <see cref="VsDocumentCSharp"/>
        /// </summary>
        /// <param name="isLoaded">Flag that determines if the model is loaded.</param>
        /// <param name="hasErrors">Flag that determines if errors occurred while loading the model.</param>
        /// <param name="modelErrors">The list of errors that occurred if any.</param>
        /// <param name="name">The name of the model.</param>
        /// <param name="hasParent">Flag that determines if this model has a parent model.</param>
        /// <param name="hasChildren">Flag that determines if this model has child models.</param>
        /// <param name="path">The fully qualified path to the document.</param>
        /// <param name="documentType">The type of visual studio document.</param>
        /// <param name="isSourceCode">Is a source code file loadable by code factory.</param>
        /// <param name="sourceType">The type of source code found in the document.</param>
        /// <param name="sourceCode">The C# source code that makes up the content of the document.</param>
        protected VsDocumentCSharp(bool isLoaded, bool hasErrors, IReadOnlyList<ModelException<ProjectSystemModelType>> modelErrors, string name, IVsDocumentModelBaseActions actions, bool hasParent, bool hasChildren, 
            string path, VsDocumentType documentType, bool isSourceCode, SourceCodeType sourceType,CsSource sourceCode) 
            : base(isLoaded, hasErrors, modelErrors, name,actions, hasParent, hasChildren, path, documentType, isSourceCode, sourceType, ProjectSystemModelType.DocumentCSharp)
        {
            _sourceCode = sourceCode;
        }

        /// <summary>
        /// The C# source in the document.
        /// </summary>
        public CsSource SourceCode => _sourceCode;
    }
}