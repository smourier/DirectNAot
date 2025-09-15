namespace DirectN.Extensions.Utilities;

public static class NamedPropertyStore
{
    public static byte[] Serialize(this IEnumerable<KeyValuePair<string, object?>> dictionary)
    {
        ArgumentNullException.ThrowIfNull(dictionary);
        using var ms = new MemoryStream();
        Serialize(dictionary, ms);
        return ms.ToArray();
    }

    public static void Serialize(this IEnumerable<KeyValuePair<string, object?>> dictionary, Stream stream)
    {
        ArgumentNullException.ThrowIfNull(dictionary);
        ArgumentNullException.ThrowIfNull(stream);

        Functions.PSCreateMemoryPropertyStore(typeof(INamedPropertyStore).GUID, out var store).ThrowOnError();
        using var ps = ComObject.FromPointer<INamedPropertyStore>(store)!;
        foreach (var kv in dictionary)
        {
            ps.Object.SetNamedValue(PWSTR.From(kv.Key), new PropVariant(kv.Value).Detach()).ThrowOnError();
        }

        var serialized = ps.As<IPersistStream>()!;
        serialized.Object.Save(new ManagedIStream(stream), true).ThrowOnError();
    }

    public static IEnumerable<KeyValuePair<string, object?>> Deserialize(byte[] bytes)
    {
        ArgumentNullException.ThrowIfNull(bytes);
        using var ms = new MemoryStream(bytes);
        return [.. Deserialize(ms)];
    }

    public static IEnumerable<KeyValuePair<string, object?>> Deserialize(Stream stream)
    {
        ArgumentNullException.ThrowIfNull(stream);
        Functions.PSCreateMemoryPropertyStore(typeof(INamedPropertyStore).GUID, out var store).ThrowOnError();
        using var ps = ComObject.FromPointer<INamedPropertyStore>(store)!;
        var serialized = ps.As<IPersistStream>()!;
        serialized.Object.Load(new ManagedIStream(stream)).ThrowOnError();
        ps.Object.GetNameCount(out var count).ThrowOnError();
        for (var i = 0; i < count; i++)
        {
            ps.Object.GetNameAt((uint)i, out var bstr).ThrowOnError();
            try
            {
                var name = bstr.ToString();
                ps.Object.GetNamedValue(new PWSTR(bstr.Value), out var propvar).ThrowOnError();
                using var pv = new PropVariant(propvar);
                yield return new KeyValuePair<string, object?>(Marshal.PtrToStringBSTR(bstr.Value), pv.Value);
            }
            finally
            {
                Marshal.FreeBSTR(bstr.Value);
            }
        }
    }
}
