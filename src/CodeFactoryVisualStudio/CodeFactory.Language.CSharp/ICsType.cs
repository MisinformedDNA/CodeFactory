//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CodeFactory.Language.CSharp
{
    /// <summary>
    /// Model that defines a type used in a C# model definition.
    /// </summary>
    public interface ICsType:ICsModel,ICsGeneric 
    {
        /// <summary>
        ///     The name of the type.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     The namespace the type belongs to.
        /// </summary>
        string Namespace { get; }

        /// <summary>
        ///     Flag that determines if the type is one of the well know data types of the language.
        /// </summary>
        bool IsWellKnownType { get; }

        /// <summary>
        ///     Enumeration of the target well known type this type represents.
        /// </summary>
        WellKnownLanguageType WellKnownType { get; }

        /// <summary>
        /// The default value for well known value data types. This will be null if the value is not a well known value type.
        /// </summary>
        string ValueTypeDefaultValue { get; }

        /// <summary>
        ///     Flag that determines if the type is a value type.
        /// </summary>
        bool IsValueType { get; }

        /// <summary>
        ///     Flag that determines if the type supports the interface <see cref="IDisposable"/>.
        /// </summary>
        bool SupportsDisposable { get; }

        /// <summary>
        ///     Flag that determines if the type is an interface.
        /// </summary>
        bool IsInterface { get; }

        /// <summary>
        /// Flag that determines if the type is a structure.
        /// </summary>
        bool IsStructure { get; }

        /// <summary>
        /// Flag that determines if the type is a class.
        /// </summary>
        bool IsClass { get; }

        /// <summary>
        ///     Flag that determines if the type is an array of the target type.
        /// </summary>
        bool IsArray { get; }

        /// <summary>
        /// Gets a list of the dimensions that are assigned to the array. This will contain more then one value if the array is a jagged array. This will be empty if the type is not an array.
        /// </summary>
        IReadOnlyList<int> ArrayDimensions { get; }

        /// <summary>
        /// Flag that determines if the type is a generic place holder definition.
        /// </summary>
        bool IsGenericPlaceHolder { get; }

        /// <summary>
        /// Flag that determines if the type is a enumeration.
        /// </summary>
        bool IsEnum { get; }

        /// <summary>
        /// Flag that determines if the type is a delegate.
        /// </summary>
        bool IsDelegate { get; }

        /// <summary>
        /// Flag that determine if the type is a Tuple
        /// </summary>
        bool IsTuple { get; }

        /// <summary>
        /// List of the types that are implemented in the Tuple. This will an empty list if the type is not a tuple.
        /// </summary>
        IReadOnlyList<ICsTupleTypeParameter> TupleTypes { get; }
    }
}
