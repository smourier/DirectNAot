namespace DirectN.Extensions.Utilities;

public static class GuidNames
{
    private static readonly ConcurrentDictionary<Guid, string> _guidNames = new();

    [RequiresUnreferencedCode("Types in assembly can be trimmed")]
    public static void AddClassesGuids(Assembly assembly)
    {
        ArgumentNullException.ThrowIfNull(assembly);
        foreach (var type in assembly.GetTypes())
        {
            var ca = type.GetCustomAttribute<GuidAttribute>();
            if (ca != null)
            {
                _guidNames[new Guid(ca.Value)] = type.Name;
            }
        }
    }

    public static void AddClassGuids([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.PublicProperties)] this Type type)
    {
        ArgumentNullException.ThrowIfNull(type);

        const BindingFlags flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly;
        var members = type.GetFields(flags).Where(f => f.FieldType == typeof(Guid)).Cast<MemberInfo>()
            .Concat(type.GetProperties(flags).Where(p => p.PropertyType == typeof(Guid)));

        foreach (var member in members)
        {
            _guidNames[(Guid)(member is PropertyInfo property ? property.GetValue(null) : ((FieldInfo)member).GetValue(null))!] = member.Name;
        }
    }

    public static string GetName(this Guid guid)
    {
        if (TryGetName(guid, out var name))
            return name;

        return guid.ToString("B");
    }

    public static bool TryGetName(this Guid guid, [NotNullWhen(true)] out string? name)
    {
        if (guid == Guid.Empty)
        {
            name = "Empty";
            return true;
        }

        return _guidNames.TryGetValue(guid, out name);
    }
}
