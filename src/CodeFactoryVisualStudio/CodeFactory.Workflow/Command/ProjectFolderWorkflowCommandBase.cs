//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2022 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using CodeFactory.Logging;
using CodeFactory.VisualStudio;

namespace CodeFactory.Workflow.Command
{
    /// <summary>
    /// Workflow command base implementation that support the <see cref="VsProjectFolder"/> model.
    /// </summary>
    public abstract class ProjectFolderWorkflowCommandBase: WorkflowCommandBase<VsProjectFolder>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger">Logger for workflow.</param>
        /// <param name="commandName">Name of the command to display in Visual Studio.</param>
        /// <param name="description">Small overview of what the workflow is about.</param>
        /// <param name="id">Unique identifier that id's the workflow command. Used in workflow configuration.</param>
        /// <param name="category">Helps sort the type of command category this command belongs to.</param>
        /// <param name="enableRules">Optional list of rules that must pass in order for this command to be displayed.</param>
        protected ProjectFolderWorkflowCommandBase(ILogger logger, string commandName, string description, string id, string category, IEnumerable<IWorkflowCommandEnableRule<VsProjectFolder>> enableRules = null) : base(logger, commandName, description, id, category, enableRules)
        {
            //Intentionally blank
        }
    }
}
