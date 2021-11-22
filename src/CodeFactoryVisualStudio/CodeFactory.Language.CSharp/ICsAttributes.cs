//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;

namespace CodeFactory.Language.CSharp
{
    /// <summary>
    /// Interface that determines if a c# model has attributes assigned.
    /// </summary>
    public interface ICsAttributes
    {
        /// <summary>
        ///     Flag that determines if attributes are assigned.
        /// </summary>
        bool HasAttributes { get; }

        /// <summary>
        ///     The attributes assigned to this item. If the HasAttributes is false this will be an empty list.
        /// </summary>
        IReadOnlyList<ICsAttribute> Attributes { get; }
    }
}
