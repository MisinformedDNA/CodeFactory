namespace CodeFactory.IDE.VisualStudio.ProjectSystem.ProjectSystem
{
    public interface IVsProjectSystemBaseActions
    {
        /// <summary>
        /// Global list of Visual Studio actions that can be used with CodeFactory. The global command list will require models to be passed to the actions.
        /// </summary>
        IVsActions VisualStudioActions { get;}
    }
}