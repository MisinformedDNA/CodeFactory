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
    /// Validation rule that checks to see if the command should be enabled for usage.
    /// </summary>
    /// <typeparam name="TModel">The target CodeFactory model type used for enabling the command.</typeparam>
    public interface IWorkflowCommandEnableRule<TModel> where TModel: class
    {
        /// <summary>
        /// Checks to confirm is the command should be enabled for usage by developers.
        /// </summary>
        /// <param name="model">The CodeFactory data model that represents the source functionality.</param>
        /// <param name="locations">Optional parameter that provides the locations that are provided to the command.</param>
        /// <param name="data">Additional data that can be provided from the workflow to the enable command check.</param>
        /// <returns>True to enable the command or false to disable the command.</returns>
        Task<bool> EnableCommandAsync(IWorkflowModel<TModel> model,IReadOnlyList<IModelLocation> locations = null,WorkflowData data = null);
    }
}
