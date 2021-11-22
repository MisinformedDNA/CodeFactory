using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFactory.IDE.VisualStudio.ProjectSystem
{
    /// <summary>
    /// Solution folder actions that are supported by the hosting solution.
    /// </summary>
    public interface IVsSolutionModelSolutionFolderActions
    {
        /// <summary>
        /// Gets the solution folders for the solution.
        /// </summary>
        /// <param name="allChildren">Get all children not just the first children of the solution.</param>
        /// <returns>Returns a readonly of the solutions folders that are part of the solution. If there are no solution folders an empty list will be returned.</returns>
        Task<IReadOnlyList<VsSolutionFolder>> GetSolutionFoldersAsync(bool allChildren);

        /// <summary>
        /// Creates a new solution folder for the target solution.
        /// </summary>
        /// <param name="name">The name of the solution folder to be added.</param>
        /// <returns>Returns the solution folder.</returns>
        Task<VsSolutionFolder> CreateSolutionFolderAsync(string name);
    }
}
