#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-codecapieventdata
[StructLayout(LayoutKind.Sequential)]
public partial struct CodecAPIEventData
{
    public Guid guid;
    public uint dataLength;
    public InlineArrayUInt323 reserved;
}
