﻿using System;
using System.IO;
using Win32InteropBuilder;
using Win32InteropBuilder.Model;

namespace DirectNAot.InteropBuilder.Cli
{
    public partial class Builder : Win32InteropBuilder.Builder
    {
        public const string Namespace = "DirectN";
        public const string ProjectName = "DirectNAot";
        public const string ExtensionsProjectName = "DirectNAot.Extensions";

        public override BuilderContext CreateBuilderContext(BuilderConfiguration configuration, ILanguage language)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(language);

            configuration.OutputDirectoryPath = Path.GetFullPath(Path.Combine(Win32Metadata.SolutionDir, ProjectName, "Generated"));
            configuration.ExtensionsOutputDirectoryPath = Path.GetFullPath(Path.Combine(Win32Metadata.SolutionDir, ExtensionsProjectName, "Extensions"));
            var context = new DirectNBuilderContext(configuration, language);
            context.ImplicitNamespaces.Add(Namespace);
            return context;
        }
    }
}
