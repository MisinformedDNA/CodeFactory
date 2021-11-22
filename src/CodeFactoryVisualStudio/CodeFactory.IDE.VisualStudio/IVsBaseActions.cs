namespace CodeFactory.IDE.VisualStudio
{
    /// <summary>
    /// The base level of CodeFactory actions that are supported on models implemented in Visual Studio.
    /// </summary>
    public interface IVsBaseActions
    {
        /// <summary>
        /// The CodeFactory actions that directly support Visual Studio.
        /// </summary>
        IVsActions VisualStudio { get; }
    }
}