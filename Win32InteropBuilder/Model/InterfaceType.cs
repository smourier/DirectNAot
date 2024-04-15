using System;
using System.Linq;

namespace Win32InteropBuilder.Model
{
    public class InterfaceType(FullName fullName) : BuilderType(fullName)
    {
        public virtual bool IsIUnknownDerived { get; set; }

        protected override void CopyTo(BuilderType copy)
        {
            base.CopyTo(copy);
            if (copy is InterfaceType typed)
            {
                typed.IsIUnknownDerived = IsIUnknownDerived;
            }
        }

        protected override void GenerateTypeCode(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.Writer);
            if (SupportedOSPlatform != null)
            {
                context.Writer.WriteLine($"[SupportedOSPlatform(\"{SupportedOSPlatform}\")]");
            }

            context.Writer.WriteLine($"[GeneratedComInterface, Guid(\"{Guid.GetValueOrDefault()}\")]");
            context.Writer.Write($"public partial interface {FullName.Name}");

            if (Interfaces.Count > 0)
            {
                context.Writer.Write($" : {string.Join(", ", Interfaces.Select(i => i.FullName.GetRelativeTo(FullName)))}");
            }

            context.Writer.WriteLine();
            context.Writer.WithParens(() =>
            {
                for (var i = 0; i < Methods.Count; i++)
                {
                    var method = Methods[i];
                    context.Writer.WriteLine("[PreserveSig]");
                    string typeName;
                    if (method.ReturnType != null)
                    {
                        var mapped = context.MapType(method.ReturnType);
                        if (mapped.UnmanagedType.HasValue)
                        {
                            context.Writer.WriteLine($"[return: MarshalAs(UnmanagedType.{mapped.UnmanagedType.Value})]");
                        }
                        typeName = mapped.GetGeneratedName(context);
                    }
                    else
                    {
                        typeName = "void";
                    }

                    context.Writer.Write($"{typeName} {method}(");
                    for (var j = 0; j < method.Parameters.Count; j++)
                    {
                        var parameter = method.Parameters[j];
                        parameter.GeneratedCode(context);
                        if (j != method.Parameters.Count - 1)
                        {
                            context.Writer.Write(", ");
                        }
                    }
                    context.Writer.WriteLine(");");

                    if (i != Methods.Count - 1)
                    {
                        context.Writer.WriteLine();
                    }
                }
            });
        }
    }
}
