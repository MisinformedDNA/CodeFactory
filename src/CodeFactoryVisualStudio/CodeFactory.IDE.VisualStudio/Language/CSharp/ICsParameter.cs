﻿//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using CodeFactory.Language.CSharp;
namespace CodeFactory.IDE.VisualStudio.Language.CSharp{
    /// <summary>
    ///     The definition of a parameter used in C#.
    /// </summary>
    public interface ICsParameter:ICsModel,ICsAttributes,IParent,ILookup
    {
        /// <summary>
        ///     The name of the parameter.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     The data type assigned to the parameter.
        /// </summary>
        CsType ParameterType { get; }

        /// <summary>
        ///     Flag that determines if the parameter is assigned the out keyword.
        /// </summary>
        bool IsOut { get; }

        /// <summary>
        ///     Flag that determines if the parameter is assigned the ref keyword.
        /// </summary>
        bool IsRef { get; }

        /// <summary>
        ///     Flag that determines if the parameter is an parameter array.
        /// </summary>
        bool IsParams { get; }

        /// <summary>
        ///     Flag that determines if the parameter is optional.
        /// </summary>
        bool IsOptional { get; }

        /// <summary>
        ///     Flag that determines if the parameter is a generic place holder.
        /// </summary>
        bool IsGenericParameter { get; }

        /// <summary>
        ///     Flag that determines if the parameter has a default value.
        /// </summary>
        bool HasDefaultValue { get; }

        /// <summary>
        ///     The default value assigned to the parameter. This will be null if the HasDefaultValue property is set to false.
        /// </summary>
        CsParameterDefaultValue DefaultValue { get; }
    }
}
