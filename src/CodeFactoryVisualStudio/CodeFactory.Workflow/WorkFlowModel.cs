//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2022 CodeFactory, LLC
//*****************************************************************************
using CodeFactory.VisualStudio;

namespace CodeFactory.Workflow
{
    /// <summary>
    /// CodeFactory model and the action framework that handles CodeFactory automation for Visual Studio.
    /// </summary>
    /// <typeparam name="TModel">The type of CodeFactory model being provided.</typeparam>
    public class WorkflowModel<TModel>:IWorkflowModel<TModel> where TModel : class
    {
        private readonly IVsActions _visualStudioActions;
        private readonly TModel _model;

        /// <summary>
        /// Creates an instance of the Workflow command model.
        /// </summary>
        /// <param name="visualStudioActions">Automation commands  from CodeFactory. </param>
        /// <param name="model">Generated model to be provided to the command.</param>
        public WorkflowModel(IVsActions visualStudioActions, TModel model)
        {
            _visualStudioActions = visualStudioActions;
            _model = model;
        }

        /// <summary>
        /// CodeFactory automation that is supported in Visual Studio.
        /// </summary>
        public IVsActions VisualStudioActions => _visualStudioActions;

        /// <summary>
        /// The CodeFactory that represents either the project system or a source model from Visual Studio.
        /// </summary>
        public TModel Model => _model;
    }
}
