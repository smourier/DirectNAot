namespace DirectN.Extensions.Utilities;

public static class GuidNames
{
    private static readonly ConcurrentDictionary<Type, ConcurrentDictionary<Guid, string>> _guidsNames = new();
    private static readonly ConcurrentDictionary<Guid, string> _iidsNames = new();

    [RequiresUnreferencedCode("Types in assembly can be trimmed")]
    public static void AddClassesGuids(Assembly assembly)
    {
        ArgumentNullException.ThrowIfNull(assembly);
        foreach (var type in assembly.GetTypes())
        {
            if (type.IsInterface)
            {
                var ca = type.GetCustomAttribute<GuidAttribute>();
                if (ca != null)
                {
                    _iidsNames[new Guid(ca.Value)] = "IID_" + type.Name;
                }
            }
        }
    }

    public static string GetConstantName(this Guid guid, bool appendRawValueIfFound = false)
    {
        if (TryGetGuidName(typeof(Constants), guid, out var name))
        {
            if (appendRawValueIfFound)
                return $"{name} ({guid:B})";

            return name;
        }

        if (TryGetGuidName(typeof(UndocumentedConstants), guid, out name))
        {
            if (appendRawValueIfFound)
                return $"{name} ({guid:B})";

            return name;
        }

        return guid.ToString("B");
    }

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
        if (guid == Guid.Empty)
        {
            name = "Empty";
            return true;
        }

        if (_iidsNames.TryGetValue(guid, out name))
            return true;

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
