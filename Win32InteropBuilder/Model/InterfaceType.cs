using System;
using System.CodeDom.Compiler;
using System.Linq;

namespace Win32InteropBuilder.Model
{
    public class InterfaceType : BuilderType
    {
        public InterfaceType(FullName fullName)
            : base(fullName)
        {
        }

        public virtual bool IsIUnknownDerived { get; set; }

        protected override void GenerateTypeCode(IndentedTextWriter writer)
        {
            ArgumentNullException.ThrowIfNull(writer);
            writer.Write($"public partial interface {FullName.Name}");

            if (Interfaces.Count > 0)
            {
                writer.Write($": {string.Join(", ", Interfaces.Select(i => i.FullName.GetRelativeTo(FullName)))}");
            }

            writer.WriteLine();
            writer.WithParens(() =>
            {
                for (var i = 0; i < Methods.Count; i++)
                {
                    var method = Methods[i];
                    writer.WriteLine("[PreserveSig]");
                    writer.Write(method.ReturnType?.FullName.Name ?? "void");
                    writer.Write(' ');
                    writer.Write(method);

                    writer.Write('(');
                    for (var j = 0; j < method.Parameters.Count; j++)
                    {
                        var parameter = method.Parameters[j];
                        parameter.GeneratedCode(writer);
                        if (j != method.Parameters.Count - 1)
                        {
                            writer.Write(", ");
                        }
                    }
                    writer.WriteLine(");");

                    if (i != Methods.Count - 1)
                    {
                        writer.WriteLine();
                    }
                }
            });
        }
    }
}
