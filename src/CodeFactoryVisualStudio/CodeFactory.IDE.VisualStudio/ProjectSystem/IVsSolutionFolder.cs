//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2020 CodeFactory, LLC
//*****************************************************************************

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Model of a solution folder that is currently loaded in visual studio.
    /// </summary>
    public interface IVsSolutionFolder:IVsProjectSystemModel,IParent,IChildren
    {
        //Intentionally Blank
    }
}
