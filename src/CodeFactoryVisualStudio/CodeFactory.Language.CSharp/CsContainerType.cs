//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

namespace CodeFactory.Language.CSharp
{
    /// <summary>
    /// Enumeration that determines the type of c# container object.
    /// </summary>
    public enum CsContainerType
    {
        /// <summary>
        /// The container implements a class model.
        /// </summary>
        Class = 0,

        /// <summary>
        /// The container implements a interface model.
        /// </summary>
        Interface = 1,

        /// <summary>
        /// The container implements a structure model.
        /// </summary>
        Structure = 2,

        /// <summary>
        /// The container is of an unknown type.
        /// </summary>
        Unknown = 9999
    }
}
