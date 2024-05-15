using DirectNAot.Extensions.Com;
using DirectNAot.Extensions.Utilities;

namespace DirectNAot.Extensions;

public static class IWICMetadataQueryWriterExtensions
{
    public static void SetMetadataByName(this IComObject<IWICMetadataQueryWriter> writer, string name, object? value, VARENUM? type = null) => SetMetadataByName(writer?.Object!, name, value, type);
    public static void SetMetadataByName(this IWICMetadataQueryWriter writer, string name, object? value, VARENUM? type = null)
    {
        ArgumentNullException.ThrowIfNull(writer);
        ArgumentNullException.ThrowIfNull(name);
        using var pv = new PropVariant(value, type);
        using var p = new Pwstr(name);
        writer.SetMetadataByName(p, pv.Detach()).ThrowOnError();
    }

    public static void RemoveMetadataByName(this IComObject<IWICMetadataQueryWriter> writer, string name) => RemoveMetadataByName(writer?.Object!, name);
    public static void RemoveMetadataByName(this IWICMetadataQueryWriter writer, string name)
    {
        ArgumentNullException.ThrowIfNull(writer);
        ArgumentNullException.ThrowIfNull(name);
        using var p = new Pwstr(name);
        writer.RemoveMetadataByName(p).ThrowOnError();
    }
}
