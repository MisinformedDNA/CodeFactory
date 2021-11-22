using CodeFactory.IDE.VisualStudio.ProjectSystem.UserInterface;


namespace CodeFactory.IDE.VisualStudio.Language.CSharp
{
    /// <summary>
    /// Base CodeFactory actions that are  available on all C# models.  
    /// </summary>
    public interface IVsCSharpBaseActions
    {
        /// <summary>
        /// Solution based commands available this will include, solution, solution folders, solution files, and searching for projects. 
        /// </summary>
        string Solution { get; set; }

        /// <summary>
        /// Project system commands available this will include projects, project folders, project files, and project references.
        /// </summary>
        string Project { get; set; }

        /// <summary>
        /// User interface actions available from CodeFactory.
        /// </summary>
        IVsUiActions UserInterface { get; set; }

        /// <summary>
        /// Functionality access the Visual Studio IDE itself. 
        /// </summary>
        string IDE { get; set; }

        /// <summary>
        /// Global list of Visual Studio actions that can be used with CodeFactory. The global command list will require models to be passed to the actions.
        /// </summary>
        IVsActions VisualStudioActions { get;}


    }
}