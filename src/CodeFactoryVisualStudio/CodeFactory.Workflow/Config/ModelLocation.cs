//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2022 CodeFactory, LLC
//*****************************************************************************
using CodeFactory.VisualStudio;

namespace CodeFactory.Workflow.Config
{
    public class ModelLocation:IModelLocation
    {
        #region Backing fields for properties
        private readonly bool _isSourceModel;
        private readonly string _id;
        private readonly string _category;
        private readonly bool _projectHosted;
        private readonly VsProject _hostingProject;
        private readonly string _path;
        #endregion
        
        /// <summary>
        /// Creates a new instance of the <see cref="ModelLocation"/>
        /// </summary>
        /// <param name="isSourceModel">Flag that determines if the model is a source location or a destination model.</param>
        /// <param name="id">Unique identifier that is assigned to the model.</param>
        /// <param name="category">Optional category to assign to the model location.</param>
        /// <param name="projectHosted">Flag that determines if the model is located in a project.</param>
        /// <param name="hostingProject">Project that hosts the model. This will be null if not hosted in a project.</param>
        /// <param name="path">Relative path of where to find the target model.</param>
        public ModelLocation(bool isSourceModel, string id, string category, bool projectHosted, VsProject hostingProject, string path)
        {
            _isSourceModel = isSourceModel;
            _id = id;
            _category = category;
            _projectHosted = projectHosted;
            _hostingProject = hostingProject;
            _path = path;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ModelLocation"/>
        /// </summary>
        /// <param name="isSourceModel">Flag that determines if the model is a source location or a destination model.</param>
        /// <param name="id">Unique identifier that is assigned to the model.</param>
        /// <param name="category">Optional category to assign to the model location.</param>
        /// <param name="projectHosted">Flag that determines if the model is located in a project.</param>
        /// <param name="hostingProject">Project that hosts the model. This will be null if not hosted in a project.</param>
        /// <param name="path">Relative path of where to find the target model.</param>
        public static ModelLocation Init(bool isSourceModel, string id, string category, bool projectHosted,
            VsProject hostingProject, string path)
        {
            return new ModelLocation(isSourceModel, id, category, projectHosted, hostingProject, path);
        }

        /// <summary>
        /// Flag that determines if the model is a source location or a destination model.
        /// </summary>
        public bool IsSourceModel => _isSourceModel;

        /// <summary>
        /// Unique identifier that is assigned to the model.
        /// </summary>
        public string Id => _id;
    

        /// <summary>
        /// Optional category to assign to the model location.
        /// </summary>
        public string Category => _category;
 

        /// <summary>
        /// Flag that determines if the model is located in a project.
        /// </summary>
        public bool ProjectHosted => _projectHosted;


        /// <summary>
        /// Project that hosts the model. This will be null if not hosted in a project.
        /// </summary>
        public VsProject HostingProject => _hostingProject;

        /// <summary>
        /// Relative path of where to find the target model.
        /// </summary>
        public string Path => _path;

    }
}
