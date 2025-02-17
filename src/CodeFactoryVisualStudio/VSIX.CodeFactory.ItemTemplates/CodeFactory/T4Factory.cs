﻿using System;
using System.Collections.Generic;
using CodeFactory.VisualStudio;
using CodeFactory;
using CodeFactory.DotNet;
using CodeFactory.DotNet.CSharp;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;

namespace $rootnamespace$
{
	public partial class $safeitemrootname$:ICsT4Factory
	{
        /// <summary>
        /// C# models to be used by the T4 code factory.
        /// </summary>
        public CsModelStore CsModels { get; set; }

        /// <summary>
        /// Allows the injection of custom model data into the T4 factory.
        /// </summary>
        public object ModelData { get; set; }

        /// <summary>
        /// Generates the source code from the T4 code factory.
        /// </summary>
        /// <returns>The generated source code.</returns>
        public static string GenerateSource()
        {
            var factory = new $safeitemrootname$ { CsModels = null, ModelData = null };

            return factory.TransformText();
        }

        /// <summary>
        /// Generates the source code from the T4 code factory.
        /// </summary>
        /// <param name="modelStore">The C# model storage that contains all the models to be used with the T4 factory.</param>
        /// <returns>The generated source code.</returns>
        public static string GenerateSource(CsModelStore modelStore)
        {
            var factory = new $safeitemrootname$ { CsModels = modelStore, ModelData = null };

            return factory.TransformText();
        }

        /// <summary>
        /// Generates the source code from the T4 code factory.
        /// </summary>
        /// <param name="modelStore">The C# model storage that contains all the models to be used with the T4 factory.</param>
        /// <param name="modelData">Model data object used by the T4 factory.</param>
        /// <returns>The generated source code.</returns>
        public static string GenerateSource(CsModelStore modelStore, object modelData)
        {
            var factory = new $safeitemrootname$ { CsModels = modelStore, ModelData = modelData };

            return factory.TransformText();
        }

        /// <summary>
        /// Generates the source code from the T4 code factory.
        /// </summary>
        /// <param name="modelData">Model data object used by the T4 factory.</param>
        /// <returns>The generated source code.</returns>
        public static string GenerateSource(object modelData)
        {
            var factory = new $safeitemrootname$ { CsModels = null, ModelData = modelData };

            return factory.TransformText();
        }
    }
}
