#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/hstring/ns-hstring-hstring_header
public partial struct HSTRING_HEADER
{
    public uint flags;
    public uint length;
    public uint padding1;
    public uint padding2;
    public nint data;
}
