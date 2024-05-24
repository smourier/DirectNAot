namespace DirectN.Extensions;

public static class IWICMetadataQueryWriterExtensions
{
    public static void SetMetadataByName(this IComObject<IWICMetadataQueryWriter> writer, string name, object? value, VARENUM? type = null) => SetMetadataByName(writer?.Object!, name, value, type);
    public static void SetMetadataByName(this IWICMetadataQueryWriter writer, string name, object? value, VARENUM? type = null)
    {
        ArgumentNullException.ThrowIfNull(writer);
        ArgumentNullException.ThrowIfNull(name);
        using var pv = new PropVariant(value, type);
        writer.SetMetadataByName(PWSTR.From(name), pv.Detach()).ThrowOnError();
    }

    public static void RemoveMetadataByName(this IComObject<IWICMetadataQueryWriter> writer, string name) => RemoveMetadataByName(writer?.Object!, name);
    public static void RemoveMetadataByName(this IWICMetadataQueryWriter writer, string name)
    {
        ArgumentNullException.ThrowIfNull(writer);
        ArgumentNullException.ThrowIfNull(name);
        writer.RemoveMetadataByName(PWSTR.From(name)).ThrowOnError();
    }
}
