using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFactory.Workflow.Content
{
    /// <summary>
    /// Based definition all content formatters must implement.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public interface IContent<TModel> where TModel : class
    {
        /// <summary>
        /// Formats the content for the provided model and returns the formatted content.
        /// </summary>
        /// <param name="model">The model to use for content generation.</param>
        /// <param name="data">Optional data to be provided to help with content formatting.</param>
        /// <returns>The formatted content.</returns>
        string FormatContent(IWorkflowModel<TModel> model, WorkflowData data = null);


    }
}
