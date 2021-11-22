//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2021 CodeFactory, LLC
//*****************************************************************************
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Actions that can be used with the a <see cref="VsSolution"/> model.
    /// </summary>
    public interface IVsSolutionModelBaseActions:IVsBaseActions
    {
        /// <summary>
        /// Actions that support the model.
        /// </summary>
        IVsSolutionModelActions Model { get; }

    }
}
