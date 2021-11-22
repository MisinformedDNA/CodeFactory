//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using CodeFactory.Document;
using CodeFactory.Language.CSharp;
using CodeFactory.SourceCode;

namespace CodeFactory.IDE.VisualStudio.Language.CSharp
{
    /// <summary>
    /// Data model that represents an attribute.
    /// </summary>
    public abstract class CsAttribute:CsModel,ICsAttribute
    {
        #region Property backing fields
        private readonly IReadOnlyList<string> _sourceFiles;
        private readonly bool _hasParameters;
        private readonly string _parentPath;
        private readonly IReadOnlyList<CsAttributeParameter> _parameters;
        private readonly CsType _type;
        #endregion

        /// <summary>
        /// Constructor for the <see cref="CsAttribute"/>
        /// </summary>
        /// <param name="isLoaded">Flag that determines if the model was loaded.</param>
        /// <param name="hasErrors">Flag that determine if errors were found creating the model.</param>
        /// <param name="loadedFromSource">Flag that determines if the model was loaded from source code or from an existing library.</param>
        /// <param name="language">The target language the model was generated from.</param>
        /// <param name="type">The target type of the attribute.</param>
        /// <param name="sourceDocument">The source document that was used to build this model. This is optional parameter and can be null.</param>
        /// <param name="modelStore">Optional the lookup storage for models created during the compile or lookup of the model.</param>
        /// <param name="modelErrors">Optional the error that occurred while creating the model.</param>
        /// <param name="sourceFiles">The list of source files the attribute is defined in.</param>
        /// <param name="hasParameters">Flag that determines if the attribute has parameters.</param>
        /// <param name="parentPath">The fully qualified lookup path to the parent model for this attribute.</param>
        /// <param name="parameters">The list of parameters assigned to the attribute.</param>
        protected CsAttribute(bool isLoaded, bool hasErrors, bool loadedFromSource, SourceCodeType language,
            IReadOnlyList<string> sourceFiles, bool hasParameters, string parentPath, IReadOnlyList<CsAttributeParameter> parameters, 
            CsType type, string sourceDocument = null, ModelStore<ICsModel> modelStore = null, IReadOnlyList<ModelLoadException> modelErrors = null)
            : base(isLoaded, hasErrors, loadedFromSource, language, CsModelType.Attribute, sourceDocument, modelStore, modelErrors)
        {
            _sourceFiles = sourceFiles ?? ImmutableList<string>.Empty;
            _hasParameters = hasParameters;
            _parentPath = parentPath;
            _parameters = parameters ?? ImmutableList<CsAttributeParameter>.Empty;
            _type = type;
        }

        /// <summary>
        /// The source file or files in which the model was loaded from. This will be an empty enumeration if the source models were loaded from metadata only.
        /// </summary>
        public IReadOnlyList<string> SourceFiles => _sourceFiles;

        /// <summary>
        ///     Enumeration of the parameters that are assigned to the attribute. This will be an empty list if HasParameters is false.
        /// </summary>
        public IReadOnlyList<CsAttributeParameter> Parameters => _parameters;

        /// <summary>
        ///     The type information for the attribute itself.
        /// </summary>
        public CsType Type => _type;

        /// <summary>
        /// Gets a <see cref="CsModel"/> from the currently loaded source code. 
        /// </summary>
        /// <param name="lookupPath">The fully qualified path to the model to be loaded.</param>
        /// <returns>The loaded model or null if the model could not be found.</returns>
        public CsModel GetModel(string lookupPath) => LookupModel(lookupPath);

        /// <summary>
        ///     Flag that determines if the attribute has parameters
        /// </summary>
        public bool HasParameters => _hasParameters;

        /// <summary>
        /// The parent to the current model. This will return null if there is no parent for this model, or the parent could not be located. 
        /// </summary>
        public CsModel Parent => LookupModel(_parentPath);

    }
}
