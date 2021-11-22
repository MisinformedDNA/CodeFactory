//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

using System.Collections.Generic;

namespace CodeFactory.Language.CSharp{
    /// <summary>
    /// Model definition for a structure in C#.
    /// </summary>
    public interface ICsStructure:ICsContainer
    {

        /// <summary>
        /// List of the constructors for this structure.
        /// </summary>
        IReadOnlyList<ICsMethod> Constructors { get; }


        /// <summary>
        ///     List of the fields for this structure.
        /// </summary>
        IReadOnlyList<ICsField> Fields { get; }
    }
}
