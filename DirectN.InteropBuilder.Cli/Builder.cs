using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Win32InteropBuilder;
using Win32InteropBuilder.Model;

namespace DirectN.InteropBuilder.Cli
{
    public partial class Builder : Win32InteropBuilder.Builder
    {
        public const string Namespace = "DirectN";
        public const string ProjectName = "DirectN";
        public const string ExtensionsProjectName = "DirectN.Extensions";

        public override BuilderContext CreateBuilderContext(BuilderConfiguration configuration, IGenerator language)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(language);

            configuration.OutputDirectoryPath = Path.GetFullPath(Path.Combine(Win32Metadata.SolutionDir, ProjectName, "Generated"));
            var context = new DirectNBuilderContext(configuration, language);
            context.ImplicitNamespaces.Add(Namespace);
            return context;
        }

        protected override void GatherTypes(BuilderContext context)
        {
            base.GatherTypes(context);
            context.AllTypes.TryGetValue(TypeMappings.ITextHost, out var ith);
            removeRefParameters(ith);
            if (ith != null)
            {
                var method = ith.Methods.First(m => m.Name == "TxGetCharFormat");
                method.Parameters[0].Attributes |= ParameterAttributes.Optional;

                method = ith.Methods.First(m => m.Name == "TxGetParaFormat");
                method.Parameters[0].Attributes |= ParameterAttributes.Optional;
            }

            context.AllTypes.TryGetValue(TypeMappings.ITextHost2, out var ith2);
            removeRefParameters(ith2);

            static void removeRefParameters(BuilderType? type)
            {
                if (type == null)
                    return;

                // most In/Out are optional...
                foreach (var method in type.Methods)
                {
                    foreach (var parameter in method.Parameters)
                    {
                        if (parameter.Attributes.HasFlag(ParameterAttributes.In) &&
                            parameter.Attributes.HasFlag(ParameterAttributes.Out))
                        {
                            parameter.Attributes |= ParameterAttributes.Optional;
                        }
                    }
                }
            }
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
