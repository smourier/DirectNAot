using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace DirectNAot.Extensions.Utilities;

public static class GuidNames
{
    private static readonly ConcurrentDictionary<Type, ConcurrentDictionary<Guid, string>> _guidsNames = new();

    public static string GetConstantName(this Guid guid) => GetGuidName(typeof(Constants), guid);
    public static string GetGuidName([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] this Type type, Guid guid)
    {
        ArgumentNullException.ThrowIfNull(type);
        if (TryGetGuidName(type, guid, out var name))
            return name;

        return guid.ToString("B");
    }

    public static bool TryGetGuidName([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] this Type type, Guid guid, [NotNullWhen(true)] out string? name)
    {
        ArgumentNullException.ThrowIfNull(type);
        if (!_guidsNames.TryGetValue(type, out var dic))
        {
            dic = new ConcurrentDictionary<Guid, string>();
            foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly).Where(f => f.FieldType == typeof(Guid)))
            {
                dic[(Guid)field.GetValue(null)!] = field.Name;
            }
            _guidsNames[type] = dic;
        }

        if (dic.TryGetValue(guid, out name))
            return true;

        name = null;
        return false;
    }
}
