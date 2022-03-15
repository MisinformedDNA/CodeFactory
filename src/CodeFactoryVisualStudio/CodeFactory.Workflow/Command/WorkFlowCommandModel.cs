//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2022 CodeFactory, LLC
//*****************************************************************************
using CodeFactory.VisualStudio;

namespace CodeFactory.Workflow.Command
{
    /// <summary>
    /// Model that is provided as part of a Workflow command.
    /// </summary>
    /// <typeparam name="TModel">The type of CodeFactory model being provided.</typeparam>
    public class WorkflowCommandModel<TModel>:IWorkflowCommandModel<TModel> where TModel : class
    {
        private readonly IVsActions _visualStudioActions;
        private readonly TModel _model;

        /// <summary>
        /// Creates an instance of the Workflow command model.
        /// </summary>
        /// <param name="visualStudioActions">Automation commands  from CodeFactory. </param>
        /// <param name="model">Generated model to be provided to the command.</param>
        public WorkflowCommandModel(IVsActions visualStudioActions, TModel model)
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
