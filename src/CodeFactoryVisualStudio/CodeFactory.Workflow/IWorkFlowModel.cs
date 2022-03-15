//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2022 CodeFactory, LLC
//*****************************************************************************
using CodeFactory.VisualStudio;

namespace CodeFactory.Workflow
{
    /// <summary>
    /// CodeFactory model that provides access to CodeFactory model data and the automation API from CodeFactory.
    /// </summary>
    /// <typeparam name="TModel">CodeFactory model that represents a CodeFactory Command.</typeparam>
    public interface IWorkflowModel<TModel> where TModel : class
    {
        /// <summary>
        /// CodeFactory automation that is supported in Visual Studio.
        /// </summary>
        IVsActions VisualStudioActions { get; }

        /// <summary>
        /// The CodeFactory that represents either the project system or a source model from Visual Studio.
        /// </summary>
        TModel Model { get; }
    }
}
