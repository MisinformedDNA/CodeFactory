//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2022 CodeFactory, LLC
//*****************************************************************************
using CodeFactory.VisualStudio;

namespace CodeFactory.Workflow.Command
{
    /// <summary>
    /// Workflow command model that supports <see cref="VsSolution"/> model.
    /// </summary>
    public class SolutionWorkflowCommandModel:WorkflowCommandModel<VsSolution>
    {
        /// <summary>
        /// Creates an instance of the Workflow command model.
        /// </summary>
        /// <param name="visualStudioActions">Automation commands  from CodeFactory. </param>
        /// <param name="model">Generated model to be provided to the command.</param>
        public SolutionWorkflowCommandModel(IVsActions visualStudioActions, VsSolution model) : base(visualStudioActions, model)
        {
            //Intentionally blank
        }
    }
}
