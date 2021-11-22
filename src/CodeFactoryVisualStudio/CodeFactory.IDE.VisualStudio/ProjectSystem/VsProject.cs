//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2020 CodeFactory, LLC
//*****************************************************************************

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;


namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Data model that presents a visual studio project that has been loaded.
    /// </summary>
    public abstract class VsProject:VsProjectSystemModel,IVsProject
    {
        #region Property backing fields
        private readonly bool _hasParent;
        private readonly bool _hasChildren;
        private readonly string _path;
        private readonly bool _legacyProjectModel;
        private readonly IReadOnlyList<ProjectLanguage> _projectLanguages;
        private readonly string _defaultNamespace;
        private readonly IReadOnlyList<VsProjectFramework> _targetFrameworks;

        #endregion

        /// <summary>
        /// Constructor for the base class <see cref="VsProject"/>
        /// </summary>
        /// <param name="isLoaded">Flag that determines if the model is loaded.</param>
        /// <param name="hasErrors">Flag that determines if errors occurred while loading the model.</param>
        /// <param name="modelErrors">The list of errors that occurred if any.</param>
        /// <param name="name">The name of the model.</param>
        /// <param name="actions">CodeFactory actions that support this model.</param>
        /// <param name="hasParent">Flag that determines if there is a parent model for this model.</param>
        /// <param name="hasChildren">Flag that determines if this model has child models.</param>
        /// <param name="path">The fully qualified path of the project.</param>
        /// <param name="legacyProjectModel">Flag that determines if this project uses the legacy project system for visual studio.</param>
        /// <param name="projectLanguages">The programming languages this project supports.</param>
        /// <param name="defaultNamespace">The default namespace for the project if it support .net framework or .net core. Otherwise this will be null. </param>
        /// <param name="targetFrameworks">List of the target frameworks this project sends output to on compile.</param>
        protected VsProject(bool isLoaded, bool hasErrors, IReadOnlyList<ModelException<ProjectSystemModelType>> modelErrors,
             string name, IVsProjectModelBaseActions actions, bool hasParent, bool hasChildren, string path, bool legacyProjectModel, 
             IReadOnlyList<ProjectLanguage> projectLanguages, string defaultNamespace, IReadOnlyList<VsProjectFramework> targetFrameworks) 
            : base(isLoaded, hasErrors, modelErrors, ProjectSystemModelType.Project, name,actions)
        {
            _hasParent = hasParent;
            _hasChildren = hasChildren;
            _path = path;
            _legacyProjectModel = legacyProjectModel;
            _defaultNamespace = defaultNamespace;
            _targetFrameworks = targetFrameworks;
            _projectLanguages = projectLanguages ?? ImmutableList<ProjectLanguage>.Empty;
            _targetFrameworks = targetFrameworks ?? ImmutableList<VsProjectFramework>.Empty;
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
        ///     The fully qualified path to the project file name.
        /// </summary>
        public string Path => _path;

        /// <summary>
        /// Flag that determines if this visual studio project uses the legacy project model. If so then only basic capabilities and references will be available through code factory.
        /// </summary>
        public bool LegacyProjectModel => _legacyProjectModel;

        /// <summary>
        /// The default namespace for the project if it support .net framework or .net core. Otherwise this will be null.
        /// </summary>
        public string DefaultNamespace => _defaultNamespace;

        /// <summary>
        /// The project languages that are supported in this project. 
        /// </summary>
        public IReadOnlyList<ProjectLanguage> ProjectLanguages => _projectLanguages;

        /// <inheritdoc />
        public IReadOnlyList<VsProjectFramework> TargetFrameworks => _targetFrameworks;

        /// <summary>
        /// CodeFactory framework actions used to implement software factory automation.
        /// </summary>
        public new IVsProjectModelBaseActions Actions => base.Actions as IVsProjectModelBaseActions;
    }
}
