using System;
using Win32InteropBuilder;
using Win32InteropBuilder.Model;

namespace DirectNAot.InteropBuilder
{
    public class Builder : Win32InteropBuilder.Builder
    {
        public const string Namespace = "DirectN";

        public override BuilderContext CreateBuilderContext(BuilderConfiguration configuration)
        {
            var context = base.CreateBuilderContext(configuration);
            context.ImplicitNamespaces.Add(Namespace);
            return context;
        }

        protected override void AddMappedTypes(BuilderContext context)
        {
            base.AddMappedTypes(context);
            MapToDirectNdNamespace(context, FullName.HRESULT);
        }

        protected virtual void MapToDirectNdNamespace(BuilderContext context, FullName fullName)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.Configuration);
            context.MappedTypes[fullName] = new BuilderType(new FullName(Namespace, fullName.Name));
        }
    }
}
