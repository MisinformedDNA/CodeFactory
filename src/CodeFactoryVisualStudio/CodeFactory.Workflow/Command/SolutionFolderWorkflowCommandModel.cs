//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2022 CodeFactory, LLC
//*****************************************************************************
using CodeFactory.VisualStudio;

namespace CodeFactory.Workflow.Command
{
    /// <summary>
    /// Workflow command model that supports <see cref="VsSolutionFolder"/> model.
    /// </summary>
    public class SolutionFolderWorkflowCommandModel:WorkflowCommandModel<VsSolutionFolder>
    {
        /// <summary>
        /// Creates an instance of the Workflow command model.
        /// </summary>
        /// <param name="visualStudioActions">Automation commands  from CodeFactory. </param>
        /// <param name="model">Generated model to be provided to the command.</param>
        public SolutionFolderWorkflowCommandModel(IVsActions visualStudioActions, VsSolutionFolder model) : base(visualStudioActions, model)
        {
            //Intentionally blank
        }
    }
}
