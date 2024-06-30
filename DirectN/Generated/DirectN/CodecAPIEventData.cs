#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-codecapieventdata
public partial struct CodecAPIEventData
{
    public Guid guid;
    public uint dataLength;
    public InlineArrayUInt32_3 reserved;
}
