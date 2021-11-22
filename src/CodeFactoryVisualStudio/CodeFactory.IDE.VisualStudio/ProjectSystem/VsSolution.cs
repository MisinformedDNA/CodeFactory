//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2020 CodeFactory, LLC
//*****************************************************************************

using System.Collections.Generic;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Data model that represents the loaded solution in visual studio.
    /// </summary>
    public abstract class VsSolution:VsProjectSystemModel,IVsSolution
    {
        #region Property backing fields
        private readonly bool _hasChildren;
        private readonly string _path;
        #endregion

        /// <summary>
        /// Constructor for the base class <see cref="VsSolution"/>
        /// </summary>
        /// <param name="isLoaded">Flag that determines if the model is loaded.</param>
        /// <param name="hasErrors">Flag that determines if errors occurred while loading the model.</param>
        /// <param name="modelErrors">The list of errors that occurred if any.</param>
        /// <param name="name">The name of the model.</param>
        /// <param name="actions">CodeFactory Actions that support this model.</param>
        /// <param name="hasChildren">Flag that determines if the solution has any children.</param>
        /// <param name="path">The fully qualified path of the solution.</param>
        protected VsSolution(bool isLoaded, bool hasErrors, IReadOnlyList<ModelException<ProjectSystemModelType>> modelErrors, 
             string name, IVsSolutionModelBaseActions actions, bool hasChildren, string path) : base(isLoaded, hasErrors, modelErrors, ProjectSystemModelType.Solution, name,actions)
        {
            _hasChildren = hasChildren;
            _path = path;
        }

        /// <summary>
        /// Flag that determines if this visual studio object has child objects.
        /// </summary>
        public bool HasChildren => _hasChildren;

        /// <summary>
        ///     The fully qualified path to the solution file name.
        /// </summary>
        public string Path => _path;

        /// <summary>
        /// CodeFactory framework actions used to implement software factory automation.
        /// </summary>
        public new IVsSolutionModelBaseActions Actions => base.Actions as IVsSolutionModelBaseActions;
    }
}
