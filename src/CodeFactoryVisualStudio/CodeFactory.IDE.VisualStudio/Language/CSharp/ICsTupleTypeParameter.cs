namespace CodeFactory.IDE.VisualStudio.Language.CSharp
{
    /// <summary>
    /// Definition of the tuple type parameter that supports the tuple type.
    /// </summary>
    public interface ICsTupleTypeParameter:ICsModel
    {
        /// <summary>
        /// Flag that determines if the named assigned to the tuple was system generated or defined in source.
        /// </summary>
        bool HasDefaultName { get; }

        /// <summary>
        /// The name assigned to the tuple parameter.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The model with the type definition assigned to the tuple.
        /// </summary>
        CsType TupleType { get; }
    }
}
