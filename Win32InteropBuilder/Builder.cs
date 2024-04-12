using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using Win32InteropBuilder.Model;

namespace Win32InteropBuilder
{
    public class Builder
    {
        public virtual BuilderContext CreateBuilderContext(BuilderConfiguration configuration) => new(configuration);

        protected virtual AddWellKnownTypes(IDictionary<FullName, (BuilderType, TypeDefinition)> dictionary)
        {
            //            dictionary.Add(new FullName(typeof(uint)), ;
        }

        public virtual void Build(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            if (context.Configuration.WinMdPath == null)
                throw new ArgumentException(null, nameof(context));

            using var stream = File.OpenRead(context.Configuration.WinMdPath);
            using var pe = new PEReader(stream);
            var reader = pe.GetMetadataReader();
            var matches = new Dictionary<BuilderType, TypeDefinition>();
            var reverses = new HashSet<BuilderType>();
            var all = new Dictionary<FullName, (BuilderType, TypeDefinition)>();
            foreach (var typeDef in reader.TypeDefinitions.Select(reader.GetTypeDefinition))
            {
                var type = new BuilderType(reader.GetFullName(typeDef));
                if (type.FullName.Namespace.Length == 0)
                    continue;

                all[type.FullName] = (type, typeDef);

                foreach (var match in context.Configuration.Inputs.Where(x => x.Matches(type)))
                {
                    if (match.IsReverse)
                    {
                        reverses.Add(type);
                    }
                    else
                    {
                        matches.Add(type, typeDef);
                    }
                }
            }

            // remove excluded matches
            foreach (var match in reverses.ToArray())
            {
                matches.Remove(match);
            }

            var final = new HashSet<BuilderType>();
            foreach (var kv in matches)
            {
                addDependencies(kv.Key, kv.Value);
            }

            foreach (var bt in final)
            {
                Console.WriteLine(bt);
                foreach (var method in bt.Methods)
                {
                    Console.WriteLine($" {method.Name}({string.Join(", ", method.Parameters)})");
                }
                Console.WriteLine();
            }

            void addDependencies(BuilderType type, TypeDefinition? typeDef)
            {
                if (!typeDef.HasValue)
                {
                    typeDef = all[type.FullName].Item2;
                }

                if (!final.Contains(type))
                {
                    foreach (var handle in typeDef.Value.GetMethods())
                    {
                        var methodDef = reader.GetMethodDefinition(handle);
                        var method = new BuilderMethod(reader.GetString(methodDef.Name));
                        type.Methods.Add(method);
                        foreach (var phandle in methodDef.GetParameters())
                        {
                            var parameterDef = reader.GetParameter(phandle);
                            var parameter = new BuilderParameter(reader.GetString(parameterDef.Name), parameterDef.SequenceNumber);
                            // 'this'
                            if (string.IsNullOrEmpty(parameter.Name) && parameter.SequenceNumber == 0)
                                continue;

                            method.Parameters.Add(parameter);
                        }
                        method.SortParameters();

                        var dec = methodDef.DecodeSignature(SignatureTypeProvider.Instance, null);
                        method.ReturnType = dec.ReturnType;

                        if (method.ReturnType != null)
                        {
                            addDependencies(method.ReturnType, null);
                        }

                        for (var i = 0; i < dec.ParameterTypes.Length; i++)
                        {
                            method.Parameters[i].Type = dec.ParameterTypes[i];
                            if (method.Parameters[i].Type != null)
                            {
                                addDependencies(method.Parameters[i].Type!, null);
                            }
                        }
                    }

                    final.Add(type);
                }

                foreach (var iface in typeDef.Value.GetInterfaceImplementations())
                {
                    //var rf = reader.GetTypeReference((TypeReferenceHandle)reader.GetInterfaceImplementation(iface).Interface);
                    var typeRef = new BuilderTypeReference(reader.GetFullName(iface));
                    var typeRefType = all[typeRef.FullName];
                    addDependencies(typeRefType.Item1, typeRefType.Item2);
                }
            }
        }
    }
}
