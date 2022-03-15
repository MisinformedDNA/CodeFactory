//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2022 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeFactory.Workflow.Config;

namespace CodeFactory.Workflow.Command
{
    /// <summary>
    /// Workflow implementation that checks if a workflow command should be enabled for execution.
    /// </summary>
    /// <typeparam name="TModel">Target workflow command model this rule supports.</typeparam>
    public abstract class WorkflowCommandEnableRuleBase<TModel>:IWorkflowCommandEnableRule<TModel> where TModel : class
    {
        /// <summary>
        /// Checks to confirm is the command should be enabled for usage by developers.
        /// </summary>
        /// <param name="model">The CodeFactory data model that represents the source functionality.</param>
        /// <param name="locations">Optional parameter that provides the locations that are provided to the command.</param>
        /// <returns>True to enable the command or false to disable the command.</returns>
        public abstract Task<bool> EnableCommandAsync(IWorkflowCommandModel<TModel> model,
            IReadOnlyList<IModelLocation> locations = null);

    }
}
