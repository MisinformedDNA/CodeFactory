//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Data class that implements <see cref="IVsProjectFramework"/>
    /// </summary>
    public abstract class VsProjectFramework: VsProjectSystemModel, IVsProjectFramework
    {
        /// <summary>
        /// Backing field the for property <see cref="Version"/>
        /// </summary>
        private readonly string _version;

        /// <summary>
        /// Creates a new instances of the <see cref="VsProjectFramework"/> model.
        /// </summary>
        /// <param name="isLoaded">Flag that determines if the model is loaded.</param>
        /// <param name="hasErrors">Flag that determines if errors occurred while loading the model.</param>
        /// <param name="modelErrors">The list of errors that occurred if any.</param>
        /// <param name="actions">The CodeFactory actions for the model.</param>
        /// <param name="framework">The name of the framework being deployed to.</param>
        /// <param name="version">The target version of the framework.</param>
        protected VsProjectFramework(bool isLoaded, bool hasErrors, IReadOnlyList<ModelException<ProjectSystemModelType>> modelErrors,IVsBaseActions actions,
            string framework, string version) : base(isLoaded,hasErrors,modelErrors, ProjectSystemModelType.ProjectFramework,framework,actions)
        {
            _version = version;
        }

        /// <inheritdoc />
        public string Framework => Name;

        /// <inheritdoc />
        public string Version => _version;
    }
}
