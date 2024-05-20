using System;
using System.IO;
using Win32InteropBuilder;
using Win32InteropBuilder.Model;

namespace DirectN.InteropBuilder.Cli
{
    public partial class Builder : Win32InteropBuilder.Builder
    {
        public const string Namespace = "DirectN";
        public const string ProjectName = "DirectNAot";
        public const string ExtensionsProjectName = "DirectNAot.Extensions";

        public override BuilderContext CreateBuilderContext(BuilderConfiguration configuration, IGenerator language)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(language);

            configuration.OutputDirectoryPath = Path.GetFullPath(Path.Combine(Win32Metadata.SolutionDir, ProjectName, "Generated"));
            configuration.ExtensionsOutputDirectoryPath = Path.GetFullPath(Path.Combine(Win32Metadata.SolutionDir, ExtensionsProjectName, "Extensions"));
            var context = new DirectNBuilderContext(configuration, language);
            context.ImplicitNamespaces.Add(Namespace);
            return context;
        }

        protected override void AddMappedTypes(BuilderContext context)
        {
            base.AddMappedTypes(context);
            context.MappedTypes[TypeMappings.Point] = context.AllTypes[TypeMappings.POINT];
            context.MappedTypes[TypeMappings.Rect] = context.AllTypes[TypeMappings.RECT];
            context.MappedTypes[TypeMappings.Size] = context.AllTypes[TypeMappings.SIZE];
            context.MappedTypes[TypeMappings.D2D1_COLOR_F] = context.AllTypes[TypeMappings.D3DCOLORVALUE];
            context.MappedTypes[TypeMappings.D2D_COLOR_F] = context.AllTypes[TypeMappings.D3DCOLORVALUE];
        }
    }
}
