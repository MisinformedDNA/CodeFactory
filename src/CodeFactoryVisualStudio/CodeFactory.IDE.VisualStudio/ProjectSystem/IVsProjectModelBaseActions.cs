//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************

using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Visual studio actions that support the <see cref="IVsProject"/> model.
    /// </summary>
    public interface IVsProjectModelBaseActions:IVsBaseActions
    {

        /// <summary>
        /// Actions that support the model.
        /// </summary>
        IVsProjectModelActions Model { get; }


    }
}
