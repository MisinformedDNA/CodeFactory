//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;

namespace CodeFactory.Language.CSharp
{
    /// <summary>
    /// Model definition for a class in C#.
    /// </summary>
    public interface ICsClass:ICsContainer
    {
        /// <summary>
        /// List of the constructors implemented in this class.
        /// </summary>
        IReadOnlyList<ICsMethod> Constructors { get; }

        /// <summary>
        /// The destructor implemented in this class.
        /// </summary>
        ICsMethod Destructor { get; }

        /// <summary>
        ///     List of the fields implemented in this class.
        /// </summary>
        IReadOnlyList<ICsField> Fields { get; }

        /// <summary>
        ///     The base class assigned to this class. This will be null if HasBase is false.
        /// </summary>
        ICsClass BaseClass { get; }

        /// <summary>
        ///     Flag that determines if this class is static.
        /// </summary>
        bool IsStatic { get; }

        /// <summary>
        ///     Flat that determines if this is an abstract class.
        /// </summary>
        bool IsAbstract { get; }

        /// <summary>
        ///     Flag that determines if this class has been sealed.
        /// </summary>
        bool IsSealed { get; }

    }
}
