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
    /// Contract that all Workflow CodeFactory commands must implement.
    /// </summary>
    /// <typeparam name="TModel">The target CodeFactory model the command supports.</typeparam>
    public interface IWorkflowCommand<TModel> where TModel : class
    {
        /// <summary>
        /// This display name for the command in Visual Studio Context Menus.
        /// </summary>
        string CommandName { get;}

        /// <summary>
        /// The description provides a summary of what the command does.
        /// </summary>
        string Description { get;}

        /// <summary>
        /// Unique identifier assigned to the command. Used for Workflow configuration of the command.
        /// </summary>
        string Id { get;}

        /// <summary>
        /// Category is an optional data that is used by the Workflow to categorize the command. 
        /// </summary>
        string Category { get;}

        /// <summary>
        /// Enable rules to be processed when the Workflow command executes. 
        /// </summary>
        IReadOnlyList<IWorkflowCommandEnableRule<TModel>> EnableRules { get; }

        /// <summary>
        /// Validation logic that will determine if this command should be enabled for execution.
        /// </summary>
        /// <param name="result">The target model data that will be used to determine if this command should be enabled.</param>
        /// <param name="locations">Model location data to be used by the command.This is optional and is null if not provided. </param>
        /// <param name="enableRules">Rules that provided to determine if the command should be enabled for usage by developers.This is optional and is null if not provided.</param>
        /// <returns>Boolean flag that will tell code factory to enable this command or disable it.</returns>
        Task<bool> EnableWorkflowCommandAsync(IWorkflowCommandModel<TModel> result, IReadOnlyList<IModelLocation> locations = null,
            IReadOnlyList<IWorkflowCommandEnableRule<TModel>> enableRules = null);

        /// <summary>
        /// Executes the Software Factory automation hosted in this command.
        /// </summary>
        /// <param name="result">The target CodeFactory model the represents functionality project system or content functionality.</param>
        /// <param name="locations">Model location data to be used by the command.This is optional and is null if not provided. </param>
        Task ExecuteWorkflowCommandAsync(IWorkflowCommandModel<TModel> result, IReadOnlyList<IModelLocation> locations = null);

    }
}
