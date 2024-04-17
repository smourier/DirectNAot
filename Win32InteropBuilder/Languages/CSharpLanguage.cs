using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Win32InteropBuilder.Model;

namespace Win32InteropBuilder.Languages
{
    public class CSharpLanguage : ILanguage
    {
        public string Name => "CSharp";
        public string FileExtension => ".cs";

        public override string ToString() => Name;

        public virtual string GetValueAsString(object? value)
        {
            if (value == null)
                return "null";

            if (value is Guid guid)
                return $"new(\"{guid}\")";

            if (value is bool b)
                return b ? "true" : "false";

            if (value is string s)
                return $"@\"{s.Replace("\"", "\"\"")}\"";

            return string.Format(CultureInfo.InvariantCulture, "{0}", value);
        }

        [return: NotNullIfNotNull(nameof(name))]
        public virtual string? GetIdentifier(string? name)
        {
            if (name == null)
                return null;

            if (_keywords.Contains(name))
                return "@" + name;

            return name;
        }

        private static readonly ConcurrentBag<string> _keywords =
        [
            "abstract",
            "as",
            "base",
            "bool",
            "break",
            "byte",
            "case",
            "catch",
            "char",
            "checked",
            "class",
            "const",
            "continue",
            "decimal",
            "default",
            "delegate",
            "do",
            "double",
            "else",
            "enum",
            "event",
            "explicit",
            "extern",
            "false",
            "finally",
            "fixed",
            "float",
            "for",
            "foreach",
            "goto",
            "if",
            "implicit",
            "in",
            "int",
            "interface",
            "internal",
            "is",
            "lock",
            "long",
            "namespace",
            "new",
            "null",
            "object",
            "operator",
            "out",
            "override",
            "params",
            "private",
            "protected",
            "public",
            "readonly",
            "ref",
            "return",
            "sbyte",
            "sealed",
            "short",
            "sizeof",
            "stackalloc",
            "static",
            "string",
            "struct",
            "switch",
            "this",
            "throw",
            "true",
            "try",
            "typeof",
            "uint",
            "ulong",
            "unchecked",
            "unsafe",
            "ushort",
            "virtual",
            "void",
            "volatile",
            "while",
        ];

        public virtual void GenerateCode(BuilderContext context, BuilderType type)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.CurrentWriter);
            ArgumentNullException.ThrowIfNull(context.Configuration);
            ArgumentNullException.ThrowIfNull(context.Configuration.Generation);
            ArgumentNullException.ThrowIfNull(type);

            string ns;
            if (GetType() == typeof(BuilderType))
            {
                // it's not structure, interface or enum
                // so it's not unified functions or constants
                // so, don't map namespace
                ns = type.FullName.Namespace;
            }
            else
            {
                ns = context.MapGeneratedFullName(type.FullName).Namespace;
            }

            context.CurrentWriter.WriteLine($"namespace {ns};");
            context.CurrentWriter.WriteLine();
            context.CurrentNamespace = ns;

            if (type.Documentation != null)
            {
                context.CurrentWriter.WriteLine("// " + type.Documentation);
            }

            GenerateTypeCode(context, type);
            context.CurrentNamespace = null;
        }

        protected virtual void GenerateTypeCode(BuilderContext context, BuilderType type)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.CurrentWriter);
            ArgumentNullException.ThrowIfNull(type);

            if (type is EnumType enumType)
            {
                GenerateTypeCode(context, enumType);
                return;
            }

            if (type is InterfaceType interfaceType)
            {
                GenerateTypeCode(context, interfaceType);
                return;
            }

            if (type is InlineArrayType inlineArrayType)
            {
                GenerateTypeCode(context, inlineArrayType);
                return;
            }

            if (type is StructureType structureType)
            {
                GenerateTypeCode(context, structureType);
                return;
            }

            var un = context.Configuration.GetGeneration();

            context.CurrentWriter.Write($"public partial class {type.FullName.Name}");
            context.CurrentWriter.WriteLine();
            context.CurrentWriter.WithParens(() =>
            {
                if (un == null || un.ConstantsFileName == null)
                {
                    for (var i = 0; i < type.Fields.Count; i++)
                    {
                        var field = type.Fields[i];
                        if (field.Documentation != null)
                        {
                            context.CurrentWriter.WriteLine("// " + field.Documentation);
                        }

                        var mapped = context.MapType(field.Type);
                        if (mapped.UnmanagedType.HasValue)
                        {
                            context.CurrentWriter.WriteLine($"[MarshalAs(UnmanagedType.{mapped.UnmanagedType.Value})]");
                        }

                        var constText = field.Attributes.HasFlag(FieldAttributes.Literal) && field.Type.IsConstableType() ? "const" : "static readonly";
                        context.CurrentWriter.WriteLine($"public {constText} {mapped.GetGeneratedName(context)} {field} = {GetValueAsString(field.DefaultValue)};");

                        if (i != type.Fields.Count - 1 || type.Methods.Count > 0)
                        {
                            context.CurrentWriter.WriteLine();
                        }
                    }
                }

                if (un == null || un.FunctionsFileName == null)
                {
                    for (var i = 0; i < type.Methods.Count; i++)
                    {
                        var method = type.Methods[i];

                        if (method.Documentation != null)
                        {
                            context.CurrentWriter.WriteLine("// " + method.Documentation);
                        }

                        if (method.ImportModuleName != null)
                        {
                            var module = method.ImportModuleName;
                            const string dll = ".dll";
                            if (module.EndsWith(dll, StringComparison.InvariantCultureIgnoreCase))
                            {
                                module = module[..^dll.Length];
                            }

                            context.CurrentWriter.Write($"[LibraryImport(\"{module}\"");
                            if (method.IsUnicode)
                            {
                                context.CurrentWriter.Write(", StringMarshalling = StringMarshalling.Utf16");
                            }
                            context.CurrentWriter.WriteLine(")]");
                        }

                        if (method.SupportedOSPlatform != null)
                        {
                            context.CurrentWriter.WriteLine($"[SupportedOSPlatform(\"{method.SupportedOSPlatform}\")]");
                        }

                        context.CurrentWriter.WriteLine("[PreserveSig]");
                        string typeName;
                        if (method.ReturnType != null)
                        {
                            var mapped = context.MapType(method.ReturnType);

                            // don't map here? should be done already? causes trouble with HRESULT
                            //if (mapped.UnmanagedType.HasValue)
                            //{
                            //    context.Writer.WriteLine($"[return: MarshalAs(UnmanagedType.{mapped.UnmanagedType.Value})]");
                            //}

                            typeName = mapped.GetGeneratedName(context);
                        }
                        else
                        {
                            typeName = "void";
                        }

                        context.CurrentWriter.Write($"public static partial {typeName} {method}(");
                        for (var j = 0; j < method.Parameters.Count; j++)
                        {
                            var parameter = method.Parameters[j];
                            parameter.GeneratedCode(context);
                            if (j != method.Parameters.Count - 1)
                            {
                                context.CurrentWriter.Write(", ");
                            }
                        }
                        context.CurrentWriter.WriteLine(");");

                        if (i != type.Methods.Count - 1)
                        {
                            context.CurrentWriter.WriteLine();
                        }
                    }
                }
            });
        }

        protected virtual void GenerateTypeCode(BuilderContext context, StructureType type)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.CurrentWriter);
            ArgumentNullException.ThrowIfNull(type);

            if (type.SupportedOSPlatform != null)
            {
                context.CurrentWriter.WriteLine($"[SupportedOSPlatform(\"{type.SupportedOSPlatform}\")]");
            }

            LayoutKind? lk;
            if (type.TypeAttributes.HasFlag(System.Reflection.TypeAttributes.SequentialLayout))
            {
                lk = LayoutKind.Sequential;
            }
            else if (type.TypeAttributes.HasFlag(System.Reflection.TypeAttributes.ExplicitLayout))
            {
                lk = LayoutKind.Explicit;
            }
            else
            {
                lk = null;
            }

            if (lk.HasValue)
            {
                context.CurrentWriter.WriteLine($"[StructLayout(LayoutKind.{lk})]");
            }

            var ns = type.FullName.NestedName;
            if (ns != null)
            {
                context.CurrentWriter.Write($"public struct {ns}");
            }
            else
            {
                context.CurrentWriter.Write($"public partial struct {type.FullName.Name}");
            }

            context.CurrentWriter.WriteLine();
            context.CurrentWriter.WithParens(() =>
            {
                for (var i = 0; i < type.NestedTypes.Count; i++)
                {
                    var nt = type.NestedTypes[i];
                    GenerateTypeCode(context, nt);
                    if (i <= type.NestedTypes.Count || type.Fields.Count > 0)
                    {
                        context.CurrentWriter.WriteLine();
                    }
                }

                for (var i = 0; i < type.Fields.Count; i++)
                {
                    var field = type.Fields[i];
                    var mapped = context.MapType(field.Type);

                    var addSep = mapped.UnmanagedType.HasValue || field.Offset.HasValue;
                    if (addSep && i > 0)
                    {
                        context.CurrentWriter.WriteLine();
                    }

                    if (mapped.UnmanagedType.HasValue)
                    {
                        context.CurrentWriter.WriteLine($"[MarshalAs(UnmanagedType.{mapped.UnmanagedType.Value})]");
                    }

                    if (field.Offset.HasValue)
                    {
                        context.CurrentWriter.WriteLine($"[FieldOffset({field.Offset.Value})]");
                    }
                    context.CurrentWriter.WriteLine($"public {mapped.GetGeneratedName(context)} {field};");
                }
            });
        }

        public virtual void GenerateTypeCode(BuilderContext context, InlineArrayType type)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.CurrentWriter);
            ArgumentNullException.ThrowIfNull(type);

            context.CurrentWriter.WriteLine($"[InlineArray({type.Size})]");
            context.CurrentWriter.WriteLine($"public partial struct {type.FullName.Name}");
            context.CurrentWriter.WithParens(() =>
            {
                context.CurrentWriter.WriteLine($"public {type.ElementType.GetGeneratedName(context)} Data;");
            });
        }

        protected virtual void GenerateTypeCode(BuilderContext context, InterfaceType type)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.CurrentWriter);
            ArgumentNullException.ThrowIfNull(type);

            if (type.SupportedOSPlatform != null)
            {
                context.CurrentWriter.WriteLine($"[SupportedOSPlatform(\"{type.SupportedOSPlatform}\")]");
            }

            context.CurrentWriter.WriteLine($"[GeneratedComInterface, Guid(\"{type.Guid.GetValueOrDefault()}\")]");
            context.CurrentWriter.Write($"public partial interface {type.FullName.Name}");

            if (type.Interfaces.Count > 0)
            {
                context.CurrentWriter.Write($" : {string.Join(", ", type.Interfaces.Select(i => i.FullName.GetRelativeTo(type.FullName)))}");
            }

            context.CurrentWriter.WriteLine();
            context.CurrentWriter.WithParens(() =>
            {
                for (var i = 0; i < type.Methods.Count; i++)
                {
                    var method = type.Methods[i];
                    context.CurrentWriter.WriteLine("[PreserveSig]");
                    string typeName;
                    if (method.ReturnType != null)
                    {
                        var mapped = context.MapType(method.ReturnType);
                        if (mapped.UnmanagedType.HasValue)
                        {
                            context.CurrentWriter.WriteLine($"[return: MarshalAs(UnmanagedType.{mapped.UnmanagedType.Value})]");
                        }
                        typeName = mapped.GetGeneratedName(context);
                    }
                    else
                    {
                        typeName = "void";
                    }

                    context.CurrentWriter.Write($"{typeName} {method}(");
                    for (var j = 0; j < method.Parameters.Count; j++)
                    {
                        var parameter = method.Parameters[j];
                        parameter.GeneratedCode(context);
                        if (j != method.Parameters.Count - 1)
                        {
                            context.CurrentWriter.Write(", ");
                        }
                    }
                    context.CurrentWriter.WriteLine(");");

                    if (i != type.Methods.Count - 1)
                    {
                        context.CurrentWriter.WriteLine();
                    }
                }
            });
        }

        protected virtual void GenerateTypeCode(BuilderContext context, EnumType type)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.CurrentWriter);
            ArgumentNullException.ThrowIfNull(type);

            if (type.SupportedOSPlatform != null)
            {
                context.CurrentWriter.WriteLine($"[SupportedOSPlatform(\"{type.SupportedOSPlatform}\")]");
            }

            if (type.IsFlags)
            {
                context.CurrentWriter.WriteLine("[Flags]");
            }

            context.CurrentWriter.Write($"public enum {type.FullName.Name}");
            if (type.UnderlyingType != null)
            {
                var typeName = type.UnderlyingType.GetGeneratedName(context);
                if (typeName != "int")
                {
                    context.CurrentWriter.Write($" : {typeName}");
                }
            }

            context.CurrentWriter.WriteLine();
            context.CurrentWriter.WithParens(() =>
            {
                for (var i = 0; i < type.Fields.Count; i++)
                {
                    var field = type.Fields[i];
                    context.CurrentWriter.Write(field);

                    if (field.DefaultValueAsBytes != null)
                    {
                        context.CurrentWriter.Write(" = ");
                        context.CurrentWriter.Write(GetValueAsString(field.DefaultValue));
                    }
                    context.CurrentWriter.WriteLine(',');
                }
            });
        }
    }
}
