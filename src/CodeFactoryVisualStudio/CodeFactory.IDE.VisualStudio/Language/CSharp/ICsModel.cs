//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using CodeFactory.Language.CSharp;
using CodeFactory.SourceCode;

namespace CodeFactory.IDE.VisualStudio.Language.CSharp
{
    /// <summary>
    /// Base implementation all C# models must implement.
    /// </summary>
    public interface ICsModel:IModelStatus
    {
        /// <summary>
        /// Flag that determines if this model was loaded from source code or was loaded through reflects or symbol libraries.
        /// </summary>
        bool LoadedFromSource { get; }

        /// <summary>
        /// The target language this model was loaded from.
        /// </summary>
        SourceCodeType Language { get; }

        /// <summary>
        /// The fully qualified path to the document that was used to load the model from source. This will be populated if the model was loaded from source.
        /// </summary>
        string SourceDocument { get; }

        /// <summary>
        /// The type of c# model that is implemented.
        /// </summary>
        CsModelType ModelType { get; }

    }
}
