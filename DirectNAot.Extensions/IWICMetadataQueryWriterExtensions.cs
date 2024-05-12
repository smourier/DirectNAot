using DirectNAot.Extensions.Com;
using DirectNAot.Extensions.Utilities;

namespace DirectNAot.Extensions;

public static class IWICMetadataQueryWriterExtensions
{
    public static void SetMetadataByName(this IComObject<IWICMetadataQueryWriter> writer, string name, object value, VARENUM? type = null) => SetMetadataByName(writer?.Object!, name, value, type);
    public static void SetMetadataByName(this IWICMetadataQueryWriter writer, string name, object value, VARENUM? type = null)
    {
        ArgumentNullException.ThrowIfNull(writer);
        ArgumentNullException.ThrowIfNull(name);
        using var pv = new PropVariant(value, type);
        using var p = new Pwstr(name);
        writer.SetMetadataByName(p, pv.Detached).ThrowOnError();
    }

    public static void SetMetadataByName(this IComObject<IWICMetadataQueryWriter> writer, string name, PropVariant pv) => SetMetadataByName(writer?.Object!, name, pv);
    public static void SetMetadataByName(this IWICMetadataQueryWriter writer, string name, PropVariant pv)
    {
        ArgumentNullException.ThrowIfNull(writer);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(pv);
        using var p = new Pwstr(name);
        writer.SetMetadataByName(p, pv.Detached).ThrowOnError();
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
