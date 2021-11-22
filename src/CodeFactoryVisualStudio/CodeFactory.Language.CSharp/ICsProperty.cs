//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

namespace CodeFactory.Language.CSharp{
    /// <summary>
    /// Model definition of a property in C#.
    /// </summary>
    public interface ICsProperty:ICsMember
    {
        /// <summary>
        ///     The source data type that is managed by this property.
        /// </summary>
        ICsType PropertyType { get; }

        /// <summary>
        ///     Flag that determines if this property supports get access.
        /// </summary>
        bool HasGet { get; }

        /// <summary>
        ///     The security scope that is assigned to the get accessor. Make sure you check the HasGet to determine if the property supports get operations.
        /// </summary>
        CsSecurity GetSecurity { get; }

        /// <summary>
        ///     Flag that determines if this property supports set access.
        /// </summary>
        bool HasSet { get; }

        /// <summary>
        ///     The security scope that is assigned to the set accessor. Make sure you check the HasSet to determine if the property supports set operations.
        /// </summary>
        CsSecurity SetSecurity { get; }

        /// <summary>
        ///     Flag that determines if the property is implemented as an abstract property.
        /// </summary>
        bool IsAbstract { get; }

        /// <summary>
        ///     Flag that determines if the property is implemented as virtual.
        /// </summary>
        bool IsVirtual { get; }

        /// <summary>
        ///     Flag that determines if the property has been sealed.
        /// </summary>
        bool IsSealed { get; }

        /// <summary>
        ///     Flag that determines if the property has been overridden.
        /// </summary>
        bool IsOverride { get; }

        /// <summary>
        ///     Flag that determines if the property has been implemented as static.
        /// </summary>
        bool IsStatic { get; }
    }
}
