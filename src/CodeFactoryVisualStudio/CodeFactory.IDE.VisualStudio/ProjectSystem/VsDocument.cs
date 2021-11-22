//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2020 CodeFactory, LLC
//*****************************************************************************

using System.Collections.Generic;
using System.Threading.Tasks;
using CodeFactory.Document;
using CodeFactory.SourceCode;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Data model that represents a document that is hosted in visual studio.
    /// </summary>
    public abstract class VsDocument:VsProjectSystemModel,IVsDocument
    {
        #region Propery backing fields
        private readonly bool _hasParent;
        private readonly bool _hasChildren;
        private readonly string _path;
        private readonly VsDocumentType _documentType;
        private readonly bool _isSourceCode;
        private readonly SourceCodeType _sourceType;
        #endregion

        /// <summary>
        /// Constructor for the base class <see cref="VsDocument"/>
        /// </summary>
        /// <param name="isLoaded">Flag that determines if the model is loaded.</param>
        /// <param name="hasErrors">Flag that determines if errors occurred while loading the model.</param>
        /// <param name="modelErrors">The list of errors that occurred if any.</param>
        /// <param name="name">The name of the model.</param>
        /// <param name="actions">CodeFactory Actions that support the model.</param>
        /// <param name="hasParent">Flag that determines if this model has a parent model.</param>
        /// <param name="hasChildren">Flag that determines if this model has child models.</param>
        /// <param name="path">The fully qualified path to the document.</param>
        /// <param name="documentType">The type of visual studio document.</param>
        /// <param name="isSourceCode">Is a source code file loadable by code factory.</param>
        /// <param name="sourceType">The type of source code found in the document.</param>
        protected VsDocument(bool isLoaded, bool hasErrors, IReadOnlyList<ModelException<ProjectSystemModelType>> modelErrors,
            string name, IVsDocumentModelBaseActions actions, bool hasParent, bool hasChildren, string path, VsDocumentType documentType, bool isSourceCode,
            SourceCodeType sourceType) : base(isLoaded, hasErrors, modelErrors, ProjectSystemModelType.Document, name,actions)
        {
            _hasParent = hasParent;
            _hasChildren = hasChildren;
            _path = path;
            _documentType = documentType;
            _isSourceCode = isSourceCode;
            _sourceType = sourceType;
        }

        /// <summary>
        /// Constructor for the base class <see cref="VsDocument"/>
        /// </summary>
        /// <param name="isLoaded">Flag that determines if the model is loaded.</param>
        /// <param name="hasErrors">Flag that determines if errors occurred while loading the model.</param>
        /// <param name="modelErrors">The list of errors that occurred if any.</param>
        /// <param name="name">The name of the model.</param>
        /// <param name="actions">CodeFactory Actions that support the model.</param>
        /// <param name="hasParent">Flag that determines if this model has a parent model.</param>
        /// <param name="hasChildren">Flag that determines if this model has child models.</param>
        /// <param name="path">The fully qualified path to the document.</param>
        /// <param name="documentType">The type of visual studio document.</param>
        /// <param name="isSourceCode">Is a source code file loadable by code factory.</param>
        /// <param name="sourceType">The type of source code found in the document.</param>
        /// <param name="modelType">The type of project system model being implemented.</param>
        protected VsDocument(bool isLoaded, bool hasErrors, IReadOnlyList<ModelException<ProjectSystemModelType>> modelErrors,
            string name, IVsDocumentModelBaseActions actions, bool hasParent, bool hasChildren, string path, VsDocumentType documentType, bool isSourceCode,
            SourceCodeType sourceType, ProjectSystemModelType modelType) : base(isLoaded, hasErrors, modelErrors, modelType, name,actions)
        {
            _hasParent = hasParent;
            _hasChildren = hasChildren;
            _path = path;
            _documentType = documentType;
            _isSourceCode = isSourceCode;
            _sourceType = sourceType;
        }

        /// <summary>
        /// Flag that determines if the visual studio object has a parent.
        /// </summary>
        public bool HasParent => _hasParent;

        /// <summary>
        /// Flag that determines if this visual studio object has child objects.
        /// </summary>
        public bool HasChildren => _hasChildren;

        /// <summary>
        /// The fully qualified path to the project document. 
        /// </summary>
        public string Path => _path;

        /// <summary>
        /// The type of document that is loaded.
        /// </summary>
        public VsDocumentType DocumentType => _documentType;

        /// <summary>
        /// Flag that determines if the project document contains source code that can be managed by code factory.
        /// </summary>
        public bool IsSourceCode => _isSourceCode;

        /// <summary>
        /// The target type of source code that is implemented in the project document. 
        /// </summary>
        public SourceCodeType SourceType => _sourceType;

        /// <summary>
        /// CodeFactory framework actions used to implement software factory automation.
        /// </summary>
        public new IVsDocumentModelBaseActions Actions => base.Actions as IVsDocumentModelBaseActions;

    }
}
