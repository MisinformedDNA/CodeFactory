using CodeFactory.IDE.VisualStudio.Language.CSharp;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Target project system document that implements C# source code.
    /// </summary>
    public interface IVsDocumentCSharp:IVsDocument
    {
        /// <summary>
        /// The C# source in the document.
        /// </summary>
        CsSource SourceCode { get; }
    }
    
}