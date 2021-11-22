//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2020 CodeFactory, LLC
//*****************************************************************************

using System.Collections.Generic;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Data model that represents a folder in a project hosted in visual studio.
    /// </summary>
    public abstract class VsProjectFolder:VsProjectSystemModel,IVsProjectFolder
    {
        #region Property backing fields
        private readonly bool _hasParent;
        private readonly bool _hasChildren;
        private readonly string _path;
        #endregion

        /// <summary>
        /// Constructor for the base class <see cref="VsProjectFolder"/>
        /// </summary>
        /// <param name="isLoaded">Flag that determines if the model is loaded.</param>
        /// <param name="hasErrors">Flag that determines if errors occurred while loading the model.</param>
        /// <param name="modelErrors">The list of errors that occurred if any.</param>
        /// <param name="name">The name of the model.</param>
        /// <param name="actions">CodeFactory actions for the model.</param>
        /// <param name="hasParent">Flag that determines if the model has a parent model.</param>
        /// <param name="hasChildren">Flag that determines if the model has child models.</param>
        /// <param name="path">The fully qualified path to the project folder.</param>
        protected VsProjectFolder(bool isLoaded, bool hasErrors, 
            IReadOnlyList<ModelException<ProjectSystemModelType>> modelErrors,
            string name, IVsProjectFolderModelBaseActions actions, bool hasParent, bool hasChildren, string path) 
            : base(isLoaded, hasErrors, modelErrors, ProjectSystemModelType.ProjectFolder, name,actions)
        {
            _hasParent = hasParent;
            _hasChildren = hasChildren;
            _path = path;
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
        /// the fully qualified path to the project folder.
        /// </summary>
        public string Path => _path;

        /// <summary>
        /// CodeFactory framework actions used to implement software factory automation.
        /// </summary>
        public new IVsProjectFolderModelBaseActions Actions => base.Actions as IVsProjectFolderModelBaseActions;
    }
}
