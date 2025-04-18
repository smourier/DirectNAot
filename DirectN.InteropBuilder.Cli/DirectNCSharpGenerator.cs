using Win32InteropBuilder;
using Win32InteropBuilder.Generators;
using Win32InteropBuilder.Model;

namespace DirectN.InteropBuilder.Cli
{
    public class DirectNCSharpGenerator : CSharpGenerator
    {
        protected override CSharpGeneratorMethod GenerateCode(BuilderContext context, BuilderType type, BuilderPatchType? patch, BuilderMethod method, CSharpGeneratorMethodOptions options = CSharpGeneratorMethodOptions.None)
        {
            if (type.FullName == TypeMappings.ITextHost ||
                (type.FullName == TypeMappings.ITextHost2))
            {
                if (method.ReturnTypeFullName == FullName.BOOL)
                {
                    context.CurrentWriter!.WriteLine("[return: MarshalAs(UnmanagedType.I4)]");
                }
            }
            return base.GenerateCode(context, type, patch, method, options);
        }
    }
}
