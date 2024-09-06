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

            // aaaah these painful and exotic textserv.h interaces...
            context.AllTypes.TryGetValue(TypeMappings.ITextHost, out var ith);
            fixMethod(ith);
            if (ith != null)
            {
                // aaaah these painful and exotic textserv.h interaces...
                var method = ith.Methods.First(m => m.Name == "TxGetCharFormat");
                method.Parameters[0].Attributes |= ParameterAttributes.Optional;

                method = ith.Methods.First(m => m.Name == "TxGetParaFormat");
                method.Parameters[0].Attributes |= ParameterAttributes.Optional;
            }

            context.AllTypes.TryGetValue(TypeMappings.ITextHost2, out var ith2);
            fixMethod(ith2);
            if (ith2 != null)
            {
                // for some reason, using HCURSOR instead of nint causes crashes (ComWrapper generation bug?)
                var method = ith2.Methods.First(m => m.Name == "TxSetCursor2");
                method.ReturnTypeFullName = WellKnownTypes.SystemIntPtr.FullName;
            }

            void fixMethod(BuilderType? type)
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

                    // using something else than raw structs crashes (ComWrapper generation bug?)
                    var returnName = method.ReturnTypeFullName;
                    if (returnName != null &&
                        returnName != FullName.HRESULT &&
                        returnName != WellKnownTypes.SystemInt32.FullName &&
                        returnName != WellKnownTypes.SystemVoid.FullName)
                    {
                        var returnType = context.AllTypes[returnName];
                        method.ReturnTypeFullName = returnType.Fields[0].TypeFullName;
                    }
                }
            }

            foreach (var type in context.AllTypes.Where(t => t.Value.GetType() == typeof(BuilderType)))
            {
                var m = type.Value.Methods.FirstOrDefault(m => m.Name == "QueryDisplayConfig");
                if (m != null)
                {
                    m.Parameters[2].Attributes |= ParameterAttributes.In;
                    m.Parameters[2].Attributes &= ~ParameterAttributes.Out;
                    m.Parameters[4].Attributes |= ParameterAttributes.In;
                    m.Parameters[4].Attributes &= ~ParameterAttributes.Out;
                    m.Parameters[2].NativeArray = new NativeArray() { CountParameter = m.Parameters[1] };
                    m.Parameters[4].NativeArray = new NativeArray() { CountParameter = m.Parameters[3] };
                    m.Parameters[2].TypeFullName = m.Parameters[2].TypeFullName!.NoPointerFullName;
                    m.Parameters[4].TypeFullName = m.Parameters[4].TypeFullName!.NoPointerFullName;
                    break;
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
