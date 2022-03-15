//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2022 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeFactory.Logging;
using CodeFactory.Workflow.Config;

namespace CodeFactory.Workflow.Command
{
    /// <summary>
    /// Base implementation for all workflow commands that are triggered by CodeFactory
    /// </summary>
    /// <typeparam name="TModel">The target workflow command model type.</typeparam>
    public abstract class WorkflowCommandBase<TModel>:IWorkflowCommand<TModel> where TModel : class
    {
        #region Backing properties
        private readonly string _commandName;
        private readonly string _description;
        private readonly string _id;
        private readonly string _category;
        private readonly ILogger _logger;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger">Logger for workflow.</param>
        /// <param name="commandName">Name of the command to display in Visual Studio.</param>
        /// <param name="description">Small overview of what the workflow is about.</param>
        /// <param name="id">Unique identifier that id's the workflow command. Used in workflow configuration.</param>
        /// <param name="category">Helps sort the type of command category this command belongs to.</param>
        /// <param name="enableRules">Optional list of rules that must pass in order for this command to be displayed.</param>
        protected WorkflowCommandBase(ILogger logger, string commandName, string description, string id, string category)
        {
            _logger = logger;
            _commandName = commandName;
            _description = description;
            _id = id;
            _category = category;
        }

        /// <summary>
        /// This display name for the command in Visual Studio Context Menus.
        /// </summary>
        public string CommandName => _commandName;

        /// <summary>
        /// The description provides a summary of what the command does.
        /// </summary>
        public string Description => _description;

        /// <summary>
        /// Unique identifier assigned to the command. Used for Workflow configuration of the command.
        /// </summary>
        public string Id => _id;

        /// <summary>
        /// Category is an optional data that is used by the Workflow to categorize the command. 
        /// </summary>
        public string Category => _category;

        /// <summary>
        /// Validation logic that will determine if this command should be enabled for execution.
        /// </summary>
        /// <param name="result">The target model data that will be used to determine if this command should be enabled.</param>
        /// <param name="locations">Model location data to be used by the command.This is optional and is null if not provided. </param>
        /// <param name="enableRules">Rules that provided to determine if the command should be enabled for usage by developers.This is optional and is null if not provided.</param>
        /// <param name="data">Optional workflow data to be used in validation of the command to be enabled.</param>
        /// <returns>Boolean flag that will tell code factory to enable this command or disable it.</returns>
        public abstract Task<bool> EnableWorkflowCommandAsync(IWorkflowModel<TModel> result,
            IReadOnlyList<IModelLocation> locations = null,
            IReadOnlyList<IWorkflowCommandEnableRule<TModel>> enableRules = null, WorkflowData data = null);


        /// <summary>
        /// Executes the Software Factory automation hosted in this command.
        /// </summary>
        /// <param name="result">The target CodeFactory model the represents functionality project system or content functionality.</param>
        /// <param name="locations">Model location data to be used by the command.This is optional and is null if not provided. </param>
        /// <param name="data">Optional workflow data to be used in execution of the command.</param>
        public abstract Task ExecuteWorkflowCommandAsync(IWorkflowModel<TModel> result,
            IReadOnlyList<IModelLocation> locations = null,
            WorkflowData data = null);

    }
}
