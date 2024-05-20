#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/spatialaudiometadata/ns-spatialaudiometadata-spatialaudiometadataitemsinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct SpatialAudioMetadataItemsInfo
{
    public ushort FrameCount;
    public ushort ItemCount;
    public ushort MaxItemCount;
    public uint MaxValueBufferLength;
}
