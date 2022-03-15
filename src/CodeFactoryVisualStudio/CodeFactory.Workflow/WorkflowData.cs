//*****************************************************************************
//* Code Factory SDK
//* Copyright (c) 2022 CodeFactory, LLC
//*****************************************************************************
using System;
using System.Collections.Immutable;

namespace CodeFactory.Workflow
{
    /// <summary>
    /// Workflow data is a data class that is used to pass additional information to different parts of an automation workflow to help with the implementation of the workflow. 
    /// </summary>
    public class WorkflowData
    {
        /// <summary>
        /// Internal dictionary that contains data used for content generators.
        /// </summary>
        private  ImmutableDictionary <string, object> _contentData = ImmutableDictionary<string, object>.Empty;

        /// <summary>
        /// Adds data to be used in a workflow.
        /// </summary>
        /// <typeparam name="T">Target type of the data to be stored.</typeparam>
        /// <param name="key">Unique name used to store the data.</param>
        /// <param name="value">The value to be stored.</param>
        /// <exception cref="ArgumentNullException">Raised if the key is not set.</exception>
        public void AddData<T>(string key, T value)
        {
            if(string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));

            if (value != null) _contentData = _contentData.SetItem(key, value);

        }

        /// <summary>
        /// Returns data to be used in a workflow.
        /// </summary>
        /// <typeparam name="T">Target type of the data to be returned.</typeparam>
        /// <param name="key">Unique name used to retrieve the data.</param>
        /// <returns>The stored workflow data, or the default return type of the data.</returns>
        /// <exception cref="ArgumentNullException">Raised if the key is not set.</exception>
        public T GetData<T>(string key)
        {
            if(string.IsNullOrEmpty(key)) throw new ArgumentNullException(nameof(key));

            _contentData.TryGetValue(key, out var data);

            return data != null ? (T)data : default;
        }
    }
}
