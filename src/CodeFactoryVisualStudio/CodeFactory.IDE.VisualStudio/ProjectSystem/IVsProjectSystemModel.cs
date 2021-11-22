//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2020 CodeFactory, LLC
//*****************************************************************************

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    public interface IVsProjectSystemModel:IModel<ProjectSystemModelType>
    {
        /// <summary>
        /// The name of the visual studio model.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// CodeFactory framework actions used to implement software factory automation.
        /// </summary>
        IVsBaseActions Actions { get; }

    }
}
