#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-metadatatimestamps
public partial struct MetadataTimeStamps
{
    public uint Flags;
    public long Device;
    public long Presentation;
}
