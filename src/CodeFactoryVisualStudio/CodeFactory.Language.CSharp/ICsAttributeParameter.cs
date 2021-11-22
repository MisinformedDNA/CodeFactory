//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

namespace CodeFactory.Language.CSharp
{
    /// <summary>
    /// The model information for a attribute used for a c# implementation.
    /// </summary>
    public interface ICsAttributeParameter:ICsModel
    {
        /// <summary>
        /// Flag that determines if the attribute parameter is a named value, 
        /// or just part of the attributes constructor.
        /// </summary>
        bool HasNamedParameter { get; }

        /// <summary>
        ///     The name of the parameter, if this is not a named parameter then it will be set to null
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     The value that was assigned to the parameter.
        /// </summary>
        ICsAttributeParameterValue Value { get; }
    }
}
