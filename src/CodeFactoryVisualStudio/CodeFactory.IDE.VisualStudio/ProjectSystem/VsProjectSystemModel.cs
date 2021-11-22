//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

using System.Collections.Generic;
using System.Collections.Immutable;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Base class used by all visual studio models.
    /// </summary>
    public abstract class VsProjectSystemModel:IVsProjectSystemModel
    {
        #region Property backing fields
        private readonly bool _isLoaded;
        private readonly bool _hasErrors;
        private readonly IReadOnlyList<ModelException<ProjectSystemModelType>> _modelErrors;
        private readonly ProjectSystemModelType _modelType;
        private readonly string _name;

        /// <summary>
        /// backing field that stores the actions that have been provided to this model. 
        /// </summary>
        private readonly IVsBaseActions _actions;
        #endregion

        /// <summary>
        /// Constructor for the base class <see cref="VsProjectSystemModel"/>
        /// </summary>
        /// <param name="isLoaded">Flag that determines if the model is loaded.</param>
        /// <param name="hasErrors">Flag that determines if errors occurred while loading the model.</param>
        /// <param name="modelErrors">The list of errors that occurred if any.</param>
        /// <param name="modelType">The type of visual studio model that is loaded.</param>
        /// <param name="name">The name of the model.</param>
        /// <param name="actions">CodeFactory actions for visual studio that support this project system model.</param>
        protected VsProjectSystemModel(bool isLoaded, bool hasErrors, IReadOnlyList<ModelException<ProjectSystemModelType>> modelErrors, ProjectSystemModelType modelType, string name,IVsBaseActions actions)
        {
            _isLoaded = isLoaded;
            _hasErrors = hasErrors;
            _modelErrors = modelErrors ?? ImmutableList<ModelException<ProjectSystemModelType>>.Empty;
            _modelType = modelType;
            _name = name;
            _actions = actions;
        }

        /// <summary>
        /// Flag that determines if this model was able to load.
        /// </summary>
        public bool IsLoaded => _isLoaded;

        /// <summary>
        /// Flag that determines if this model has errors.
        /// </summary>
        public bool HasErrors => _hasErrors;

        /// <summary>
        /// List of all errors that occurred in this model.
        /// </summary>
        public IReadOnlyList<ModelException<ProjectSystemModelType>> ModelErrors => _modelErrors;

        /// <summary>
        /// Determines the type of model that has been loaded.
        /// </summary>
        public ProjectSystemModelType ModelType => _modelType;

        /// <summary>
        /// The name of the visual studio model.
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// CodeFactory framework actions used to implement software factory automation.
        /// </summary>
        public IVsBaseActions Actions => _actions;
    }
}
