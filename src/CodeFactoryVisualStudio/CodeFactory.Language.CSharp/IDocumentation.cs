﻿//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

namespace CodeFactory.Language.CSharp
{
    /// <summary>
    /// Interface that determines if a model has code level documentation.
    /// </summary>
    public interface IDocumentation
    {
        /// <summary>
        ///     Flag that determines if the model has code level documentation assigned to it.
        /// </summary>
        bool HasDocumentation { get; }

        /// <summary>
        ///     Documentation that has been assigned to this model.
        /// </summary>
        string Documentation { get; }
    }
}
