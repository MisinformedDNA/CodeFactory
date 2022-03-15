//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2022 CodeFactory, LLC
//*****************************************************************************
using CodeFactory.VisualStudio;

namespace CodeFactory.Workflow.Config
{
    /// <summary>
    /// Definition of where a models location is. 
    /// </summary>
    public interface IModelLocation
    {
        /// <summary>
        /// Flag that determines if the model is a source location or a destination model.
        /// </summary>
        bool IsSourceModel { get;}

        /// <summary>
        /// Unique identifier that is assigned to the model.
        /// </summary>
        string Id { get;  }

        /// <summary>
        /// Optional category to assign to the model location.
        /// </summary>
        string Category { get; }

        /// <summary>
        /// Flag that determines if the model is located in a project.
        /// </summary>
        bool ProjectHosted { get; }

        /// <summary>
        /// Project that hosts the model. This will be null if not hosted in a project.
        /// </summary>
        VsProject HostingProject { get;}

        /// <summary>
        /// Relative path of where to find the target model.
        /// </summary>
        string Path { get;}


    }
}
